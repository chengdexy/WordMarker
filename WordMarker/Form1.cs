using System;
using System.Collections.Generic;
using System.Drawing;
using System.IO;
using System.Windows.Forms;
using Aspose.Words;
using Aspose.Words.Drawing;

namespace WordMarker {
    public partial class frmMain : Form {
        #region 全局配置变量
        static bool markTextSolid;          // 水印类型是否为固定文本, false时为自动编号模式
        static string markText;             // 水印文本, 类型为固定文本时生效
        static int markOrderStart;          // 水印开始编号, 类型为自动编号时生效
        static int markOrderEnd;            // 水印结束编号, 类型为自动编号时生效
        static string markFont;             // 水印字体
        static int markWidth;               // 水印宽度
        static int markHeight;              // 水印高度
        static Color markFontColor;         // 水印文本颜色
        static int markRotation;            // 水印倾斜角度
        static string iniFilePath;          // ini文件存放位置(程序运行目录下)
        #endregion
        #region 事件
        public frmMain() {
            InitializeComponent();
        }
        private void btnStart_Click(object sender, EventArgs e) {
            // 界面数据检查
            if (CheckAllValues()) {
                // 刷新全局变量数值
                RefreshAppSettingValues();
                //确保已经选择了源文档
                if (string.IsNullOrEmpty(lblSource.Text) || (!File.Exists(lblSource.Text.Trim()))) {
                    MessageBox.Show("请选择要添加水印的源文档.", "选择源文档", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    btnOpen.Focus();
                    return;
                }
                //这里开始锁死窗体防止用户误操作
                this.Enabled = false;
                //todo: 确保已经选择了输出目录
                if (markTextSolid) {
                    //固定文本模式
                    CreatDocWithMarkText(markText);
                } else {
                    //自动编号模式
                    // 生成编号文本数组
                    string[] markText = GetMarkText(markOrderStart, markOrderEnd);
                    // 创建输出目录
                    //CreatOutputDirectory();
                    // 依次创建加水印版本文件, 保存至输出目录
                    foreach (string str in markText) {
                        CreatDocWithMarkText(str);
                    }
                }
                if (MessageBox.Show("添加水印完成!是否立刻交由打印机批量打印?", "添加成功,是否批量打印", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes) {
                    //选择了批量打印, 跳转到打印窗口(此窗口为模态框)
                    var frm = new Form2(lblTarget.Text);
                    frm.ShowDialog();
                }
                lblSource.Text = "";
                lblTarget.Text = "";
                this.Enabled = true;
            };


            //// 检查编号文本框内容合法性
            //if (!int.TryParse(lblSource.Text.Trim(), out int maxNumber))
            //{
            //    //txtMarkMaxNumber.SelectAll();
            //    //MessageBox.Show("编号必须为纯数字.");
            //    //txtMarkMaxNumber.Focus();
            //    return;
            //}

        }

        private void RefreshAppSettingValues() {
            markTextSolid = rdoSolid.Checked;
            markText = txtSolidText.Text.Trim();
            markOrderStart = Convert.ToInt32(numOrderStart.Value);
            markOrderEnd = Convert.ToInt32(numOrderEnd.Value);
            markFont = txtFont.Text.Trim();
            markWidth = Convert.ToInt32(numMarkWidth.Value);
            markHeight = Convert.ToInt32(numMarkHeight.Value);
            markFontColor = picFontColor.BackColor;
            markRotation = Convert.ToInt32(numRotation.Value);
        }

        private bool CheckAllValues() {
            if (rdoSolid.Checked) {
                if (string.IsNullOrEmpty(txtSolidText.Text.Trim())) {
                    txtSolidText.Focus();
                    return false;
                }

            }
            if (string.IsNullOrEmpty(txtFont.Text.Trim())) {
                txtFont.Focus();
                return false;
            }
            return true;
        }

        //设置字体文本框
        private void txtFont_Click(object sender, EventArgs e) {
            fontDialog.ShowDialog();
            System.Drawing.Font f = fontDialog.Font;
            txtFont.Text = f.Name;
            txtFont.Font = f;
        }
        //设置水印文字颜色
        private void picFontColor_Click(object sender, EventArgs e) {
            colorDialog.ShowDialog();
            Color c = colorDialog.Color;
            picFontColor.BackColor = c;

        }
        //选择源文档
        private void btnOpen_Click(object sender, EventArgs e) {
            ofdChooseSrcDoc.ShowDialog();
            lblSource.Text = ofdChooseSrcDoc.FileName;
        }
        //重置按钮
        private void btnRetry_Click(object sender, EventArgs e) {
            SetDefault();
        }
        // 选择存储位置
        private void btnTarget_Click(object sender, EventArgs e) {
            if (!string.IsNullOrEmpty(ofdChooseSrcDoc.FileName)) {
                folderDialog.SelectedPath = Path.GetDirectoryName(ofdChooseSrcDoc.FileName);
            }
            folderDialog.ShowDialog();
            lblTarget.Text = folderDialog.SelectedPath;
        }
        private void frmMain_Load(object sender, EventArgs e) {
            iniFilePath = Application.StartupPath + @"\settings.ini";
            SetDefault();
            ChangeRadioChecking();
        }

        private void ChangeRadioChecking() {
            if (rdoSolid.Checked) {
                txtSolidText.Enabled = true;
                numOrderStart.Enabled = false;
                numOrderEnd.Enabled = false;
            } else {
                txtSolidText.Enabled = false;
                numOrderStart.Enabled = true;
                numOrderEnd.Enabled = true;
            }
        }

        // 存为默认按钮
        private void btnSave_Click(object sender, EventArgs e) {
            if (SaveToDefault()) {
                MessageBox.Show("已将当前水印配置保存为默认设置.", "保存成功", MessageBoxButtons.OK, MessageBoxIcon.Information);
            } else {
                MessageBox.Show("写入配置文件失败, 请检查软件权限.", "保存失败", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        private void numOrderEnd_ValueChanged(object sender, EventArgs e) {
            if (numOrderEnd.Value < numOrderStart.Value) {
                numOrderEnd.Value = numOrderStart.Value;
                numOrderEnd.Focus();
            }
        }
        #endregion
        #region 界面及配置文件相关功能
        // 创建初始配置文件
        private void CreateIniFile() {
            OperIni.WriteIni("Default", "TextSolid", "true", iniFilePath);
            OperIni.WriteIni("Default", "Text", "", iniFilePath);
            OperIni.WriteIni("Default", "OrderStart", "0", iniFilePath);
            OperIni.WriteIni("Default", "OrderEnd", "0", iniFilePath);
            OperIni.WriteIni("Default", "Font", "宋体", iniFilePath);
            OperIni.WriteIni("Default", "Width", "500", iniFilePath);
            OperIni.WriteIni("Default", "Height", "100", iniFilePath);
            OperIni.WriteIni("Default", "FontColor", "#000000", iniFilePath);
            OperIni.WriteIni("Default", "Rotation", "-40", iniFilePath);
        }
        // 检查配置文件是否存在
        private bool CheckIniFileExist() {
            return File.Exists(iniFilePath);
        }
        // 读取ini中配置信息并应用到界面上
        private void SetDefault() {
            if (!CheckIniFileExist()) {
                CreateIniFile();
            }
            //读取ini中配置信息
            ReadDefault();
            //应用到界面上
            ApplyDefault();
        }
        // 将全局变量的值应用到界面控件
        private void ApplyDefault() {
            if (markTextSolid) {
                rdoSolid.Checked = true;
            } else {
                rdoOrdered.Checked = true;
            }
            txtSolidText.Text = markText;
            numOrderStart.Value = markOrderStart;
            numOrderEnd.Value = markOrderEnd;
            txtFont.Text = markFont;
            numMarkWidth.Value = markWidth;
            numMarkHeight.Value = markHeight;
            picFontColor.BackColor = markFontColor;
            numRotation.Value = markRotation;
        }
        // 读取ini中配置, 赋值给全局变量
        private void ReadDefault() {
            markTextSolid = Convert.ToBoolean(OperIni.ReadIni("Default", "TextSolid", iniFilePath));
            markText = OperIni.ReadIni("Default", "Text", iniFilePath);
            markOrderStart = Convert.ToInt32(OperIni.ReadIni("Default", "OrderStart", iniFilePath));
            markOrderEnd = Convert.ToInt32(OperIni.ReadIni("Default", "OrderEnd", iniFilePath));
            markFont = OperIni.ReadIni("Default", "Font", iniFilePath);
            markWidth = Convert.ToInt32(OperIni.ReadIni("Default", "Width", iniFilePath));
            markHeight = Convert.ToInt32(OperIni.ReadIni("Default", "Height", iniFilePath));
            markFontColor = ColorTranslator.FromHtml(OperIni.ReadIni("Default", "FontColor", iniFilePath));
            markRotation = Convert.ToInt32(OperIni.ReadIni("Default", "Rotation", iniFilePath));
        }
        // 将当前配置保存如ini文件
        private bool SaveToDefault() {
            try {
                if (!CheckIniFileExist()) {
                    CreateIniFile();
                }
                SaveToIniFile();
                return true;
            } catch (Exception) {
                return false;
            }
        }
        private void SaveToIniFile() {
            OperIni.WriteIni("Default", "TextSolid", rdoSolid.Checked.ToString(), iniFilePath);
            OperIni.WriteIni("Default", "Text", txtSolidText.Text.Trim(), iniFilePath);
            OperIni.WriteIni("Default", "OrderStart", numOrderStart.Value.ToString().Trim(), iniFilePath);
            OperIni.WriteIni("Default", "OrderEnd", numOrderEnd.Value.ToString().Trim(), iniFilePath);
            OperIni.WriteIni("Default", "Font", txtFont.Text.Trim(), iniFilePath);
            OperIni.WriteIni("Default", "Width", numMarkWidth.Value.ToString().Trim(), iniFilePath);
            OperIni.WriteIni("Default", "Height", numMarkHeight.Value.ToString().Trim(), iniFilePath);
            OperIni.WriteIni("Default", "FontColor", ColorTranslator.ToHtml(picFontColor.BackColor), iniFilePath);
            OperIni.WriteIni("Default", "Rotation", numRotation.Value.ToString().Trim(), iniFilePath);
        }
        #endregion
        #region aspose相关
        private void CreatDocWithMarkText(string markText) {
            Document doc = new Document(lblSource.Text.Trim());
            InsertWatermarkText(doc, markText);
            string savePath;
            string srcFileName = Path.GetFileNameWithoutExtension(lblSource.Text.Trim());
            if (string.IsNullOrEmpty(lblTarget.Text)) {
                savePath = Path.GetDirectoryName(lblSource.Text.Trim()) + @"\output\" + srcFileName + markText + Path.GetExtension(lblSource.Text.Trim());
            } else {
                savePath = lblTarget.Text + @"\" + srcFileName + markText + Path.GetExtension(lblSource.Text.Trim());
            }
            doc.Save(savePath);
        }

        private string[] GetMarkText(int startNumber, int endNumber) {
            List<string> resultList = new List<string>();
            for (int i = startNumber; i <= endNumber; i++) {
                resultList.Add(i.ToString("000"));
            }
            return resultList.ToArray();
        }

        private void CreatOutputDirectory() {
            string dPath = Path.GetDirectoryName(ofdChooseSrcDoc.FileName);
            if (!Directory.Exists(dPath + @"\Output")) {
                Directory.CreateDirectory(dPath + @"\Output");
            }
        }

        private bool IsNumber(string str) {
            return int.TryParse(str, out int result);
        }

        private static void InsertWatermarkText(Document doc, string watermarkText) {
            Shape watermark = new Shape(doc, ShapeType.TextPlainText);

            watermark.TextPath.Text = watermarkText;    //水印文本
            watermark.TextPath.FontFamily = markFont;    //水印字体
            watermark.Width = markWidth;  //水印宽度
            watermark.Height = markHeight; //水印高度 (px)

            watermark.Rotation = markRotation;   //旋转

            watermark.Fill.Color = markFontColor;
            watermark.StrokeColor = markFontColor;

            watermark.RelativeHorizontalPosition = RelativeHorizontalPosition.Page; //相对页面的水平位置
            watermark.RelativeVerticalPosition = RelativeVerticalPosition.Page; //相对页面的垂直位置, 这两条确定了页面居中
            watermark.WrapType = WrapType.None;
            watermark.VerticalAlignment = Aspose.Words.Drawing.VerticalAlignment.Center;    //垂直对齐方式
            watermark.HorizontalAlignment = Aspose.Words.Drawing.HorizontalAlignment.Center;    //水平对齐方式

            Paragraph watermarkPara = new Paragraph(doc);
            watermarkPara.AppendChild(watermark);

            foreach (Section sect in doc.Sections) {
                InsertWatermarkIntoHeader(watermarkPara, sect, HeaderFooterType.HeaderPrimary);
                InsertWatermarkIntoHeader(watermarkPara, sect, HeaderFooterType.HeaderFirst);
                InsertWatermarkIntoHeader(watermarkPara, sect, HeaderFooterType.HeaderEven);
            }
        }

        private static void InsertWatermarkIntoHeader(Paragraph watermarkPara, Section sect, HeaderFooterType headerType) {
            HeaderFooter header = sect.HeadersFooters[headerType];

            if (header == null) {
                // There is no header of the specified type in the current section, create it.
                header = new HeaderFooter(sect.Document, headerType);
                sect.HeadersFooters.Add(header);
            }

            // Insert a clone of the watermark into the header.
            header.AppendChild(watermarkPara.Clone(true));
        }
        #endregion

        private void rdoSolid_CheckedChanged(object sender, EventArgs e) {
            ChangeRadioChecking();
        }

        private void frmMain_FormClosing(object sender, FormClosingEventArgs e) {
            if (MessageBox.Show("确定要退出吗?", "退出确认", MessageBoxButtons.YesNo, MessageBoxIcon.Question) != DialogResult.Yes) {
                e.Cancel = true;
            }
        }
    }
}
