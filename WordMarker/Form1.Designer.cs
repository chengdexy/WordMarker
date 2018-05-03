namespace WordMarker
{
    partial class frmMain
    {
        /// <summary>
        /// 必需的设计器变量。
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// 清理所有正在使用的资源。
        /// </summary>
        /// <param name="disposing">如果应释放托管资源，为 true；否则为 false。</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows 窗体设计器生成的代码

        /// <summary>
        /// 设计器支持所需的方法 - 不要修改
        /// 使用代码编辑器修改此方法的内容。
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmMain));
            this.ofdChooseSrcDoc = new System.Windows.Forms.OpenFileDialog();
            this.statBar = new System.Windows.Forms.StatusStrip();
            this.btnOpen = new System.Windows.Forms.Button();
            this.btnTarget = new System.Windows.Forms.Button();
            this.rdoSolid = new System.Windows.Forms.RadioButton();
            this.rdoOrdered = new System.Windows.Forms.RadioButton();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.lblNumber = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.txtOrderEnd = new System.Windows.Forms.TextBox();
            this.txtOrderStart = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.txtNumber = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.txtSolidText = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.label12 = new System.Windows.Forms.Label();
            this.txtRotation = new System.Windows.Forms.TextBox();
            this.label11 = new System.Windows.Forms.Label();
            this.chkRepeat = new System.Windows.Forms.CheckBox();
            this.picFontColor = new System.Windows.Forms.PictureBox();
            this.label10 = new System.Windows.Forms.Label();
            this.txtFontSize = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.txtFont = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.fontDialog = new System.Windows.Forms.FontDialog();
            this.colorDialog = new System.Windows.Forms.ColorDialog();
            this.btnRetry = new System.Windows.Forms.Button();
            this.btnSave = new System.Windows.Forms.Button();
            this.btnStart = new System.Windows.Forms.Button();
            this.lblSource = new System.Windows.Forms.Label();
            this.lblTarget = new System.Windows.Forms.Label();
            this.saveFileDialog = new System.Windows.Forms.SaveFileDialog();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.groupBox3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picFontColor)).BeginInit();
            this.SuspendLayout();
            // 
            // ofdChooseSrcDoc
            // 
            this.ofdChooseSrcDoc.Filter = "Word文档(*.doc *.docx)|*.doc;*.docx";
            this.ofdChooseSrcDoc.Title = "选择要添加水印的Word文档";
            // 
            // statBar
            // 
            this.statBar.Location = new System.Drawing.Point(0, 526);
            this.statBar.Name = "statBar";
            this.statBar.Padding = new System.Windows.Forms.Padding(1, 0, 18, 0);
            this.statBar.Size = new System.Drawing.Size(1046, 22);
            this.statBar.TabIndex = 6;
            this.statBar.Text = "statusStrip1";
            // 
            // btnOpen
            // 
            this.btnOpen.Image = ((System.Drawing.Image)(resources.GetObject("btnOpen.Image")));
            this.btnOpen.Location = new System.Drawing.Point(16, 15);
            this.btnOpen.Name = "btnOpen";
            this.btnOpen.Size = new System.Drawing.Size(200, 200);
            this.btnOpen.TabIndex = 7;
            this.btnOpen.Text = "选择源文档";
            this.btnOpen.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.btnOpen.UseVisualStyleBackColor = true;
            this.btnOpen.Click += new System.EventHandler(this.btnOpen_Click);
            // 
            // btnTarget
            // 
            this.btnTarget.Image = ((System.Drawing.Image)(resources.GetObject("btnTarget.Image")));
            this.btnTarget.Location = new System.Drawing.Point(16, 221);
            this.btnTarget.Name = "btnTarget";
            this.btnTarget.Size = new System.Drawing.Size(200, 200);
            this.btnTarget.TabIndex = 8;
            this.btnTarget.Text = "选择存储位置";
            this.btnTarget.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.btnTarget.UseVisualStyleBackColor = true;
            this.btnTarget.Click += new System.EventHandler(this.btnTarget_Click);
            // 
            // rdoSolid
            // 
            this.rdoSolid.AutoSize = true;
            this.rdoSolid.Checked = true;
            this.rdoSolid.Location = new System.Drawing.Point(33, 32);
            this.rdoSolid.Name = "rdoSolid";
            this.rdoSolid.Size = new System.Drawing.Size(220, 19);
            this.rdoSolid.TabIndex = 1;
            this.rdoSolid.TabStop = true;
            this.rdoSolid.Text = "为每一份输出添加固定的文本";
            this.rdoSolid.UseVisualStyleBackColor = true;
            // 
            // rdoOrdered
            // 
            this.rdoOrdered.AutoSize = true;
            this.rdoOrdered.Location = new System.Drawing.Point(325, 32);
            this.rdoOrdered.Name = "rdoOrdered";
            this.rdoOrdered.Size = new System.Drawing.Size(250, 19);
            this.rdoOrdered.TabIndex = 2;
            this.rdoOrdered.Text = "为每一份输出添加各异的数字编号";
            this.rdoOrdered.UseVisualStyleBackColor = true;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.rdoSolid);
            this.groupBox1.Controls.Add(this.rdoOrdered);
            this.groupBox1.Location = new System.Drawing.Point(237, 15);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(797, 80);
            this.groupBox1.TabIndex = 3;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "水印类型设置";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.lblNumber);
            this.groupBox2.Controls.Add(this.label6);
            this.groupBox2.Controls.Add(this.txtOrderEnd);
            this.groupBox2.Controls.Add(this.txtOrderStart);
            this.groupBox2.Controls.Add(this.label5);
            this.groupBox2.Controls.Add(this.txtNumber);
            this.groupBox2.Controls.Add(this.label4);
            this.groupBox2.Controls.Add(this.txtSolidText);
            this.groupBox2.Controls.Add(this.label3);
            this.groupBox2.Location = new System.Drawing.Point(237, 101);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(797, 80);
            this.groupBox2.TabIndex = 9;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "水印文本设置";
            // 
            // lblNumber
            // 
            this.lblNumber.AutoSize = true;
            this.lblNumber.Location = new System.Drawing.Point(705, 34);
            this.lblNumber.Name = "lblNumber";
            this.lblNumber.Size = new System.Drawing.Size(53, 15);
            this.lblNumber.TabIndex = 8;
            this.lblNumber.Text = "共  份";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(630, 34);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(22, 15);
            this.label6.TabIndex = 7;
            this.label6.Text = "—";
            // 
            // txtOrderEnd
            // 
            this.txtOrderEnd.Location = new System.Drawing.Point(658, 29);
            this.txtOrderEnd.Name = "txtOrderEnd";
            this.txtOrderEnd.Size = new System.Drawing.Size(40, 24);
            this.txtOrderEnd.TabIndex = 6;
            this.txtOrderEnd.Text = "0";
            this.txtOrderEnd.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // txtOrderStart
            // 
            this.txtOrderStart.Location = new System.Drawing.Point(583, 29);
            this.txtOrderStart.Name = "txtOrderStart";
            this.txtOrderStart.Size = new System.Drawing.Size(40, 24);
            this.txtOrderStart.TabIndex = 5;
            this.txtOrderStart.Text = "0";
            this.txtOrderStart.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(494, 34);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(82, 15);
            this.label5.TabIndex = 4;
            this.label5.Text = "自动编号：";
            // 
            // txtNumber
            // 
            this.txtNumber.Location = new System.Drawing.Point(380, 29);
            this.txtNumber.Name = "txtNumber";
            this.txtNumber.Size = new System.Drawing.Size(50, 24);
            this.txtNumber.TabIndex = 3;
            this.txtNumber.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(325, 34);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(52, 15);
            this.label4.TabIndex = 2;
            this.label4.Text = "份数：";
            // 
            // txtSolidText
            // 
            this.txtSolidText.Location = new System.Drawing.Point(119, 31);
            this.txtSolidText.Name = "txtSolidText";
            this.txtSolidText.Size = new System.Drawing.Size(188, 24);
            this.txtSolidText.TabIndex = 1;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(33, 34);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(82, 15);
            this.label3.TabIndex = 0;
            this.label3.Text = "固定文本：";
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.label12);
            this.groupBox3.Controls.Add(this.txtRotation);
            this.groupBox3.Controls.Add(this.label11);
            this.groupBox3.Controls.Add(this.chkRepeat);
            this.groupBox3.Controls.Add(this.picFontColor);
            this.groupBox3.Controls.Add(this.label10);
            this.groupBox3.Controls.Add(this.txtFontSize);
            this.groupBox3.Controls.Add(this.label9);
            this.groupBox3.Controls.Add(this.txtFont);
            this.groupBox3.Controls.Add(this.label8);
            this.groupBox3.Location = new System.Drawing.Point(237, 188);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(797, 233);
            this.groupBox3.TabIndex = 10;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "水印风格设置：";
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(183, 159);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(131, 15);
            this.label12.TabIndex = 10;
            this.label12.Text = "（-90° - 90°）";
            // 
            // txtRotation
            // 
            this.txtRotation.Location = new System.Drawing.Point(119, 154);
            this.txtRotation.Name = "txtRotation";
            this.txtRotation.Size = new System.Drawing.Size(53, 24);
            this.txtRotation.TabIndex = 9;
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(33, 159);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(82, 15);
            this.label11.TabIndex = 8;
            this.label11.Text = "倾斜角度：";
            // 
            // chkRepeat
            // 
            this.chkRepeat.AutoSize = true;
            this.chkRepeat.Location = new System.Drawing.Point(325, 108);
            this.chkRepeat.Name = "chkRepeat";
            this.chkRepeat.Size = new System.Drawing.Size(146, 19);
            this.chkRepeat.TabIndex = 7;
            this.chkRepeat.Text = "水印自动重复显示";
            this.chkRepeat.UseVisualStyleBackColor = true;
            // 
            // picFontColor
            // 
            this.picFontColor.BackColor = System.Drawing.Color.Black;
            this.picFontColor.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.picFontColor.Location = new System.Drawing.Point(119, 102);
            this.picFontColor.Name = "picFontColor";
            this.picFontColor.Size = new System.Drawing.Size(53, 25);
            this.picFontColor.TabIndex = 5;
            this.picFontColor.TabStop = false;
            this.picFontColor.Click += new System.EventHandler(this.picFontColor_Click);
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(33, 109);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(82, 15);
            this.label10.TabIndex = 4;
            this.label10.Text = "设置颜色：";
            // 
            // txtFontSize
            // 
            this.txtFontSize.Location = new System.Drawing.Point(380, 51);
            this.txtFontSize.Name = "txtFontSize";
            this.txtFontSize.Size = new System.Drawing.Size(50, 24);
            this.txtFontSize.TabIndex = 3;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(325, 56);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(52, 15);
            this.label9.TabIndex = 2;
            this.label9.Text = "字号：";
            // 
            // txtFont
            // 
            this.txtFont.Location = new System.Drawing.Point(119, 51);
            this.txtFont.Name = "txtFont";
            this.txtFont.Size = new System.Drawing.Size(188, 24);
            this.txtFont.TabIndex = 1;
            this.txtFont.Click += new System.EventHandler(this.txtFont_Click);
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(33, 56);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(82, 15);
            this.label8.TabIndex = 0;
            this.label8.Text = "设置字体：";
            // 
            // fontDialog
            // 
            this.fontDialog.AllowScriptChange = false;
            this.fontDialog.AllowSimulations = false;
            this.fontDialog.FontMustExist = true;
            this.fontDialog.ShowEffects = false;
            // 
            // btnRetry
            // 
            this.btnRetry.Image = ((System.Drawing.Image)(resources.GetObject("btnRetry.Image")));
            this.btnRetry.Location = new System.Drawing.Point(510, 451);
            this.btnRetry.Name = "btnRetry";
            this.btnRetry.Size = new System.Drawing.Size(150, 60);
            this.btnRetry.TabIndex = 11;
            this.btnRetry.Text = "重置为默认";
            this.btnRetry.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnRetry.UseVisualStyleBackColor = true;
            this.btnRetry.Click += new System.EventHandler(this.btnRetry_Click);
            // 
            // btnSave
            // 
            this.btnSave.Image = ((System.Drawing.Image)(resources.GetObject("btnSave.Image")));
            this.btnSave.Location = new System.Drawing.Point(666, 451);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(150, 60);
            this.btnSave.TabIndex = 12;
            this.btnSave.Text = "保存为默认";
            this.btnSave.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnSave.UseVisualStyleBackColor = true;
            // 
            // btnStart
            // 
            this.btnStart.Image = ((System.Drawing.Image)(resources.GetObject("btnStart.Image")));
            this.btnStart.Location = new System.Drawing.Point(822, 451);
            this.btnStart.Name = "btnStart";
            this.btnStart.Size = new System.Drawing.Size(150, 60);
            this.btnStart.TabIndex = 13;
            this.btnStart.Text = "开始加水印";
            this.btnStart.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnStart.UseVisualStyleBackColor = true;
            // 
            // lblSource
            // 
            this.lblSource.AutoSize = true;
            this.lblSource.Location = new System.Drawing.Point(16, 451);
            this.lblSource.Name = "lblSource";
            this.lblSource.Size = new System.Drawing.Size(83, 15);
            this.lblSource.TabIndex = 14;
            this.lblSource.Text = "源 文 档：";
            // 
            // lblTarget
            // 
            this.lblTarget.AutoSize = true;
            this.lblTarget.Location = new System.Drawing.Point(16, 486);
            this.lblTarget.Name = "lblTarget";
            this.lblTarget.Size = new System.Drawing.Size(82, 15);
            this.lblTarget.TabIndex = 15;
            this.lblTarget.Text = "存储位置：";
            // 
            // frmMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1046, 548);
            this.Controls.Add(this.lblTarget);
            this.Controls.Add(this.lblSource);
            this.Controls.Add(this.btnStart);
            this.Controls.Add(this.btnSave);
            this.Controls.Add(this.btnRetry);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.btnTarget);
            this.Controls.Add(this.btnOpen);
            this.Controls.Add(this.statBar);
            this.Font = new System.Drawing.Font("宋体", 11F);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.MaximizeBox = false;
            this.Name = "frmMain";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "WordMarker v1.0 by Chengdexy.cn";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picFontColor)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.OpenFileDialog ofdChooseSrcDoc;
        private System.Windows.Forms.StatusStrip statBar;
        private System.Windows.Forms.Button btnOpen;
        private System.Windows.Forms.Button btnTarget;
        private System.Windows.Forms.RadioButton rdoSolid;
        private System.Windows.Forms.RadioButton rdoOrdered;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Label lblNumber;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox txtOrderEnd;
        private System.Windows.Forms.TextBox txtOrderStart;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txtNumber;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtSolidText;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.TextBox txtFont;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.FontDialog fontDialog;
        private System.Windows.Forms.PictureBox picFontColor;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.TextBox txtFontSize;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.ColorDialog colorDialog;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.TextBox txtRotation;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.CheckBox chkRepeat;
        private System.Windows.Forms.Button btnRetry;
        private System.Windows.Forms.Button btnSave;
        private System.Windows.Forms.Button btnStart;
        private System.Windows.Forms.Label lblSource;
        private System.Windows.Forms.Label lblTarget;
        private System.Windows.Forms.SaveFileDialog saveFileDialog;
    }
}

