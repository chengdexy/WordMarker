using Aspose.Words;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace WordMarker {
    public partial class Form2 : Form {
        string filePath = "";

        public Form2() {
            InitializeComponent();
        }

        public Form2(string path) {
            InitializeComponent();
            filePath = path;
        }

        private void Form2_Load(object sender, EventArgs e) {
            //获取添加水印后文件存放位置
            lblTarget.Text = filePath;

            //获取可用打印机名单,加入combobox
            string defaultPrinter = (new System.Drawing.Printing.PrintDocument()).PrinterSettings.PrinterName;
            comboBox1.Items.Clear();
            foreach (string printer in System.Drawing.Printing.PrinterSettings.InstalledPrinters) {
                comboBox1.Items.Add(printer);
            }
            comboBox1.Text = defaultPrinter;
            //等待点击开始打印按钮后执行
            //逐个打印文件(这里涉及前面的文件名列表排序
        }

        private void button1_Click(object sender, EventArgs e) {
            //获取添加水印后的文件名列表
            List<string> fileNameList = new List<string>();
            DirectoryInfo fileList = new DirectoryInfo(filePath);
            foreach (FileInfo file in fileList.GetFiles()) {
                fileNameList.Add(file.FullName);
            }
            this.Enabled = false;
            fileNameList.ForEach(fileName => {
                Document doc = new Document(fileName);
                var printer = comboBox1.Text.Trim();
                var fileCount = fileNameList.Count;
                var counter = 1;
                label1.Text = $"正在将文件发送到打印机:{printer} ({counter}/{fileCount})";
                doc.Print(comboBox1.Text.Trim());
            });
            this.Enabled = true;
        }

        private void button2_Click(object sender, EventArgs e) {
            openFileDialog2.ShowDialog();
            filePath = Path.GetDirectoryName(openFileDialog2.FileName);
            MessageBox.Show(filePath);
        }
    }
}
