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

        private void btnGetDocSrcPath_Click(object sender, EventArgs e)
        {
            ofdChooseSrcDoc.ShowDialog();
            txtDocSrcPath.Text = ofdChooseSrcDoc.FileName;
            txtMarkMaxNumber.Enabled = true;
            btnStart.Enabled = true;
        }

        private void btnStart_Click(object sender, EventArgs e)
        {
            //确保已经选择了源文档
            if (string.IsNullOrEmpty(txtDocSrcPath.Text) || (!File.Exists(txtDocSrcPath.Text.Trim())))
            {
                MessageBox.Show("请选择要添加水印的源文档.");
                btnGetDocSrcPath.Focus();
                return;
            }
            // 检查编号文本框内容合法性
            if (!int.TryParse(txtMarkMaxNumber.Text.Trim(), out int maxNumber))
            {
                txtMarkMaxNumber.SelectAll();
                MessageBox.Show("编号必须为纯数字.");
                txtMarkMaxNumber.Focus();
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
            Document doc = new Document(txtDocSrcPath.Text.Trim());
            InsertWatermarkText(doc, markText);
            doc.Save(Path.GetDirectoryName(txtDocSrcPath.Text.Trim()) + @"\output\" + markText + Path.GetExtension(txtDocSrcPath.Text.Trim()));
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

            watermark.TextPath.Text = watermarkText;
            watermark.TextPath.FontFamily = "Arial";
            watermark.Width = 500;
            watermark.Height = 100;

            watermark.Rotation = -40;

            watermark.Fill.Color = Color.Gray;
            watermark.StrokeColor = Color.Gray;

            watermark.RelativeHorizontalPosition = RelativeHorizontalPosition.Page;
            watermark.RelativeVerticalPosition = RelativeVerticalPosition.Page;
            watermark.WrapType = WrapType.None;
            watermark.VerticalAlignment = Aspose.Words.Drawing.VerticalAlignment.Center;
            watermark.HorizontalAlignment = Aspose.Words.Drawing.HorizontalAlignment.Center;

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
    }
}
