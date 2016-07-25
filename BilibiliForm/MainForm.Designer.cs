namespace BilibiliForm
{
    partial class MainForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainForm));
            this.pbLogo = new CCWin.SkinControl.SkinPictureBox();
            this.txtUrl = new CCWin.SkinControl.SkinTextBox();
            this.btnGo = new CCWin.SkinControl.SkinButton();
            this.skinGroupBox1 = new CCWin.SkinControl.SkinGroupBox();
            this.lblTitle = new System.Windows.Forms.Label();
            this.skinGroupBox2 = new CCWin.SkinControl.SkinGroupBox();
            this.lblbqCount = new System.Windows.Forms.Label();
            this.lblbq = new System.Windows.Forms.Label();
            this.btnbqCopy = new CCWin.SkinControl.SkinButton();
            this.btnbqDown = new CCWin.SkinControl.SkinButton();
            this.skinGroupBox3 = new CCWin.SkinControl.SkinGroupBox();
            this.lblgqCount = new System.Windows.Forms.Label();
            this.lblgq = new System.Windows.Forms.Label();
            this.btngqCopy = new CCWin.SkinControl.SkinButton();
            this.btngqDown = new CCWin.SkinControl.SkinButton();
            this.skinGroupBox4 = new CCWin.SkinControl.SkinGroupBox();
            this.lblcqCount = new System.Windows.Forms.Label();
            this.lblcq = new System.Windows.Forms.Label();
            this.btncqCopy = new CCWin.SkinControl.SkinButton();
            this.btncqDown = new CCWin.SkinControl.SkinButton();
            this.txtStatus = new System.Windows.Forms.TextBox();
            this.skinGroupBox5 = new CCWin.SkinControl.SkinGroupBox();
            this.lblUser = new System.Windows.Forms.Label();
            this.nIcon = new System.Windows.Forms.NotifyIcon(this.components);
            this.ctmsIcon = new CCWin.SkinControl.SkinContextMenuStrip();
            this.显示主窗体ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.退出ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            ((System.ComponentModel.ISupportInitialize)(this.pbLogo)).BeginInit();
            this.skinGroupBox1.SuspendLayout();
            this.skinGroupBox2.SuspendLayout();
            this.skinGroupBox3.SuspendLayout();
            this.skinGroupBox4.SuspendLayout();
            this.skinGroupBox5.SuspendLayout();
            this.ctmsIcon.SuspendLayout();
            this.SuspendLayout();
            // 
            // pbLogo
            // 
            this.pbLogo.BackColor = System.Drawing.Color.Transparent;
            this.pbLogo.Image = global::BilibiliForm.Properties.Resources.logo;
            this.pbLogo.Location = new System.Drawing.Point(2, 34);
            this.pbLogo.Name = "pbLogo";
            this.pbLogo.Size = new System.Drawing.Size(564, 262);
            this.pbLogo.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pbLogo.TabIndex = 0;
            this.pbLogo.TabStop = false;
            this.pbLogo.Tag = "1";
            // 
            // txtUrl
            // 
            this.txtUrl.BackColor = System.Drawing.Color.Transparent;
            this.txtUrl.DownBack = null;
            this.txtUrl.Icon = null;
            this.txtUrl.IconIsButton = false;
            this.txtUrl.IconMouseState = CCWin.SkinClass.ControlState.Normal;
            this.txtUrl.IsPasswordChat = '\0';
            this.txtUrl.IsSystemPasswordChar = false;
            this.txtUrl.Lines = new string[0];
            this.txtUrl.Location = new System.Drawing.Point(3, 267);
            this.txtUrl.Margin = new System.Windows.Forms.Padding(0);
            this.txtUrl.MaxLength = 32767;
            this.txtUrl.MinimumSize = new System.Drawing.Size(28, 28);
            this.txtUrl.MouseBack = null;
            this.txtUrl.MouseState = CCWin.SkinClass.ControlState.Normal;
            this.txtUrl.Multiline = false;
            this.txtUrl.Name = "txtUrl";
            this.txtUrl.NormlBack = null;
            this.txtUrl.Padding = new System.Windows.Forms.Padding(5);
            this.txtUrl.ReadOnly = false;
            this.txtUrl.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.txtUrl.Size = new System.Drawing.Size(462, 28);
            // 
            // 
            // 
            this.txtUrl.SkinTxt.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtUrl.SkinTxt.Dock = System.Windows.Forms.DockStyle.Fill;
            this.txtUrl.SkinTxt.Font = new System.Drawing.Font("微软雅黑", 9.75F);
            this.txtUrl.SkinTxt.Location = new System.Drawing.Point(5, 5);
            this.txtUrl.SkinTxt.Name = "BaseText";
            this.txtUrl.SkinTxt.Size = new System.Drawing.Size(452, 18);
            this.txtUrl.SkinTxt.TabIndex = 0;
            this.txtUrl.SkinTxt.WaterColor = System.Drawing.Color.FromArgb(((int)(((byte)(127)))), ((int)(((byte)(127)))), ((int)(((byte)(127)))));
            this.txtUrl.SkinTxt.WaterText = "";
            this.txtUrl.TabIndex = 2;
            this.txtUrl.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.txtUrl.WaterColor = System.Drawing.Color.FromArgb(((int)(((byte)(127)))), ((int)(((byte)(127)))), ((int)(((byte)(127)))));
            this.txtUrl.WaterText = "";
            this.txtUrl.WordWrap = true;
            // 
            // btnGo
            // 
            this.btnGo.BackColor = System.Drawing.Color.Transparent;
            this.btnGo.BaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.btnGo.BorderColor = System.Drawing.Color.Maroon;
            this.btnGo.ControlState = CCWin.SkinClass.ControlState.Normal;
            this.btnGo.DownBack = null;
            this.btnGo.DownBaseColor = System.Drawing.Color.Red;
            this.btnGo.Font = new System.Drawing.Font("微软雅黑", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.btnGo.Location = new System.Drawing.Point(466, 267);
            this.btnGo.MouseBack = null;
            this.btnGo.MouseBaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))));
            this.btnGo.Name = "btnGo";
            this.btnGo.NormlBack = null;
            this.btnGo.Size = new System.Drawing.Size(98, 27);
            this.btnGo.TabIndex = 2;
            this.btnGo.Text = "开始解析";
            this.btnGo.UseVisualStyleBackColor = false;
            this.btnGo.Click += new System.EventHandler(this.btnGo_Click);
            // 
            // skinGroupBox1
            // 
            this.skinGroupBox1.BackColor = System.Drawing.Color.Transparent;
            this.skinGroupBox1.BorderColor = System.Drawing.Color.DimGray;
            this.skinGroupBox1.Controls.Add(this.lblTitle);
            this.skinGroupBox1.Font = new System.Drawing.Font("微软雅黑", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.skinGroupBox1.ForeColor = System.Drawing.Color.Red;
            this.skinGroupBox1.Location = new System.Drawing.Point(7, 298);
            this.skinGroupBox1.Name = "skinGroupBox1";
            this.skinGroupBox1.RectBackColor = System.Drawing.Color.White;
            this.skinGroupBox1.RoundStyle = CCWin.SkinClass.RoundStyle.All;
            this.skinGroupBox1.Size = new System.Drawing.Size(393, 61);
            this.skinGroupBox1.TabIndex = 3;
            this.skinGroupBox1.TabStop = false;
            this.skinGroupBox1.Text = "视频标题";
            this.skinGroupBox1.TitleBorderColor = System.Drawing.Color.DimGray;
            this.skinGroupBox1.TitleRectBackColor = System.Drawing.Color.White;
            this.skinGroupBox1.TitleRoundStyle = CCWin.SkinClass.RoundStyle.All;
            // 
            // lblTitle
            // 
            this.lblTitle.AutoSize = true;
            this.lblTitle.ForeColor = System.Drawing.Color.Black;
            this.lblTitle.Location = new System.Drawing.Point(12, 29);
            this.lblTitle.Name = "lblTitle";
            this.lblTitle.Size = new System.Drawing.Size(43, 17);
            this.lblTitle.TabIndex = 0;
            this.lblTitle.Text = "label1";
            this.lblTitle.Visible = false;
            // 
            // skinGroupBox2
            // 
            this.skinGroupBox2.BackColor = System.Drawing.Color.Transparent;
            this.skinGroupBox2.BorderColor = System.Drawing.Color.DimGray;
            this.skinGroupBox2.Controls.Add(this.lblbqCount);
            this.skinGroupBox2.Controls.Add(this.lblbq);
            this.skinGroupBox2.Controls.Add(this.btnbqCopy);
            this.skinGroupBox2.Controls.Add(this.btnbqDown);
            this.skinGroupBox2.Font = new System.Drawing.Font("微软雅黑", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.skinGroupBox2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.skinGroupBox2.Location = new System.Drawing.Point(7, 365);
            this.skinGroupBox2.Name = "skinGroupBox2";
            this.skinGroupBox2.RectBackColor = System.Drawing.Color.White;
            this.skinGroupBox2.RoundStyle = CCWin.SkinClass.RoundStyle.All;
            this.skinGroupBox2.Size = new System.Drawing.Size(243, 61);
            this.skinGroupBox2.TabIndex = 4;
            this.skinGroupBox2.TabStop = false;
            this.skinGroupBox2.Text = "标清下载";
            this.skinGroupBox2.TitleBorderColor = System.Drawing.Color.DimGray;
            this.skinGroupBox2.TitleRectBackColor = System.Drawing.Color.White;
            this.skinGroupBox2.TitleRoundStyle = CCWin.SkinClass.RoundStyle.All;
            // 
            // lblbqCount
            // 
            this.lblbqCount.AutoSize = true;
            this.lblbqCount.Location = new System.Drawing.Point(215, 12);
            this.lblbqCount.Name = "lblbqCount";
            this.lblbqCount.Size = new System.Drawing.Size(43, 17);
            this.lblbqCount.TabIndex = 2;
            this.lblbqCount.Text = "label1";
            this.lblbqCount.Visible = false;
            // 
            // lblbq
            // 
            this.lblbq.AutoSize = true;
            this.lblbq.ForeColor = System.Drawing.Color.Black;
            this.lblbq.Location = new System.Drawing.Point(215, 29);
            this.lblbq.Name = "lblbq";
            this.lblbq.Size = new System.Drawing.Size(43, 17);
            this.lblbq.TabIndex = 1;
            this.lblbq.Text = "label1";
            this.lblbq.Visible = false;
            // 
            // btnbqCopy
            // 
            this.btnbqCopy.BackColor = System.Drawing.Color.Transparent;
            this.btnbqCopy.BaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))));
            this.btnbqCopy.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.btnbqCopy.ControlState = CCWin.SkinClass.ControlState.Normal;
            this.btnbqCopy.DownBack = null;
            this.btnbqCopy.DownBaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))));
            this.btnbqCopy.Font = new System.Drawing.Font("微软雅黑", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.btnbqCopy.ForeColor = System.Drawing.Color.DarkRed;
            this.btnbqCopy.Location = new System.Drawing.Point(35, 26);
            this.btnbqCopy.MouseBack = null;
            this.btnbqCopy.MouseBaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))));
            this.btnbqCopy.Name = "btnbqCopy";
            this.btnbqCopy.NormlBack = null;
            this.btnbqCopy.Size = new System.Drawing.Size(75, 23);
            this.btnbqCopy.TabIndex = 1;
            this.btnbqCopy.Text = "复制链接";
            this.btnbqCopy.UseVisualStyleBackColor = false;
            this.btnbqCopy.Click += new System.EventHandler(this.btnbqCopy_Click);
            // 
            // btnbqDown
            // 
            this.btnbqDown.BackColor = System.Drawing.Color.Transparent;
            this.btnbqDown.BaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))));
            this.btnbqDown.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.btnbqDown.ControlState = CCWin.SkinClass.ControlState.Normal;
            this.btnbqDown.DownBack = null;
            this.btnbqDown.DownBaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))));
            this.btnbqDown.Font = new System.Drawing.Font("微软雅黑", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.btnbqDown.ForeColor = System.Drawing.Color.DarkRed;
            this.btnbqDown.Location = new System.Drawing.Point(134, 26);
            this.btnbqDown.MouseBack = null;
            this.btnbqDown.MouseBaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))));
            this.btnbqDown.Name = "btnbqDown";
            this.btnbqDown.NormlBack = null;
            this.btnbqDown.Size = new System.Drawing.Size(75, 23);
            this.btnbqDown.TabIndex = 0;
            this.btnbqDown.Text = "直接下载";
            this.btnbqDown.UseVisualStyleBackColor = false;
            this.btnbqDown.Click += new System.EventHandler(this.btnbqDown_Click);
            // 
            // skinGroupBox3
            // 
            this.skinGroupBox3.BackColor = System.Drawing.Color.Transparent;
            this.skinGroupBox3.BorderColor = System.Drawing.Color.DimGray;
            this.skinGroupBox3.Controls.Add(this.lblgqCount);
            this.skinGroupBox3.Controls.Add(this.lblgq);
            this.skinGroupBox3.Controls.Add(this.btngqCopy);
            this.skinGroupBox3.Controls.Add(this.btngqDown);
            this.skinGroupBox3.Font = new System.Drawing.Font("微软雅黑", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.skinGroupBox3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
            this.skinGroupBox3.Location = new System.Drawing.Point(7, 432);
            this.skinGroupBox3.Name = "skinGroupBox3";
            this.skinGroupBox3.RectBackColor = System.Drawing.Color.White;
            this.skinGroupBox3.RoundStyle = CCWin.SkinClass.RoundStyle.All;
            this.skinGroupBox3.Size = new System.Drawing.Size(243, 61);
            this.skinGroupBox3.TabIndex = 5;
            this.skinGroupBox3.TabStop = false;
            this.skinGroupBox3.Text = "高清下载";
            this.skinGroupBox3.TitleBorderColor = System.Drawing.Color.DimGray;
            this.skinGroupBox3.TitleRectBackColor = System.Drawing.Color.White;
            this.skinGroupBox3.TitleRoundStyle = CCWin.SkinClass.RoundStyle.All;
            // 
            // lblgqCount
            // 
            this.lblgqCount.AutoSize = true;
            this.lblgqCount.Location = new System.Drawing.Point(215, 13);
            this.lblgqCount.Name = "lblgqCount";
            this.lblgqCount.Size = new System.Drawing.Size(43, 17);
            this.lblgqCount.TabIndex = 8;
            this.lblgqCount.Text = "label1";
            this.lblgqCount.Visible = false;
            // 
            // lblgq
            // 
            this.lblgq.AutoSize = true;
            this.lblgq.ForeColor = System.Drawing.Color.Black;
            this.lblgq.Location = new System.Drawing.Point(215, 30);
            this.lblgq.Name = "lblgq";
            this.lblgq.Size = new System.Drawing.Size(43, 17);
            this.lblgq.TabIndex = 7;
            this.lblgq.Text = "label1";
            this.lblgq.Visible = false;
            // 
            // btngqCopy
            // 
            this.btngqCopy.BackColor = System.Drawing.Color.Transparent;
            this.btngqCopy.BaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))));
            this.btngqCopy.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.btngqCopy.ControlState = CCWin.SkinClass.ControlState.Normal;
            this.btngqCopy.DownBack = null;
            this.btngqCopy.DownBaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))));
            this.btngqCopy.Font = new System.Drawing.Font("微软雅黑", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.btngqCopy.ForeColor = System.Drawing.Color.DarkRed;
            this.btngqCopy.Location = new System.Drawing.Point(35, 27);
            this.btngqCopy.MouseBack = null;
            this.btngqCopy.MouseBaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))));
            this.btngqCopy.Name = "btngqCopy";
            this.btngqCopy.NormlBack = null;
            this.btngqCopy.Size = new System.Drawing.Size(75, 23);
            this.btngqCopy.TabIndex = 8;
            this.btngqCopy.Text = "复制链接";
            this.btngqCopy.UseVisualStyleBackColor = false;
            this.btngqCopy.Click += new System.EventHandler(this.btngqCopy_Click);
            // 
            // btngqDown
            // 
            this.btngqDown.BackColor = System.Drawing.Color.Transparent;
            this.btngqDown.BaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))));
            this.btngqDown.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.btngqDown.ControlState = CCWin.SkinClass.ControlState.Normal;
            this.btngqDown.DownBack = null;
            this.btngqDown.DownBaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))));
            this.btngqDown.Font = new System.Drawing.Font("微软雅黑", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.btngqDown.ForeColor = System.Drawing.Color.DarkRed;
            this.btngqDown.Location = new System.Drawing.Point(134, 27);
            this.btngqDown.MouseBack = null;
            this.btngqDown.MouseBaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))));
            this.btngqDown.Name = "btngqDown";
            this.btngqDown.NormlBack = null;
            this.btngqDown.Size = new System.Drawing.Size(75, 23);
            this.btngqDown.TabIndex = 7;
            this.btngqDown.Text = "直接下载";
            this.btngqDown.UseVisualStyleBackColor = false;
            this.btngqDown.Click += new System.EventHandler(this.btngqDown_Click);
            // 
            // skinGroupBox4
            // 
            this.skinGroupBox4.BackColor = System.Drawing.Color.Transparent;
            this.skinGroupBox4.BorderColor = System.Drawing.Color.DimGray;
            this.skinGroupBox4.Controls.Add(this.lblcqCount);
            this.skinGroupBox4.Controls.Add(this.lblcq);
            this.skinGroupBox4.Controls.Add(this.btncqCopy);
            this.skinGroupBox4.Controls.Add(this.btncqDown);
            this.skinGroupBox4.Font = new System.Drawing.Font("微软雅黑", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.skinGroupBox4.ForeColor = System.Drawing.Color.Fuchsia;
            this.skinGroupBox4.Location = new System.Drawing.Point(7, 499);
            this.skinGroupBox4.Name = "skinGroupBox4";
            this.skinGroupBox4.RectBackColor = System.Drawing.Color.White;
            this.skinGroupBox4.RoundStyle = CCWin.SkinClass.RoundStyle.All;
            this.skinGroupBox4.Size = new System.Drawing.Size(243, 61);
            this.skinGroupBox4.TabIndex = 4;
            this.skinGroupBox4.TabStop = false;
            this.skinGroupBox4.Text = "超清下载";
            this.skinGroupBox4.TitleBorderColor = System.Drawing.Color.DimGray;
            this.skinGroupBox4.TitleRectBackColor = System.Drawing.Color.White;
            this.skinGroupBox4.TitleRoundStyle = CCWin.SkinClass.RoundStyle.All;
            // 
            // lblcqCount
            // 
            this.lblcqCount.AutoSize = true;
            this.lblcqCount.Location = new System.Drawing.Point(216, 13);
            this.lblcqCount.Name = "lblcqCount";
            this.lblcqCount.Size = new System.Drawing.Size(43, 17);
            this.lblcqCount.TabIndex = 8;
            this.lblcqCount.Text = "label1";
            this.lblcqCount.Visible = false;
            // 
            // lblcq
            // 
            this.lblcq.AutoSize = true;
            this.lblcq.ForeColor = System.Drawing.Color.Black;
            this.lblcq.Location = new System.Drawing.Point(215, 31);
            this.lblcq.Name = "lblcq";
            this.lblcq.Size = new System.Drawing.Size(43, 17);
            this.lblcq.TabIndex = 7;
            this.lblcq.Text = "label1";
            this.lblcq.Visible = false;
            // 
            // btncqCopy
            // 
            this.btncqCopy.BackColor = System.Drawing.Color.Transparent;
            this.btncqCopy.BaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))));
            this.btncqCopy.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.btncqCopy.ControlState = CCWin.SkinClass.ControlState.Normal;
            this.btncqCopy.DownBack = null;
            this.btncqCopy.DownBaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))));
            this.btncqCopy.Font = new System.Drawing.Font("微软雅黑", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.btncqCopy.ForeColor = System.Drawing.Color.DarkRed;
            this.btncqCopy.Location = new System.Drawing.Point(35, 28);
            this.btncqCopy.MouseBack = null;
            this.btncqCopy.MouseBaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))));
            this.btncqCopy.Name = "btncqCopy";
            this.btncqCopy.NormlBack = null;
            this.btncqCopy.Size = new System.Drawing.Size(75, 23);
            this.btncqCopy.TabIndex = 8;
            this.btncqCopy.Text = "复制链接";
            this.btncqCopy.UseVisualStyleBackColor = false;
            this.btncqCopy.Click += new System.EventHandler(this.btncqCopy_Click);
            // 
            // btncqDown
            // 
            this.btncqDown.BackColor = System.Drawing.Color.Transparent;
            this.btncqDown.BaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))));
            this.btncqDown.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.btncqDown.ControlState = CCWin.SkinClass.ControlState.Normal;
            this.btncqDown.DownBack = null;
            this.btncqDown.DownBaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))));
            this.btncqDown.Font = new System.Drawing.Font("微软雅黑", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.btncqDown.ForeColor = System.Drawing.Color.DarkRed;
            this.btncqDown.Location = new System.Drawing.Point(134, 28);
            this.btncqDown.MouseBack = null;
            this.btncqDown.MouseBaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))));
            this.btncqDown.Name = "btncqDown";
            this.btncqDown.NormlBack = null;
            this.btncqDown.Size = new System.Drawing.Size(75, 23);
            this.btncqDown.TabIndex = 7;
            this.btncqDown.Text = "直接下载";
            this.btncqDown.UseVisualStyleBackColor = false;
            this.btncqDown.Click += new System.EventHandler(this.btncqDown_Click);
            // 
            // txtStatus
            // 
            this.txtStatus.BackColor = System.Drawing.Color.Gainsboro;
            this.txtStatus.Font = new System.Drawing.Font("微软雅黑", 10.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.txtStatus.Location = new System.Drawing.Point(256, 365);
            this.txtStatus.Multiline = true;
            this.txtStatus.Name = "txtStatus";
            this.txtStatus.ReadOnly = true;
            this.txtStatus.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.txtStatus.Size = new System.Drawing.Size(305, 195);
            this.txtStatus.TabIndex = 6;
            // 
            // skinGroupBox5
            // 
            this.skinGroupBox5.BackColor = System.Drawing.Color.Transparent;
            this.skinGroupBox5.BorderColor = System.Drawing.Color.DimGray;
            this.skinGroupBox5.Controls.Add(this.lblUser);
            this.skinGroupBox5.Font = new System.Drawing.Font("微软雅黑", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.skinGroupBox5.ForeColor = System.Drawing.Color.Red;
            this.skinGroupBox5.Location = new System.Drawing.Point(406, 298);
            this.skinGroupBox5.Name = "skinGroupBox5";
            this.skinGroupBox5.RectBackColor = System.Drawing.Color.White;
            this.skinGroupBox5.RoundStyle = CCWin.SkinClass.RoundStyle.All;
            this.skinGroupBox5.Size = new System.Drawing.Size(155, 61);
            this.skinGroupBox5.TabIndex = 7;
            this.skinGroupBox5.TabStop = false;
            this.skinGroupBox5.Text = "UP主";
            this.skinGroupBox5.TitleBorderColor = System.Drawing.Color.DimGray;
            this.skinGroupBox5.TitleRectBackColor = System.Drawing.Color.White;
            this.skinGroupBox5.TitleRoundStyle = CCWin.SkinClass.RoundStyle.All;
            // 
            // lblUser
            // 
            this.lblUser.AutoSize = true;
            this.lblUser.ForeColor = System.Drawing.Color.Black;
            this.lblUser.Location = new System.Drawing.Point(19, 29);
            this.lblUser.Name = "lblUser";
            this.lblUser.Size = new System.Drawing.Size(43, 17);
            this.lblUser.TabIndex = 0;
            this.lblUser.Text = "label1";
            this.lblUser.Visible = false;
            // 
            // nIcon
            // 
            this.nIcon.ContextMenuStrip = this.ctmsIcon;
            this.nIcon.Icon = ((System.Drawing.Icon)(resources.GetObject("nIcon.Icon")));
            this.nIcon.Text = "bilibili解析器";
            this.nIcon.Visible = true;
            this.nIcon.MouseDoubleClick += new System.Windows.Forms.MouseEventHandler(this.nIcon_MouseDoubleClick);
            // 
            // ctmsIcon
            // 
            this.ctmsIcon.Arrow = System.Drawing.Color.Black;
            this.ctmsIcon.Back = System.Drawing.Color.White;
            this.ctmsIcon.BackRadius = 4;
            this.ctmsIcon.Base = System.Drawing.Color.FromArgb(((int)(((byte)(105)))), ((int)(((byte)(200)))), ((int)(((byte)(254)))));
            this.ctmsIcon.DropDownImageSeparator = System.Drawing.Color.FromArgb(((int)(((byte)(197)))), ((int)(((byte)(197)))), ((int)(((byte)(197)))));
            this.ctmsIcon.Fore = System.Drawing.Color.Black;
            this.ctmsIcon.HoverFore = System.Drawing.Color.White;
            this.ctmsIcon.ItemAnamorphosis = true;
            this.ctmsIcon.ItemBorder = System.Drawing.Color.FromArgb(((int)(((byte)(60)))), ((int)(((byte)(148)))), ((int)(((byte)(212)))));
            this.ctmsIcon.ItemBorderShow = true;
            this.ctmsIcon.ItemHover = System.Drawing.Color.FromArgb(((int)(((byte)(60)))), ((int)(((byte)(148)))), ((int)(((byte)(212)))));
            this.ctmsIcon.ItemPressed = System.Drawing.Color.FromArgb(((int)(((byte)(60)))), ((int)(((byte)(148)))), ((int)(((byte)(212)))));
            this.ctmsIcon.ItemRadius = 4;
            this.ctmsIcon.ItemRadiusStyle = CCWin.SkinClass.RoundStyle.All;
            this.ctmsIcon.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.显示主窗体ToolStripMenuItem,
            this.退出ToolStripMenuItem});
            this.ctmsIcon.ItemSplitter = System.Drawing.Color.FromArgb(((int)(((byte)(60)))), ((int)(((byte)(148)))), ((int)(((byte)(212)))));
            this.ctmsIcon.Name = "skinContextMenuStrip1";
            this.ctmsIcon.RadiusStyle = CCWin.SkinClass.RoundStyle.All;
            this.ctmsIcon.Size = new System.Drawing.Size(137, 48);
            this.ctmsIcon.SkinAllColor = true;
            this.ctmsIcon.TitleAnamorphosis = true;
            this.ctmsIcon.TitleColor = System.Drawing.Color.FromArgb(((int)(((byte)(209)))), ((int)(((byte)(228)))), ((int)(((byte)(236)))));
            this.ctmsIcon.TitleRadius = 4;
            this.ctmsIcon.TitleRadiusStyle = CCWin.SkinClass.RoundStyle.All;
            // 
            // 显示主窗体ToolStripMenuItem
            // 
            this.显示主窗体ToolStripMenuItem.Name = "显示主窗体ToolStripMenuItem";
            this.显示主窗体ToolStripMenuItem.Size = new System.Drawing.Size(152, 22);
            this.显示主窗体ToolStripMenuItem.Text = "显示主窗体";
            this.显示主窗体ToolStripMenuItem.Click += new System.EventHandler(this.显示主窗体ToolStripMenuItem_Click);
            // 
            // 退出ToolStripMenuItem
            // 
            this.退出ToolStripMenuItem.Name = "退出ToolStripMenuItem";
            this.退出ToolStripMenuItem.Size = new System.Drawing.Size(152, 22);
            this.退出ToolStripMenuItem.Text = "退出";
            this.退出ToolStripMenuItem.Click += new System.EventHandler(this.退出ToolStripMenuItem_Click);
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(568, 569);
            this.Controls.Add(this.skinGroupBox5);
            this.Controls.Add(this.txtStatus);
            this.Controls.Add(this.skinGroupBox4);
            this.Controls.Add(this.skinGroupBox3);
            this.Controls.Add(this.skinGroupBox2);
            this.Controls.Add(this.skinGroupBox1);
            this.Controls.Add(this.btnGo);
            this.Controls.Add(this.txtUrl);
            this.Controls.Add(this.pbLogo);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "MainForm";
            this.Text = "bilibili解析器";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.MainForm_FormClosing);
            this.Load += new System.EventHandler(this.MainForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pbLogo)).EndInit();
            this.skinGroupBox1.ResumeLayout(false);
            this.skinGroupBox1.PerformLayout();
            this.skinGroupBox2.ResumeLayout(false);
            this.skinGroupBox2.PerformLayout();
            this.skinGroupBox3.ResumeLayout(false);
            this.skinGroupBox3.PerformLayout();
            this.skinGroupBox4.ResumeLayout(false);
            this.skinGroupBox4.PerformLayout();
            this.skinGroupBox5.ResumeLayout(false);
            this.skinGroupBox5.PerformLayout();
            this.ctmsIcon.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private CCWin.SkinControl.SkinPictureBox pbLogo;
        private CCWin.SkinControl.SkinTextBox txtUrl;
        private CCWin.SkinControl.SkinButton btnGo;
        private CCWin.SkinControl.SkinGroupBox skinGroupBox1;
        private CCWin.SkinControl.SkinGroupBox skinGroupBox2;
        private CCWin.SkinControl.SkinGroupBox skinGroupBox3;
        private CCWin.SkinControl.SkinGroupBox skinGroupBox4;
        private System.Windows.Forms.TextBox txtStatus;
        private CCWin.SkinControl.SkinButton btnbqDown;
        private CCWin.SkinControl.SkinButton btnbqCopy;
        private CCWin.SkinControl.SkinButton btngqCopy;
        private CCWin.SkinControl.SkinButton btngqDown;
        private CCWin.SkinControl.SkinButton btncqCopy;
        private CCWin.SkinControl.SkinButton btncqDown;
        private System.Windows.Forms.Label lblTitle;
        private System.Windows.Forms.Label lblbq;
        private System.Windows.Forms.Label lblgq;
        private System.Windows.Forms.Label lblcq;
        private CCWin.SkinControl.SkinGroupBox skinGroupBox5;
        private System.Windows.Forms.Label lblUser;
        private System.Windows.Forms.Label lblbqCount;
        private System.Windows.Forms.Label lblgqCount;
        private System.Windows.Forms.Label lblcqCount;
        private System.Windows.Forms.NotifyIcon nIcon;
        private CCWin.SkinControl.SkinContextMenuStrip ctmsIcon;
        private System.Windows.Forms.ToolStripMenuItem 显示主窗体ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 退出ToolStripMenuItem;
    }
}