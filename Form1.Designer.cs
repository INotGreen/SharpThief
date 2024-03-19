namespace SharpThief
{
    partial class Form1
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.btnClone = new System.Windows.Forms.Button();
            this.btnAssembly = new System.Windows.Forms.CheckBox();
            this.txtFileVersion = new System.Windows.Forms.TextBox();
            this.txtProductVersion = new System.Windows.Forms.TextBox();
            this.txtOriginalFilename = new System.Windows.Forms.TextBox();
            this.txtTrademarks = new System.Windows.Forms.TextBox();
            this.txtCopyright = new System.Windows.Forms.TextBox();
            this.txtCompany = new System.Windows.Forms.TextBox();
            this.label14 = new System.Windows.Forms.Label();
            this.label13 = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.txtDescription = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.txtProduct = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.chkIcon = new System.Windows.Forms.CheckBox();
            this.btnIcon = new System.Windows.Forms.Button();
            this.picIcon = new System.Windows.Forms.PictureBox();
            this.SelectFile = new System.Windows.Forms.Button();
            this.Build = new System.Windows.Forms.Button();
            this.toolStrip1 = new System.Windows.Forms.ToolStrip();
            this.checkBox1 = new System.Windows.Forms.CheckBox();
            this.signatureFile = new System.Windows.Forms.Button();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.languageToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.chineseToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.englishToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.helpToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.txtchangetime = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.picIcon)).BeginInit();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // btnClone
            // 
            this.btnClone.BackColor = System.Drawing.Color.Gainsboro;
            this.btnClone.Enabled = false;
            this.btnClone.Font = new System.Drawing.Font("Segoe UI Emoji", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnClone.Location = new System.Drawing.Point(724, 44);
            this.btnClone.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnClone.Name = "btnClone";
            this.btnClone.Size = new System.Drawing.Size(104, 35);
            this.btnClone.TabIndex = 108;
            this.btnClone.Text = "克隆";
            this.btnClone.UseVisualStyleBackColor = false;
            this.btnClone.Click += new System.EventHandler(this.btnClone_Click);
            // 
            // btnAssembly
            // 
            this.btnAssembly.AutoSize = true;
            this.btnAssembly.BackColor = System.Drawing.SystemColors.Control;
            this.btnAssembly.Font = new System.Drawing.Font("Segoe UI Emoji", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAssembly.Location = new System.Drawing.Point(433, 50);
            this.btnAssembly.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnAssembly.Name = "btnAssembly";
            this.btnAssembly.Size = new System.Drawing.Size(162, 28);
            this.btnAssembly.TabIndex = 107;
            this.btnAssembly.Text = "生成的程序信息";
            this.btnAssembly.UseVisualStyleBackColor = false;
            this.btnAssembly.CheckedChanged += new System.EventHandler(this.btnAssembly_CheckedChanged);
            // 
            // txtFileVersion
            // 
            this.txtFileVersion.BackColor = System.Drawing.Color.White;
            this.txtFileVersion.Enabled = false;
            this.txtFileVersion.Font = new System.Drawing.Font("Segoe UI Emoji", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtFileVersion.Location = new System.Drawing.Point(600, 362);
            this.txtFileVersion.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtFileVersion.Name = "txtFileVersion";
            this.txtFileVersion.Size = new System.Drawing.Size(224, 31);
            this.txtFileVersion.TabIndex = 106;
            // 
            // txtProductVersion
            // 
            this.txtProductVersion.BackColor = System.Drawing.Color.White;
            this.txtProductVersion.Enabled = false;
            this.txtProductVersion.Font = new System.Drawing.Font("Segoe UI Emoji", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtProductVersion.Location = new System.Drawing.Point(600, 325);
            this.txtProductVersion.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtProductVersion.Name = "txtProductVersion";
            this.txtProductVersion.Size = new System.Drawing.Size(224, 31);
            this.txtProductVersion.TabIndex = 105;
            // 
            // txtOriginalFilename
            // 
            this.txtOriginalFilename.BackColor = System.Drawing.Color.White;
            this.txtOriginalFilename.Enabled = false;
            this.txtOriginalFilename.Font = new System.Drawing.Font("Segoe UI Emoji", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtOriginalFilename.Location = new System.Drawing.Point(600, 285);
            this.txtOriginalFilename.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtOriginalFilename.Name = "txtOriginalFilename";
            this.txtOriginalFilename.Size = new System.Drawing.Size(224, 31);
            this.txtOriginalFilename.TabIndex = 104;
            // 
            // txtTrademarks
            // 
            this.txtTrademarks.BackColor = System.Drawing.Color.White;
            this.txtTrademarks.Enabled = false;
            this.txtTrademarks.Font = new System.Drawing.Font("Segoe UI Emoji", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtTrademarks.Location = new System.Drawing.Point(600, 248);
            this.txtTrademarks.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtTrademarks.Name = "txtTrademarks";
            this.txtTrademarks.Size = new System.Drawing.Size(224, 31);
            this.txtTrademarks.TabIndex = 103;
            // 
            // txtCopyright
            // 
            this.txtCopyright.BackColor = System.Drawing.Color.White;
            this.txtCopyright.Enabled = false;
            this.txtCopyright.Font = new System.Drawing.Font("Segoe UI Emoji", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtCopyright.Location = new System.Drawing.Point(600, 211);
            this.txtCopyright.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtCopyright.Name = "txtCopyright";
            this.txtCopyright.Size = new System.Drawing.Size(224, 31);
            this.txtCopyright.TabIndex = 102;
            // 
            // txtCompany
            // 
            this.txtCompany.BackColor = System.Drawing.Color.White;
            this.txtCompany.Enabled = false;
            this.txtCompany.Font = new System.Drawing.Font("Segoe UI Emoji", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtCompany.Location = new System.Drawing.Point(600, 174);
            this.txtCompany.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtCompany.Name = "txtCompany";
            this.txtCompany.Size = new System.Drawing.Size(224, 31);
            this.txtCompany.TabIndex = 101;
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.BackColor = System.Drawing.Color.White;
            this.label14.Font = new System.Drawing.Font("Segoe UI Emoji", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label14.Location = new System.Drawing.Point(429, 327);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(104, 24);
            this.label14.TabIndex = 100;
            this.label14.Text = "产品版本号:";
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.BackColor = System.Drawing.Color.White;
            this.label13.Font = new System.Drawing.Font("Segoe UI Emoji", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label13.Location = new System.Drawing.Point(429, 367);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(104, 24);
            this.label13.TabIndex = 99;
            this.label13.Text = "文件版本号:";
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.BackColor = System.Drawing.Color.White;
            this.label12.Font = new System.Drawing.Font("Segoe UI Emoji", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label12.Location = new System.Drawing.Point(429, 290);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(104, 24);
            this.label12.TabIndex = 98;
            this.label12.Text = "原始文件名:";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.BackColor = System.Drawing.Color.White;
            this.label11.Font = new System.Drawing.Font("Segoe UI Emoji", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label11.Location = new System.Drawing.Point(429, 253);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(50, 24);
            this.label11.TabIndex = 97;
            this.label11.Text = "商标:";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.BackColor = System.Drawing.Color.White;
            this.label10.Font = new System.Drawing.Font("Segoe UI Emoji", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.Location = new System.Drawing.Point(429, 214);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(50, 24);
            this.label10.TabIndex = 96;
            this.label10.Text = "版权:";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.BackColor = System.Drawing.Color.White;
            this.label9.Font = new System.Drawing.Font("Segoe UI Emoji", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.Location = new System.Drawing.Point(429, 177);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(50, 24);
            this.label9.TabIndex = 95;
            this.label9.Text = "公司:";
            // 
            // txtDescription
            // 
            this.txtDescription.BackColor = System.Drawing.Color.White;
            this.txtDescription.Enabled = false;
            this.txtDescription.Font = new System.Drawing.Font("Segoe UI Emoji", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtDescription.Location = new System.Drawing.Point(600, 135);
            this.txtDescription.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtDescription.Name = "txtDescription";
            this.txtDescription.Size = new System.Drawing.Size(224, 31);
            this.txtDescription.TabIndex = 94;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.BackColor = System.Drawing.Color.White;
            this.label7.Font = new System.Drawing.Font("Segoe UI Emoji", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(429, 139);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(50, 24);
            this.label7.TabIndex = 93;
            this.label7.Text = "描述:";
            // 
            // txtProduct
            // 
            this.txtProduct.BackColor = System.Drawing.Color.White;
            this.txtProduct.Enabled = false;
            this.txtProduct.Font = new System.Drawing.Font("Segoe UI Emoji", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtProduct.Location = new System.Drawing.Point(600, 97);
            this.txtProduct.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtProduct.Name = "txtProduct";
            this.txtProduct.Size = new System.Drawing.Size(224, 31);
            this.txtProduct.TabIndex = 92;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.BackColor = System.Drawing.Color.White;
            this.label8.Font = new System.Drawing.Font("Segoe UI Emoji", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(429, 102);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(50, 24);
            this.label8.TabIndex = 91;
            this.label8.Text = "产品:";
            // 
            // chkIcon
            // 
            this.chkIcon.AutoSize = true;
            this.chkIcon.BackColor = System.Drawing.SystemColors.Control;
            this.chkIcon.Font = new System.Drawing.Font("Segoe UI Emoji", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.chkIcon.Location = new System.Drawing.Point(54, 53);
            this.chkIcon.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.chkIcon.Name = "chkIcon";
            this.chkIcon.Size = new System.Drawing.Size(72, 28);
            this.chkIcon.TabIndex = 112;
            this.chkIcon.Text = "图标";
            this.chkIcon.UseVisualStyleBackColor = false;
            this.chkIcon.CheckedChanged += new System.EventHandler(this.chkIcon_CheckedChanged);
            // 
            // btnIcon
            // 
            this.btnIcon.BackColor = System.Drawing.Color.White;
            this.btnIcon.Enabled = false;
            this.btnIcon.Font = new System.Drawing.Font("Segoe UI Emoji", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnIcon.Location = new System.Drawing.Point(166, 47);
            this.btnIcon.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnIcon.Name = "btnIcon";
            this.btnIcon.Size = new System.Drawing.Size(96, 39);
            this.btnIcon.TabIndex = 110;
            this.btnIcon.Text = "选择图标";
            this.btnIcon.UseVisualStyleBackColor = false;
            this.btnIcon.Click += new System.EventHandler(this.btnIcon_Click);
            // 
            // picIcon
            // 
            this.picIcon.BackColor = System.Drawing.Color.White;
            this.picIcon.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.picIcon.ErrorImage = null;
            this.picIcon.InitialImage = null;
            this.picIcon.Location = new System.Drawing.Point(314, 42);
            this.picIcon.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.picIcon.Name = "picIcon";
            this.picIcon.Size = new System.Drawing.Size(54, 54);
            this.picIcon.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.picIcon.TabIndex = 109;
            this.picIcon.TabStop = false;
            // 
            // SelectFile
            // 
            this.SelectFile.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.SelectFile.BackColor = System.Drawing.Color.DarkSalmon;
            this.SelectFile.Font = new System.Drawing.Font("Segoe UI Emoji", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.SelectFile.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.SelectFile.Location = new System.Drawing.Point(54, 221);
            this.SelectFile.Name = "SelectFile";
            this.SelectFile.Size = new System.Drawing.Size(304, 67);
            this.SelectFile.TabIndex = 113;
            this.SelectFile.Text = "选择文件";
            this.SelectFile.UseVisualStyleBackColor = false;
            this.SelectFile.Click += new System.EventHandler(this.button1_Click);
            this.SelectFile.DragDrop += new System.Windows.Forms.DragEventHandler(this.SelectFile_DragDrop);
            this.SelectFile.DragEnter += new System.Windows.Forms.DragEventHandler(this.SelectFile_DragEnter);
            // 
            // Build
            // 
            this.Build.Font = new System.Drawing.Font("Segoe UI Emoji", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Build.Location = new System.Drawing.Point(54, 367);
            this.Build.Name = "Build";
            this.Build.Size = new System.Drawing.Size(98, 44);
            this.Build.TabIndex = 114;
            this.Build.Text = "生成";
            this.Build.UseVisualStyleBackColor = true;
            this.Build.Click += new System.EventHandler(this.button2_Click);
            // 
            // toolStrip1
            // 
            this.toolStrip1.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.toolStrip1.ImageScalingSize = new System.Drawing.Size(24, 24);
            this.toolStrip1.Location = new System.Drawing.Point(0, 457);
            this.toolStrip1.Name = "toolStrip1";
            this.toolStrip1.Size = new System.Drawing.Size(887, 25);
            this.toolStrip1.TabIndex = 115;
            this.toolStrip1.Text = "toolStrip1";
            // 
            // checkBox1
            // 
            this.checkBox1.AutoSize = true;
            this.checkBox1.BackColor = System.Drawing.SystemColors.Control;
            this.checkBox1.Font = new System.Drawing.Font("Segoe UI Emoji", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.checkBox1.Location = new System.Drawing.Point(44, 122);
            this.checkBox1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.checkBox1.Name = "checkBox1";
            this.checkBox1.Size = new System.Drawing.Size(108, 28);
            this.checkBox1.TabIndex = 118;
            this.checkBox1.Text = "签名窃取";
            this.checkBox1.UseVisualStyleBackColor = false;
            this.checkBox1.CheckedChanged += new System.EventHandler(this.checkBox1_CheckedChanged);
            // 
            // signatureFile
            // 
            this.signatureFile.BackColor = System.Drawing.Color.White;
            this.signatureFile.Enabled = false;
            this.signatureFile.Font = new System.Drawing.Font("Segoe UI Emoji", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.signatureFile.Location = new System.Drawing.Point(166, 116);
            this.signatureFile.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.signatureFile.Name = "signatureFile";
            this.signatureFile.Size = new System.Drawing.Size(96, 39);
            this.signatureFile.TabIndex = 117;
            this.signatureFile.Text = "签名文件";
            this.signatureFile.UseVisualStyleBackColor = false;
            this.signatureFile.Click += new System.EventHandler(this.button3_Click);
            // 
            // menuStrip1
            // 
            this.menuStrip1.GripMargin = new System.Windows.Forms.Padding(2, 2, 0, 2);
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(24, 24);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.languageToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(887, 32);
            this.menuStrip1.TabIndex = 119;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // languageToolStripMenuItem
            // 
            this.languageToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.chineseToolStripMenuItem,
            this.englishToolStripMenuItem,
            this.helpToolStripMenuItem});
            this.languageToolStripMenuItem.Name = "languageToolStripMenuItem";
            this.languageToolStripMenuItem.Size = new System.Drawing.Size(111, 28);
            this.languageToolStripMenuItem.Text = "Language";
            // 
            // chineseToolStripMenuItem
            // 
            this.chineseToolStripMenuItem.Name = "chineseToolStripMenuItem";
            this.chineseToolStripMenuItem.Size = new System.Drawing.Size(177, 34);
            this.chineseToolStripMenuItem.Text = "Chinese";
            this.chineseToolStripMenuItem.Click += new System.EventHandler(this.chineseToolStripMenuItem_Click);
            // 
            // englishToolStripMenuItem
            // 
            this.englishToolStripMenuItem.Name = "englishToolStripMenuItem";
            this.englishToolStripMenuItem.Size = new System.Drawing.Size(177, 34);
            this.englishToolStripMenuItem.Text = "English";
            this.englishToolStripMenuItem.Click += new System.EventHandler(this.englishToolStripMenuItem_Click);
            // 
            // helpToolStripMenuItem
            // 
            this.helpToolStripMenuItem.Name = "helpToolStripMenuItem";
            this.helpToolStripMenuItem.Size = new System.Drawing.Size(177, 34);
            this.helpToolStripMenuItem.Text = "Help";
            // 
            // txtchangetime
            // 
            this.txtchangetime.BackColor = System.Drawing.Color.White;
            this.txtchangetime.Enabled = false;
            this.txtchangetime.Font = new System.Drawing.Font("Segoe UI Emoji", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtchangetime.Location = new System.Drawing.Point(600, 397);
            this.txtchangetime.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtchangetime.Name = "txtchangetime";
            this.txtchangetime.Size = new System.Drawing.Size(224, 31);
            this.txtchangetime.TabIndex = 123;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.White;
            this.label1.Font = new System.Drawing.Font("Segoe UI Emoji", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(429, 402);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(86, 24);
            this.label1.TabIndex = 122;
            this.label1.Text = "修改时间:";
            // 
            // button1
            // 
            this.button1.Font = new System.Drawing.Font("Segoe UI Emoji", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.Location = new System.Drawing.Point(211, 367);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(99, 44);
            this.button1.TabIndex = 124;
            this.button1.Text = ".Icon";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click_1);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 18F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(887, 482);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.txtchangetime);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.checkBox1);
            this.Controls.Add(this.signatureFile);
            this.Controls.Add(this.toolStrip1);
            this.Controls.Add(this.menuStrip1);
            this.Controls.Add(this.Build);
            this.Controls.Add(this.SelectFile);
            this.Controls.Add(this.chkIcon);
            this.Controls.Add(this.btnIcon);
            this.Controls.Add(this.picIcon);
            this.Controls.Add(this.btnClone);
            this.Controls.Add(this.btnAssembly);
            this.Controls.Add(this.txtFileVersion);
            this.Controls.Add(this.txtProductVersion);
            this.Controls.Add(this.txtOriginalFilename);
            this.Controls.Add(this.txtTrademarks);
            this.Controls.Add(this.txtCopyright);
            this.Controls.Add(this.txtCompany);
            this.Controls.Add(this.label14);
            this.Controls.Add(this.label13);
            this.Controls.Add(this.label12);
            this.Controls.Add(this.label11);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.txtDescription);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.txtProduct);
            this.Controls.Add(this.label8);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "Form1";
            this.Text = "SharpThief";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.picIcon)).EndInit();
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnClone;
        private System.Windows.Forms.CheckBox btnAssembly;
        private System.Windows.Forms.TextBox txtFileVersion;
        private System.Windows.Forms.TextBox txtProductVersion;
        private System.Windows.Forms.TextBox txtOriginalFilename;
        private System.Windows.Forms.TextBox txtTrademarks;
        private System.Windows.Forms.TextBox txtCopyright;
        private System.Windows.Forms.TextBox txtCompany;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.TextBox txtDescription;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox txtProduct;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.CheckBox chkIcon;
        private System.Windows.Forms.Button btnIcon;
        private System.Windows.Forms.PictureBox picIcon;
        private System.Windows.Forms.Button SelectFile;
        private System.Windows.Forms.Button Build;
        private System.Windows.Forms.ToolStrip toolStrip1;
        private System.Windows.Forms.CheckBox checkBox1;
        private System.Windows.Forms.Button signatureFile;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem languageToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem chineseToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem englishToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem helpToolStripMenuItem;
        private System.Windows.Forms.TextBox txtchangetime;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button button1;
    }
}

