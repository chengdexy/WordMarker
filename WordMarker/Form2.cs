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
            txtOutputForder.Text = filePath;

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

        private void btnChangeOutputForder_Click(object sender, EventArgs e) {
            fbdOutput.ShowDialog();
            filePath = fbdOutput.SelectedPath;
            txtOutputForder.Text = filePath;
        }

        private void btnStart_Click(object sender, EventArgs e) {
            //this.Enabled = false;
            //获取添加水印后的文件名列表
            List<string> fileNameList = new List<string>();
            DirectoryInfo fileList = new DirectoryInfo(filePath);
            foreach (FileInfo file in fileList.GetFiles()) {
                fileNameList.Add(file.FullName);
            }
            Disables();
            var counter = 1;
            fileNameList.ForEach(fileName => {
                var printer = comboBox1.Text.Trim();
                var fileCount = fileNameList.Count;
                //var counter = 1;
                lblResult.Text = $"正在将文件发送到打印机:{printer} ({counter}/{fileCount})";
                this.Refresh();
                Document doc = new Document(fileName);
                doc.Print(comboBox1.Text.Trim());
                counter++;
            });
            Enables();
            lblResult.Text = $"所有文档（{fileNameList.Count}）已发送至打印机。可以关闭此工具。";
        }

        private void Enables() {
            this.grpChosePrinter.Enabled = true;
            this.grpOutputForder.Enabled = true;
            this.btnStart.Enabled = true;
        }

        private void Disables() {
            this.grpChosePrinter.Enabled = false;
            this.grpOutputForder.Enabled = false;
            this.btnStart.Enabled = false;
        }

        private void lnkPrinterOpt_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e) {
            string PcName = System.Environment.MachineName;
            string PrinterName = this.comboBox1.Text;
            System.Diagnostics.Process.Start("rundll32.exe", $@"printui.dll,PrintUIEntry /e /n\\{PcName}\\" + $"\"{PrinterName}\"");
        }
    }
}
