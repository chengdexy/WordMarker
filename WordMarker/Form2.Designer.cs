namespace WordMarker {
    partial class Form2 {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing) {
            if (disposing && (components != null)) {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent() {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form2));
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.btnStart = new System.Windows.Forms.Button();
            this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
            this.openFileDialog2 = new System.Windows.Forms.OpenFileDialog();
            this.btnChangeOutputForder = new System.Windows.Forms.Button();
            this.grpOutputForder = new System.Windows.Forms.GroupBox();
            this.txtOutputForder = new System.Windows.Forms.TextBox();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.grpChosePrinter = new System.Windows.Forms.GroupBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.lblResult = new System.Windows.Forms.Label();
            this.fbdOutput = new System.Windows.Forms.FolderBrowserDialog();
            this.lnkPrinterOpt = new System.Windows.Forms.LinkLabel();
            this.grpOutputForder.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            this.grpChosePrinter.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // comboBox1
            // 
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Location = new System.Drawing.Point(51, 49);
            this.comboBox1.Margin = new System.Windows.Forms.Padding(2);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(398, 20);
            this.comboBox1.TabIndex = 23;
            // 
            // btnStart
            // 
            this.btnStart.Location = new System.Drawing.Point(467, 204);
            this.btnStart.Margin = new System.Windows.Forms.Padding(2);
            this.btnStart.Name = "btnStart";
            this.btnStart.Size = new System.Drawing.Size(108, 30);
            this.btnStart.TabIndex = 24;
            this.btnStart.Text = "开始批量打印";
            this.btnStart.UseVisualStyleBackColor = true;
            this.btnStart.Click += new System.EventHandler(this.btnStart_Click);
            // 
            // openFileDialog1
            // 
            this.openFileDialog1.FileName = "openFileDialog1";
            // 
            // openFileDialog2
            // 
            this.openFileDialog2.FileName = "openFileDialog2";
            // 
            // btnChangeOutputForder
            // 
            this.btnChangeOutputForder.Location = new System.Drawing.Point(455, 44);
            this.btnChangeOutputForder.Name = "btnChangeOutputForder";
            this.btnChangeOutputForder.Size = new System.Drawing.Size(34, 23);
            this.btnChangeOutputForder.TabIndex = 26;
            this.btnChangeOutputForder.Text = "...";
            this.btnChangeOutputForder.UseVisualStyleBackColor = true;
            this.btnChangeOutputForder.Click += new System.EventHandler(this.btnChangeOutputForder_Click);
            // 
            // grpOutputForder
            // 
            this.grpOutputForder.Controls.Add(this.txtOutputForder);
            this.grpOutputForder.Controls.Add(this.btnChangeOutputForder);
            this.grpOutputForder.Controls.Add(this.pictureBox2);
            this.grpOutputForder.Location = new System.Drawing.Point(12, 12);
            this.grpOutputForder.Name = "grpOutputForder";
            this.grpOutputForder.Size = new System.Drawing.Size(576, 82);
            this.grpOutputForder.TabIndex = 27;
            this.grpOutputForder.TabStop = false;
            this.grpOutputForder.Text = "选择或更改输出文件夹";
            // 
            // txtOutputForder
            // 
            this.txtOutputForder.Location = new System.Drawing.Point(51, 46);
            this.txtOutputForder.Name = "txtOutputForder";
            this.txtOutputForder.Size = new System.Drawing.Size(398, 21);
            this.txtOutputForder.TabIndex = 21;
            // 
            // pictureBox2
            // 
            this.pictureBox2.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox2.Image")));
            this.pictureBox2.Location = new System.Drawing.Point(14, 35);
            this.pictureBox2.Margin = new System.Windows.Forms.Padding(2);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(32, 32);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox2.TabIndex = 20;
            this.pictureBox2.TabStop = false;
            // 
            // grpChosePrinter
            // 
            this.grpChosePrinter.Controls.Add(this.lnkPrinterOpt);
            this.grpChosePrinter.Controls.Add(this.pictureBox1);
            this.grpChosePrinter.Controls.Add(this.comboBox1);
            this.grpChosePrinter.Location = new System.Drawing.Point(12, 100);
            this.grpChosePrinter.Name = "grpChosePrinter";
            this.grpChosePrinter.Size = new System.Drawing.Size(576, 88);
            this.grpChosePrinter.TabIndex = 27;
            this.grpChosePrinter.TabStop = false;
            this.grpChosePrinter.Text = "选择输出打印机";
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(14, 37);
            this.pictureBox1.Margin = new System.Windows.Forms.Padding(2);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(32, 32);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 21;
            this.pictureBox1.TabStop = false;
            // 
            // lblResult
            // 
            this.lblResult.AutoSize = true;
            this.lblResult.ForeColor = System.Drawing.Color.DarkRed;
            this.lblResult.Location = new System.Drawing.Point(17, 213);
            this.lblResult.Name = "lblResult";
            this.lblResult.Size = new System.Drawing.Size(0, 12);
            this.lblResult.TabIndex = 28;
            // 
            // lnkPrinterOpt
            // 
            this.lnkPrinterOpt.AutoSize = true;
            this.lnkPrinterOpt.Location = new System.Drawing.Point(454, 52);
            this.lnkPrinterOpt.Name = "lnkPrinterOpt";
            this.lnkPrinterOpt.Size = new System.Drawing.Size(65, 12);
            this.lnkPrinterOpt.TabIndex = 25;
            this.lnkPrinterOpt.TabStop = true;
            this.lnkPrinterOpt.Text = "打印首选项";
            this.lnkPrinterOpt.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.lnkPrinterOpt_LinkClicked);
            // 
            // Form2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(600, 250);
            this.Controls.Add(this.lblResult);
            this.Controls.Add(this.grpChosePrinter);
            this.Controls.Add(this.grpOutputForder);
            this.Controls.Add(this.btnStart);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "Form2";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "批量打印工具 v1.0";
            this.Load += new System.EventHandler(this.Form2_Load);
            this.grpOutputForder.ResumeLayout(false);
            this.grpOutputForder.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            this.grpChosePrinter.ResumeLayout(false);
            this.grpChosePrinter.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.Button btnStart;
        private System.Windows.Forms.OpenFileDialog openFileDialog1;
        private System.Windows.Forms.OpenFileDialog openFileDialog2;
        private System.Windows.Forms.Button btnChangeOutputForder;
        private System.Windows.Forms.GroupBox grpOutputForder;
        private System.Windows.Forms.TextBox txtOutputForder;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.GroupBox grpChosePrinter;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label lblResult;
        private System.Windows.Forms.FolderBrowserDialog fbdOutput;
        private System.Windows.Forms.LinkLabel lnkPrinterOpt;
    }
}