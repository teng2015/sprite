﻿namespace CssBgImageMergeTool
{
    partial class FormMain
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
        /// 设计器支持所需的方法 - 不要
        /// 使用代码编辑器修改此方法的内容。
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormMain));
            this.folderBrowserDialog = new System.Windows.Forms.FolderBrowserDialog();
            this.openFileDialog = new System.Windows.Forms.OpenFileDialog();
            this.comboBoxImgType = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.comboBoxBgColor = new System.Windows.Forms.ComboBox();
            this.txtSass = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.txtDir = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.txtName = new System.Windows.Forms.TextBox();
            this.radioBtnCss = new System.Windows.Forms.RadioButton();
            this.radioBtnSass = new System.Windows.Forms.RadioButton();
            this.txtCss = new System.Windows.Forms.TextBox();
            this.colorDialog = new System.Windows.Forms.ColorDialog();
            this.chkBoxPhone = new System.Windows.Forms.CheckBox();
            this.panelTop = new System.Windows.Forms.Panel();
            this.panelBottom = new System.Windows.Forms.Panel();
            this.buttonMakeBigImageCss = new System.Windows.Forms.Button();
            this.buttonBrowse = new System.Windows.Forms.Button();
            this.buttonVRange = new System.Windows.Forms.Button();
            this.buttonHRange = new System.Windows.Forms.Button();
            this.panelImages = new System.Windows.Forms.Panel();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.panelTop.SuspendLayout();
            this.panelBottom.SuspendLayout();
            this.tableLayoutPanel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // openFileDialog
            // 
            this.openFileDialog.Filter = "所有文件|*.*|Gif文件|*.gif|Jpeg文件|*.jpeg|Jpg文件|*.jpg|Png文件|*.png";
            this.openFileDialog.Multiselect = true;
            // 
            // comboBoxImgType
            // 
            this.comboBoxImgType.FormattingEnabled = true;
            this.comboBoxImgType.Items.AddRange(new object[] {
            "Png",
            "Jpg",
            "Jpeg"});
            this.comboBoxImgType.Location = new System.Drawing.Point(72, 267);
            this.comboBoxImgType.Name = "comboBoxImgType";
            this.comboBoxImgType.Size = new System.Drawing.Size(121, 20);
            this.comboBoxImgType.TabIndex = 7;
            this.comboBoxImgType.Text = "Png";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(2, 270);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(65, 12);
            this.label1.TabIndex = 3;
            this.label1.Text = "大图类型：";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(224, 272);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(53, 12);
            this.label3.TabIndex = 3;
            this.label3.Text = "背景色：";
            // 
            // comboBoxBgColor
            // 
            this.comboBoxBgColor.FormattingEnabled = true;
            this.comboBoxBgColor.Location = new System.Drawing.Point(283, 267);
            this.comboBoxBgColor.Name = "comboBoxBgColor";
            this.comboBoxBgColor.Size = new System.Drawing.Size(121, 20);
            this.comboBoxBgColor.TabIndex = 8;
            this.comboBoxBgColor.Text = "Transparent";
            this.comboBoxBgColor.Leave += new System.EventHandler(this.comboBoxBgColor_Changed);
            // 
            // txtSass
            // 
            this.txtSass.BackColor = System.Drawing.Color.White;
            this.txtSass.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtSass.ForeColor = System.Drawing.Color.RoyalBlue;
            this.txtSass.Location = new System.Drawing.Point(5, 138);
            this.txtSass.Multiline = true;
            this.txtSass.Name = "txtSass";
            this.txtSass.ReadOnly = true;
            this.txtSass.ScrollBars = System.Windows.Forms.ScrollBars.Both;
            this.txtSass.Size = new System.Drawing.Size(837, 112);
            this.txtSass.TabIndex = 11;
            this.txtSass.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txtSass_KeyDown);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(4, 10);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(107, 12);
            this.label2.TabIndex = 13;
            this.label2.Text = "css中文件夹路径：";
            // 
            // txtDir
            // 
            this.txtDir.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtDir.ForeColor = System.Drawing.Color.RoyalBlue;
            this.txtDir.Location = new System.Drawing.Point(115, 7);
            this.txtDir.Name = "txtDir";
            this.txtDir.Size = new System.Drawing.Size(704, 21);
            this.txtDir.TabIndex = 14;
            this.txtDir.Text = "../images";
            this.txtDir.TextChanged += new System.EventHandler(this.txtDir_TextChanged);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(6, 46);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(89, 12);
            this.label5.TabIndex = 15;
            this.label5.Text = "图片文件名称：";
            // 
            // txtName
            // 
            this.txtName.BackColor = System.Drawing.Color.White;
            this.txtName.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtName.ForeColor = System.Drawing.Color.RoyalBlue;
            this.txtName.Location = new System.Drawing.Point(94, 43);
            this.txtName.Name = "txtName";
            this.txtName.Size = new System.Drawing.Size(725, 21);
            this.txtName.TabIndex = 16;
            this.txtName.Text = "img";
            this.txtName.TextChanged += new System.EventHandler(this.txtName_TextChanged);
            // 
            // radioBtnCss
            // 
            this.radioBtnCss.AutoSize = true;
            this.radioBtnCss.Location = new System.Drawing.Point(82, 108);
            this.radioBtnCss.Name = "radioBtnCss";
            this.radioBtnCss.Size = new System.Drawing.Size(65, 16);
            this.radioBtnCss.TabIndex = 17;
            this.radioBtnCss.Text = "css代码";
            this.radioBtnCss.UseVisualStyleBackColor = true;
            this.radioBtnCss.CheckedChanged += new System.EventHandler(this.radioBtnCss_CheckedChanged);
            // 
            // radioBtnSass
            // 
            this.radioBtnSass.AutoSize = true;
            this.radioBtnSass.Checked = true;
            this.radioBtnSass.Location = new System.Drawing.Point(5, 108);
            this.radioBtnSass.Name = "radioBtnSass";
            this.radioBtnSass.Size = new System.Drawing.Size(71, 16);
            this.radioBtnSass.TabIndex = 18;
            this.radioBtnSass.TabStop = true;
            this.radioBtnSass.Text = "sass代码";
            this.radioBtnSass.UseVisualStyleBackColor = true;
            this.radioBtnSass.CheckedChanged += new System.EventHandler(this.radioButton2_CheckedChanged);
            // 
            // txtCss
            // 
            this.txtCss.BackColor = System.Drawing.Color.White;
            this.txtCss.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtCss.ForeColor = System.Drawing.Color.RoyalBlue;
            this.txtCss.Location = new System.Drawing.Point(3, 138);
            this.txtCss.Multiline = true;
            this.txtCss.Name = "txtCss";
            this.txtCss.ReadOnly = true;
            this.txtCss.ScrollBars = System.Windows.Forms.ScrollBars.Both;
            this.txtCss.Size = new System.Drawing.Size(842, 112);
            this.txtCss.TabIndex = 19;
            this.txtCss.Visible = false;
            // 
            // chkBoxPhone
            // 
            this.chkBoxPhone.AutoSize = true;
            this.chkBoxPhone.Location = new System.Drawing.Point(5, 76);
            this.chkBoxPhone.Name = "chkBoxPhone";
            this.chkBoxPhone.Size = new System.Drawing.Size(96, 16);
            this.chkBoxPhone.TabIndex = 20;
            this.chkBoxPhone.Text = "是否是手机端";
            this.chkBoxPhone.UseVisualStyleBackColor = true;
            this.chkBoxPhone.CheckedChanged += new System.EventHandler(this.chkBoxPhone_CheckedChanged);
            // 
            // panelTop
            // 
            this.panelTop.Controls.Add(this.buttonBrowse);
            this.panelTop.Controls.Add(this.buttonVRange);
            this.panelTop.Controls.Add(this.buttonHRange);
            this.panelTop.Controls.Add(this.buttonMakeBigImageCss);
            this.panelTop.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelTop.Location = new System.Drawing.Point(3, 3);
            this.panelTop.Name = "panelTop";
            this.panelTop.Padding = new System.Windows.Forms.Padding(0, 20, 0, 20);
            this.panelTop.Size = new System.Drawing.Size(839, 54);
            this.panelTop.TabIndex = 21;
            // 
            // panelBottom
            // 
            this.panelBottom.Controls.Add(this.txtDir);
            this.panelBottom.Controls.Add(this.chkBoxPhone);
            this.panelBottom.Controls.Add(this.label1);
            this.panelBottom.Controls.Add(this.txtCss);
            this.panelBottom.Controls.Add(this.label3);
            this.panelBottom.Controls.Add(this.radioBtnSass);
            this.panelBottom.Controls.Add(this.radioBtnCss);
            this.panelBottom.Controls.Add(this.comboBoxImgType);
            this.panelBottom.Controls.Add(this.txtName);
            this.panelBottom.Controls.Add(this.comboBoxBgColor);
            this.panelBottom.Controls.Add(this.label5);
            this.panelBottom.Controls.Add(this.txtSass);
            this.panelBottom.Controls.Add(this.label2);
            this.panelBottom.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panelBottom.Location = new System.Drawing.Point(3, 241);
            this.panelBottom.Name = "panelBottom";
            this.panelBottom.Size = new System.Drawing.Size(839, 301);
            this.panelBottom.TabIndex = 0;
            // 
            // buttonMakeBigImageCss
            // 
            this.buttonMakeBigImageCss.BackColor = System.Drawing.Color.RoyalBlue;
            this.buttonMakeBigImageCss.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonMakeBigImageCss.ForeColor = System.Drawing.Color.White;
            this.buttonMakeBigImageCss.Image = global::CssBgImageMergeTool.Properties.Resources.download;
            this.buttonMakeBigImageCss.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.buttonMakeBigImageCss.Location = new System.Drawing.Point(595, 10);
            this.buttonMakeBigImageCss.Name = "buttonMakeBigImageCss";
            this.buttonMakeBigImageCss.Size = new System.Drawing.Size(171, 40);
            this.buttonMakeBigImageCss.TabIndex = 9;
            this.buttonMakeBigImageCss.Text = "生成雪碧图";
            this.buttonMakeBigImageCss.UseVisualStyleBackColor = false;
            this.buttonMakeBigImageCss.Click += new System.EventHandler(this.ButtonMakeBigImageCss_Click);
            // 
            // buttonBrowse
            // 
            this.buttonBrowse.BackColor = System.Drawing.Color.RoyalBlue;
            this.buttonBrowse.FlatAppearance.BorderSize = 0;
            this.buttonBrowse.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonBrowse.ForeColor = System.Drawing.Color.White;
            this.buttonBrowse.Image = global::CssBgImageMergeTool.Properties.Resources.open;
            this.buttonBrowse.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.buttonBrowse.Location = new System.Drawing.Point(12, 10);
            this.buttonBrowse.Name = "buttonBrowse";
            this.buttonBrowse.Size = new System.Drawing.Size(193, 40);
            this.buttonBrowse.TabIndex = 1;
            this.buttonBrowse.Text = "选择多幅小背景图片";
            this.buttonBrowse.UseVisualStyleBackColor = false;
            this.buttonBrowse.Click += new System.EventHandler(this.buttonBrowse_Click);
            // 
            // buttonVRange
            // 
            this.buttonVRange.BackColor = System.Drawing.Color.RoyalBlue;
            this.buttonVRange.FlatAppearance.BorderSize = 0;
            this.buttonVRange.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonVRange.ForeColor = System.Drawing.Color.White;
            this.buttonVRange.Image = global::CssBgImageMergeTool.Properties.Resources.horizontal;
            this.buttonVRange.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.buttonVRange.Location = new System.Drawing.Point(277, 10);
            this.buttonVRange.Name = "buttonVRange";
            this.buttonVRange.Size = new System.Drawing.Size(134, 40);
            this.buttonVRange.TabIndex = 4;
            this.buttonVRange.Text = "小图横排";
            this.buttonVRange.UseVisualStyleBackColor = false;
            this.buttonVRange.Click += new System.EventHandler(this.ButtonVRange_Click);
            // 
            // buttonHRange
            // 
            this.buttonHRange.BackColor = System.Drawing.Color.RoyalBlue;
            this.buttonHRange.FlatAppearance.BorderSize = 0;
            this.buttonHRange.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonHRange.ForeColor = System.Drawing.Color.White;
            this.buttonHRange.Image = global::CssBgImageMergeTool.Properties.Resources.vertical;
            this.buttonHRange.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.buttonHRange.Location = new System.Drawing.Point(437, 10);
            this.buttonHRange.Name = "buttonHRange";
            this.buttonHRange.Size = new System.Drawing.Size(134, 40);
            this.buttonHRange.TabIndex = 5;
            this.buttonHRange.Text = "小图横排";
            this.buttonHRange.UseVisualStyleBackColor = false;
            this.buttonHRange.Click += new System.EventHandler(this.buttonHRange_Click);
            // 
            // panelImages
            // 
            this.panelImages.AutoScroll = true;
            this.panelImages.BackColor = System.Drawing.Color.Transparent;
            this.panelImages.BackgroundImage = global::CssBgImageMergeTool.Properties.Resources.QQ截图201504271504082;
            this.panelImages.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panelImages.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelImages.Location = new System.Drawing.Point(3, 63);
            this.panelImages.Name = "panelImages";
            this.panelImages.Size = new System.Drawing.Size(839, 172);
            this.panelImages.TabIndex = 0;
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 1;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel1.Controls.Add(this.panelTop, 0, 0);
            this.tableLayoutPanel1.Controls.Add(this.panelBottom, 0, 2);
            this.tableLayoutPanel1.Controls.Add(this.panelImages, 0, 1);
            this.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel1.Location = new System.Drawing.Point(0, 0);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 3;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 60F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 307F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(845, 545);
            this.tableLayoutPanel1.TabIndex = 0;
            // 
            // FormMain
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(845, 545);
            this.Controls.Add(this.tableLayoutPanel1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "FormMain";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Css背景图合并工具";
            this.Load += new System.EventHandler(this.FormMain_Load);
            this.panelTop.ResumeLayout(false);
            this.panelBottom.ResumeLayout(false);
            this.panelBottom.PerformLayout();
            this.tableLayoutPanel1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panelImages;
        private System.Windows.Forms.Button buttonBrowse;
        private System.Windows.Forms.FolderBrowserDialog folderBrowserDialog;
        private System.Windows.Forms.Button buttonMakeBigImageCss;
        private System.Windows.Forms.OpenFileDialog openFileDialog;
        private System.Windows.Forms.Button buttonHRange;
        private System.Windows.Forms.Button buttonVRange;
        private System.Windows.Forms.ComboBox comboBoxImgType;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ComboBox comboBoxBgColor;
        private System.Windows.Forms.TextBox txtSass;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtDir;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txtName;
        private System.Windows.Forms.RadioButton radioBtnCss;
        private System.Windows.Forms.RadioButton radioBtnSass;
        private System.Windows.Forms.TextBox txtCss;
        private System.Windows.Forms.ColorDialog colorDialog;
        private System.Windows.Forms.CheckBox chkBoxPhone;
        private System.Windows.Forms.Panel panelTop;
        private System.Windows.Forms.Panel panelBottom;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
    }
}
