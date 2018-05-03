using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Aspose.Words;
using Aspose.Words.Drawing;
using Aspose.Words.Fields;

namespace WordMarker
{
    public partial class frmMain : Form
    {
        public frmMain()
        {
            InitializeComponent();
        }

        private void btnStart_Click(object sender, EventArgs e)
        {
            //确保已经选择了源文档
            if (string.IsNullOrEmpty(lblSource.Text) || (!File.Exists(lblSource.Text.Trim())))
            {
                MessageBox.Show("请选择要添加水印的源文档.");
                lblSource.Focus();
                return;
            }
            // 检查编号文本框内容合法性
            if (!int.TryParse(lblSource.Text.Trim(), out int maxNumber))
            {
                //txtMarkMaxNumber.SelectAll();
                //MessageBox.Show("编号必须为纯数字.");
                //txtMarkMaxNumber.Focus();
                return;
            }
            // 生成编号文本数组
            string[] markText = GetMarkText(maxNumber);
            // 创建输出目录
            CreatOutputDirectory();
            // 依次创建加水印版本文件, 保存至输出目录
            foreach (string str in markText)
            {
                CreatDocWithMarkText(str);
            }
            MessageBox.Show("添加水印完成, 已保存至源文档同目录下的Output文件夹中.");
        }

        #region private methods
        private void CreatDocWithMarkText(string markText)
        {
            Document doc = new Document(lblSource.Text.Trim());
            InsertWatermarkText(doc, markText);
            doc.Save(Path.GetDirectoryName(lblSource.Text.Trim()) + @"\output\" + markText + Path.GetExtension(lblSource.Text.Trim()));
        }

        private string[] GetMarkText(int maxNumber)
        {
            List<string> resultList = new List<string>();
            for (int i = 1; i <= maxNumber; i++)
            {
                resultList.Add(i.ToString("000"));
            }
            return resultList.ToArray();
        }

        private void CreatOutputDirectory()
        {
            string dPath = Path.GetDirectoryName(ofdChooseSrcDoc.FileName);
            if (!Directory.Exists(dPath + @"\Output"))
            {
                Directory.CreateDirectory(dPath + @"\Output");
            }
        }

        private bool IsNumber(string str)
        {
            return int.TryParse(str, out int result);
        }

        private static void InsertWatermarkText(Document doc, string watermarkText)
        {
            Shape watermark = new Shape(doc, ShapeType.TextPlainText);

            watermark.TextPath.Text = watermarkText;    //水印文本
            watermark.TextPath.FontFamily = "Arial";    //水印字体
            watermark.Width = 500;  //水印宽度
            watermark.Height = 100; //水印高度 (px)

            watermark.Rotation = -40;   //旋转

            watermark.Fill.Color = Color.Gray;
            watermark.StrokeColor = Color.Gray;

            watermark.RelativeHorizontalPosition = RelativeHorizontalPosition.Page; //相对页面的水平位置
            watermark.RelativeVerticalPosition = RelativeVerticalPosition.Page; //相对页面的垂直位置, 这两条确定了页面居中
            watermark.WrapType = WrapType.None;
            watermark.VerticalAlignment = Aspose.Words.Drawing.VerticalAlignment.Center;    //垂直对齐方式
            watermark.HorizontalAlignment = Aspose.Words.Drawing.HorizontalAlignment.Center;    //水平对齐方式

            Paragraph watermarkPara = new Paragraph(doc);
            watermarkPara.AppendChild(watermark);

            foreach (Section sect in doc.Sections)
            {
                InsertWatermarkIntoHeader(watermarkPara, sect, HeaderFooterType.HeaderPrimary);
                InsertWatermarkIntoHeader(watermarkPara, sect, HeaderFooterType.HeaderFirst);
                InsertWatermarkIntoHeader(watermarkPara, sect, HeaderFooterType.HeaderEven);
            }
        }

        private static void InsertWatermarkIntoHeader(Paragraph watermarkPara, Section sect, HeaderFooterType headerType)
        {
            HeaderFooter header = sect.HeadersFooters[headerType];

            if (header == null)
            {
                // There is no header of the specified type in the current section, create it.
                header = new HeaderFooter(sect.Document, headerType);
                sect.HeadersFooters.Add(header);
            }

            // Insert a clone of the watermark into the header.
            header.AppendChild(watermarkPara.Clone(true));
        }
        #endregion

        //设置字体文本框
        private void txtFont_Click(object sender, EventArgs e)
        {
            fontDialog.ShowDialog();
            System.Drawing.Font f = fontDialog.Font;
            txtFont.Text = f.Name;
            txtFont.Font = f;
        }

        //设置水印文字颜色
        private void picFontColor_Click(object sender, EventArgs e)
        {
            colorDialog.ShowDialog();
            Color c = colorDialog.Color;
            picFontColor.BackColor = c;

        }

        //选择源文档
        private void btnOpen_Click(object sender, EventArgs e)
        {
            ofdChooseSrcDoc.ShowDialog();
            lblSource.Text = "源 文 档：" + ofdChooseSrcDoc.FileName;
        }

        //重置按钮
        private void btnRetry_Click(object sender, EventArgs e)
        {
            rdoSolid.Checked = true;
            rdoOrdered.Checked = false;

            txtSolidText.Text = "";
            txtSolidText.Enabled = true;

            txtNumber.Text = "";
            txtNumber.Enabled = true;

            txtOrderStart.Text = "0";
            txtOrderEnd.Text = "0";
            lblNumber.Text = "共0份";

            txtFont.Text = "宋体";
            txtFont.Font = new System.Drawing.Font("宋体", 11);   //应定义全局变量存储默认值
            txtFontSize.Text = "11";

            picFontColor.BackColor = Color.Black;
            chkRepeat.Checked = false;

            txtRotation.Text = "-40";

            ofdChooseSrcDoc.FileName = "";
            saveFileDialog.FileName = "";
            lblSource.Text = "源 文 档：";
            lblTarget.Text = "存储位置：";

        }

        // 选择存储位置
        private void btnTarget_Click(object sender, EventArgs e)
        {
            saveFileDialog.ShowDialog();
            lblTarget.Text = "存储位置：" + saveFileDialog.FileName;
        }
    }
}
