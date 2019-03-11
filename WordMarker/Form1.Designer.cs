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
            this.toolStripStatusLabel1 = new System.Windows.Forms.ToolStripStatusLabel();
            this.btnOpen = new System.Windows.Forms.Button();
            this.btnTarget = new System.Windows.Forms.Button();
            this.rdoSolid = new System.Windows.Forms.RadioButton();
            this.rdoOrdered = new System.Windows.Forms.RadioButton();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.numOrderEnd = new System.Windows.Forms.NumericUpDown();
            this.numOrderStart = new System.Windows.Forms.NumericUpDown();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.txtSolidText = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.numRotation = new System.Windows.Forms.NumericUpDown();
            this.picPreview = new System.Windows.Forms.PictureBox();
            this.numMarkHeight = new System.Windows.Forms.NumericUpDown();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.numMarkWidth = new System.Windows.Forms.NumericUpDown();
            this.label11 = new System.Windows.Forms.Label();
            this.picFontColor = new System.Windows.Forms.PictureBox();
            this.label10 = new System.Windows.Forms.Label();
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
            this.folderDialog = new System.Windows.Forms.FolderBrowserDialog();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.pictureBox3 = new System.Windows.Forms.PictureBox();
            this.statBar.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numOrderEnd)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numOrderStart)).BeginInit();
            this.groupBox3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numRotation)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picPreview)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numMarkHeight)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numMarkWidth)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picFontColor)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).BeginInit();
            this.SuspendLayout();
            // 
            // ofdChooseSrcDoc
            // 
            this.ofdChooseSrcDoc.Filter = "Word文档(*.doc *.docx)|*.doc;*.docx";
            this.ofdChooseSrcDoc.Title = "选择要添加水印的Word文档";
            // 
            // statBar
            // 
            this.statBar.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.statBar.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripStatusLabel1});
            this.statBar.Location = new System.Drawing.Point(0, 526);
            this.statBar.Name = "statBar";
            this.statBar.Padding = new System.Windows.Forms.Padding(1, 0, 18, 0);
            this.statBar.Size = new System.Drawing.Size(1046, 22);
            this.statBar.TabIndex = 6;
            // 
            // toolStripStatusLabel1
            // 
            this.toolStripStatusLabel1.Name = "toolStripStatusLabel1";
            this.toolStripStatusLabel1.Size = new System.Drawing.Size(174, 17);
            this.toolStripStatusLabel1.Text = "http://chengdexy.cn 薛源作品";
            // 
            // btnOpen
            // 
            this.btnOpen.Image = ((System.Drawing.Image)(resources.GetObject("btnOpen.Image")));
            this.btnOpen.Location = new System.Drawing.Point(16, 15);
            this.btnOpen.Name = "btnOpen";
            this.btnOpen.Size = new System.Drawing.Size(200, 200);
            this.btnOpen.TabIndex = 1;
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
            this.btnTarget.TabIndex = 2;
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
            this.rdoSolid.TabIndex = 3;
            this.rdoSolid.TabStop = true;
            this.rdoSolid.Text = "为每一份输出添加固定的文本";
            this.rdoSolid.UseVisualStyleBackColor = true;
            this.rdoSolid.CheckedChanged += new System.EventHandler(this.rdoSolid_CheckedChanged);
            // 
            // rdoOrdered
            // 
            this.rdoOrdered.AutoSize = true;
            this.rdoOrdered.Location = new System.Drawing.Point(325, 32);
            this.rdoOrdered.Name = "rdoOrdered";
            this.rdoOrdered.Size = new System.Drawing.Size(250, 19);
            this.rdoOrdered.TabIndex = 4;
            this.rdoOrdered.Text = "为每一份输出添加各异的数字编号";
            this.rdoOrdered.UseVisualStyleBackColor = true;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.pictureBox3);
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
            this.groupBox2.Controls.Add(this.numOrderEnd);
            this.groupBox2.Controls.Add(this.numOrderStart);
            this.groupBox2.Controls.Add(this.label6);
            this.groupBox2.Controls.Add(this.label5);
            this.groupBox2.Controls.Add(this.txtSolidText);
            this.groupBox2.Controls.Add(this.label3);
            this.groupBox2.Location = new System.Drawing.Point(237, 101);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(797, 80);
            this.groupBox2.TabIndex = 9;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "水印文本设置";
            // 
            // numOrderEnd
            // 
            this.numOrderEnd.Location = new System.Drawing.Point(540, 29);
            this.numOrderEnd.Maximum = new decimal(new int[] {
            999,
            0,
            0,
            0});
            this.numOrderEnd.Name = "numOrderEnd";
            this.numOrderEnd.Size = new System.Drawing.Size(68, 24);
            this.numOrderEnd.TabIndex = 7;
            this.numOrderEnd.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.numOrderEnd.ValueChanged += new System.EventHandler(this.numOrderEnd_ValueChanged);
            // 
            // numOrderStart
            // 
            this.numOrderStart.Location = new System.Drawing.Point(438, 29);
            this.numOrderStart.Maximum = new decimal(new int[] {
            999,
            0,
            0,
            0});
            this.numOrderStart.Name = "numOrderStart";
            this.numOrderStart.Size = new System.Drawing.Size(68, 24);
            this.numOrderStart.TabIndex = 6;
            this.numOrderStart.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(512, 34);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(22, 15);
            this.label6.TabIndex = 7;
            this.label6.Text = "—";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(350, 34);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(82, 15);
            this.label5.TabIndex = 4;
            this.label5.Text = "自动编号：";
            // 
            // txtSolidText
            // 
            this.txtSolidText.Location = new System.Drawing.Point(119, 31);
            this.txtSolidText.Name = "txtSolidText";
            this.txtSolidText.Size = new System.Drawing.Size(188, 24);
            this.txtSolidText.TabIndex = 5;
            this.txtSolidText.TabStop = false;
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
            this.groupBox3.Controls.Add(this.numRotation);
            this.groupBox3.Controls.Add(this.picPreview);
            this.groupBox3.Controls.Add(this.numMarkHeight);
            this.groupBox3.Controls.Add(this.label2);
            this.groupBox3.Controls.Add(this.label1);
            this.groupBox3.Controls.Add(this.numMarkWidth);
            this.groupBox3.Controls.Add(this.label11);
            this.groupBox3.Controls.Add(this.picFontColor);
            this.groupBox3.Controls.Add(this.label10);
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
            // numRotation
            // 
            this.numRotation.Location = new System.Drawing.Point(119, 187);
            this.numRotation.Maximum = new decimal(new int[] {
            90,
            0,
            0,
            0});
            this.numRotation.Minimum = new decimal(new int[] {
            90,
            0,
            0,
            -2147483648});
            this.numRotation.Name = "numRotation";
            this.numRotation.Size = new System.Drawing.Size(78, 24);
            this.numRotation.TabIndex = 11;
            this.numRotation.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // picPreview
            // 
            this.picPreview.Location = new System.Drawing.Point(452, 24);
            this.picPreview.Name = "picPreview";
            this.picPreview.Size = new System.Drawing.Size(339, 203);
            this.picPreview.TabIndex = 15;
            this.picPreview.TabStop = false;
            // 
            // numMarkHeight
            // 
            this.numMarkHeight.Location = new System.Drawing.Point(338, 46);
            this.numMarkHeight.Maximum = new decimal(new int[] {
            999,
            0,
            0,
            0});
            this.numMarkHeight.Minimum = new decimal(new int[] {
            10,
            0,
            0,
            0});
            this.numMarkHeight.Name = "numMarkHeight";
            this.numMarkHeight.Size = new System.Drawing.Size(85, 24);
            this.numMarkHeight.TabIndex = 9;
            this.numMarkHeight.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.numMarkHeight.Value = new decimal(new int[] {
            10,
            0,
            0,
            0});
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(282, 51);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(54, 15);
            this.label2.TabIndex = 13;
            this.label2.Text = "高(px)";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(121, 51);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(54, 15);
            this.label1.TabIndex = 12;
            this.label1.Text = "宽(px)";
            // 
            // numMarkWidth
            // 
            this.numMarkWidth.Location = new System.Drawing.Point(177, 46);
            this.numMarkWidth.Maximum = new decimal(new int[] {
            999,
            0,
            0,
            0});
            this.numMarkWidth.Minimum = new decimal(new int[] {
            10,
            0,
            0,
            0});
            this.numMarkWidth.Name = "numMarkWidth";
            this.numMarkWidth.Size = new System.Drawing.Size(78, 24);
            this.numMarkWidth.TabIndex = 8;
            this.numMarkWidth.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.numMarkWidth.Value = new decimal(new int[] {
            10,
            0,
            0,
            0});
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(33, 192);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(82, 15);
            this.label11.TabIndex = 8;
            this.label11.Text = "倾斜角度：";
            // 
            // picFontColor
            // 
            this.picFontColor.BackColor = System.Drawing.Color.Black;
            this.picFontColor.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.picFontColor.Location = new System.Drawing.Point(119, 140);
            this.picFontColor.Name = "picFontColor";
            this.picFontColor.Size = new System.Drawing.Size(53, 25);
            this.picFontColor.TabIndex = 5;
            this.picFontColor.TabStop = false;
            this.picFontColor.Click += new System.EventHandler(this.picFontColor_Click);
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(33, 145);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(82, 15);
            this.label10.TabIndex = 4;
            this.label10.Text = "设置颜色：";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(33, 51);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(82, 15);
            this.label9.TabIndex = 2;
            this.label9.Text = "水印大小：";
            // 
            // txtFont
            // 
            this.txtFont.BackColor = System.Drawing.SystemColors.Window;
            this.txtFont.Location = new System.Drawing.Point(119, 93);
            this.txtFont.Name = "txtFont";
            this.txtFont.ReadOnly = true;
            this.txtFont.Size = new System.Drawing.Size(188, 24);
            this.txtFont.TabIndex = 10;
            this.txtFont.Click += new System.EventHandler(this.txtFont_Click);
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(33, 98);
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
            this.btnRetry.Font = new System.Drawing.Font("宋体", 10F);
            this.btnRetry.Image = ((System.Drawing.Image)(resources.GetObject("btnRetry.Image")));
            this.btnRetry.Location = new System.Drawing.Point(461, 449);
            this.btnRetry.Name = "btnRetry";
            this.btnRetry.Size = new System.Drawing.Size(182, 60);
            this.btnRetry.TabIndex = 12;
            this.btnRetry.Text = "重置为默认";
            this.btnRetry.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnRetry.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnRetry.UseVisualStyleBackColor = true;
            this.btnRetry.Click += new System.EventHandler(this.btnRetry_Click);
            // 
            // btnSave
            // 
            this.btnSave.Font = new System.Drawing.Font("宋体", 10F);
            this.btnSave.Image = ((System.Drawing.Image)(resources.GetObject("btnSave.Image")));
            this.btnSave.Location = new System.Drawing.Point(643, 449);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(182, 60);
            this.btnSave.TabIndex = 13;
            this.btnSave.Text = "保存为默认";
            this.btnSave.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnSave.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnSave.UseVisualStyleBackColor = true;
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // btnStart
            // 
            this.btnStart.Font = new System.Drawing.Font("宋体", 10F);
            this.btnStart.Image = ((System.Drawing.Image)(resources.GetObject("btnStart.Image")));
            this.btnStart.Location = new System.Drawing.Point(825, 449);
            this.btnStart.Name = "btnStart";
            this.btnStart.Size = new System.Drawing.Size(182, 60);
            this.btnStart.TabIndex = 14;
            this.btnStart.Text = "开始加水印";
            this.btnStart.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnStart.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnStart.UseVisualStyleBackColor = true;
            this.btnStart.Click += new System.EventHandler(this.btnStart_Click);
            // 
            // lblSource
            // 
            this.lblSource.AutoSize = true;
            this.lblSource.Location = new System.Drawing.Point(55, 454);
            this.lblSource.Name = "lblSource";
            this.lblSource.Size = new System.Drawing.Size(0, 15);
            this.lblSource.TabIndex = 14;
            // 
            // lblTarget
            // 
            this.lblTarget.AutoSize = true;
            this.lblTarget.Location = new System.Drawing.Point(55, 494);
            this.lblTarget.Name = "lblTarget";
            this.lblTarget.Size = new System.Drawing.Size(0, 15);
            this.lblTarget.TabIndex = 15;
            // 
            // folderDialog
            // 
            this.folderDialog.Description = "选择添加水印后的文档的存储位置";
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(16, 451);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(20, 20);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 16;
            this.pictureBox1.TabStop = false;
            // 
            // pictureBox2
            // 
            this.pictureBox2.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox2.Image")));
            this.pictureBox2.Location = new System.Drawing.Point(16, 491);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(20, 20);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox2.TabIndex = 17;
            this.pictureBox2.TabStop = false;
            // 
            // pictureBox3
            // 
            this.pictureBox3.Cursor = System.Windows.Forms.Cursors.Hand;
            this.pictureBox3.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox3.Image")));
            this.pictureBox3.Location = new System.Drawing.Point(715, 16);
            this.pictureBox3.Name = "pictureBox3";
            this.pictureBox3.Size = new System.Drawing.Size(55, 55);
            this.pictureBox3.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox3.TabIndex = 18;
            this.pictureBox3.TabStop = false;
            this.pictureBox3.Click += new System.EventHandler(this.pictureBox3_Click);
            // 
            // frmMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1046, 548);
            this.Controls.Add(this.pictureBox2);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.btnStart);
            this.Controls.Add(this.btnSave);
            this.Controls.Add(this.btnRetry);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.btnTarget);
            this.Controls.Add(this.btnOpen);
            this.Controls.Add(this.statBar);
            this.Controls.Add(this.lblTarget);
            this.Controls.Add(this.lblSource);
            this.Font = new System.Drawing.Font("宋体", 11F);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "frmMain";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "WordMarker v3.0 by Chengdexy.cn";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.frmMain_FormClosing);
            this.Load += new System.EventHandler(this.frmMain_Load);
            this.statBar.ResumeLayout(false);
            this.statBar.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numOrderEnd)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numOrderStart)).EndInit();
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numRotation)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picPreview)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numMarkHeight)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numMarkWidth)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picFontColor)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).EndInit();
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
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txtSolidText;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.TextBox txtFont;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.FontDialog fontDialog;
        private System.Windows.Forms.PictureBox picFontColor;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.ColorDialog colorDialog;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Button btnRetry;
        private System.Windows.Forms.Button btnSave;
        private System.Windows.Forms.Button btnStart;
        private System.Windows.Forms.Label lblSource;
        private System.Windows.Forms.Label lblTarget;
        private System.Windows.Forms.FolderBrowserDialog folderDialog;
        private System.Windows.Forms.NumericUpDown numOrderEnd;
        private System.Windows.Forms.NumericUpDown numOrderStart;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.NumericUpDown numMarkWidth;
        private System.Windows.Forms.NumericUpDown numMarkHeight;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.PictureBox picPreview;
        private System.Windows.Forms.NumericUpDown numRotation;
        private System.Windows.Forms.ToolStripStatusLabel toolStripStatusLabel1;
        private System.Windows.Forms.PictureBox pictureBox3;
    }
}

