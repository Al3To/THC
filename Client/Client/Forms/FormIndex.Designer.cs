namespace Client
{
    partial class Client
    {
        /// <summary>
        /// Variabile di progettazione necessaria.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Pulire le risorse in uso.
        /// </summary>
        /// <param name="disposing">ha valore true se le risorse gestite devono essere eliminate, false in caso contrario.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Codice generato da Progettazione Windows Form

        /// <summary>
        /// Metodo necessario per il supporto della finestra di progettazione. Non modificare
        /// il contenuto del metodo con l'editor di codice.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Client));
            this.panelDesktop = new System.Windows.Forms.Panel();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.labelDate = new System.Windows.Forms.Label();
            this.labelTime = new System.Windows.Forms.Label();
            this.panelTitle = new System.Windows.Forms.Panel();
            this.buttonRegister = new System.Windows.Forms.Button();
            this.pictureMinimize = new System.Windows.Forms.PictureBox();
            this.pictureMaximize = new System.Windows.Forms.PictureBox();
            this.pictureClose = new System.Windows.Forms.PictureBox();
            this.buttonLogin = new System.Windows.Forms.Button();
            this.panelSideBar = new System.Windows.Forms.Panel();
            this.buttonBJ = new FontAwesome.Sharp.IconButton();
            this.buttonHome = new FontAwesome.Sharp.IconButton();
            this.panelProfile = new System.Windows.Forms.Panel();
            this.labelBalance = new System.Windows.Forms.Label();
            this.labelUsername = new System.Windows.Forms.Label();
            this.buttonLoginProfile = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.buttonRecharge = new System.Windows.Forms.Button();
            this.panelDesktop.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            this.panelTitle.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureMinimize)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureMaximize)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureClose)).BeginInit();
            this.panelSideBar.SuspendLayout();
            this.panelProfile.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // panelDesktop
            // 
            this.panelDesktop.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(37)))), ((int)(((byte)(37)))), ((int)(((byte)(37)))));
            this.panelDesktop.Controls.Add(this.pictureBox2);
            this.panelDesktop.Controls.Add(this.labelDate);
            this.panelDesktop.Controls.Add(this.labelTime);
            this.panelDesktop.Cursor = System.Windows.Forms.Cursors.Default;
            this.panelDesktop.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelDesktop.Location = new System.Drawing.Point(150, 81);
            this.panelDesktop.Margin = new System.Windows.Forms.Padding(2);
            this.panelDesktop.Name = "panelDesktop";
            this.panelDesktop.Size = new System.Drawing.Size(650, 369);
            this.panelDesktop.TabIndex = 5;
            // 
            // pictureBox2
            // 
            this.pictureBox2.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.pictureBox2.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox2.Image")));
            this.pictureBox2.Location = new System.Drawing.Point(194, 64);
            this.pictureBox2.Margin = new System.Windows.Forms.Padding(2);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(233, 136);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox2.TabIndex = 6;
            this.pictureBox2.TabStop = false;
            // 
            // labelDate
            // 
            this.labelDate.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.labelDate.AutoSize = true;
            this.labelDate.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelDate.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(127)))), ((int)(((byte)(248)))), ((int)(((byte)(3)))));
            this.labelDate.Location = new System.Drawing.Point(197, 253);
            this.labelDate.Name = "labelDate";
            this.labelDate.Size = new System.Drawing.Size(233, 24);
            this.labelDate.TabIndex = 5;
            this.labelDate.Text = "venerdì,12 dicembre, 2021";
            // 
            // labelTime
            // 
            this.labelTime.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.labelTime.AutoSize = true;
            this.labelTime.Font = new System.Drawing.Font("Microsoft Sans Serif", 27.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelTime.ForeColor = System.Drawing.Color.Gainsboro;
            this.labelTime.Location = new System.Drawing.Point(230, 212);
            this.labelTime.Name = "labelTime";
            this.labelTime.Size = new System.Drawing.Size(164, 42);
            this.labelTime.TabIndex = 4;
            this.labelTime.Text = "00:00:00";
            // 
            // panelTitle
            // 
            this.panelTitle.BackColor = System.Drawing.Color.Black;
            this.panelTitle.Controls.Add(this.buttonRegister);
            this.panelTitle.Controls.Add(this.pictureMinimize);
            this.panelTitle.Controls.Add(this.pictureMaximize);
            this.panelTitle.Controls.Add(this.pictureClose);
            this.panelTitle.Controls.Add(this.buttonLogin);
            this.panelTitle.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelTitle.Location = new System.Drawing.Point(150, 0);
            this.panelTitle.Margin = new System.Windows.Forms.Padding(2);
            this.panelTitle.Name = "panelTitle";
            this.panelTitle.Size = new System.Drawing.Size(650, 81);
            this.panelTitle.TabIndex = 4;
            this.panelTitle.MouseDown += new System.Windows.Forms.MouseEventHandler(this.panelTitle_MouseDown);
            // 
            // buttonRegister
            // 
            this.buttonRegister.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.buttonRegister.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(252)))), ((int)(((byte)(228)))), ((int)(((byte)(3)))));
            this.buttonRegister.Cursor = System.Windows.Forms.Cursors.Hand;
            this.buttonRegister.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonRegister.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonRegister.ForeColor = System.Drawing.Color.Black;
            this.buttonRegister.Location = new System.Drawing.Point(484, 31);
            this.buttonRegister.Margin = new System.Windows.Forms.Padding(2);
            this.buttonRegister.Name = "buttonRegister";
            this.buttonRegister.Size = new System.Drawing.Size(104, 29);
            this.buttonRegister.TabIndex = 7;
            this.buttonRegister.Text = "REGISTRATI";
            this.buttonRegister.UseVisualStyleBackColor = false;
            this.buttonRegister.Click += new System.EventHandler(this.buttonRegister_Click);
            this.buttonRegister.MouseEnter += new System.EventHandler(this.buttonRegister_MouseEnter);
            this.buttonRegister.MouseLeave += new System.EventHandler(this.buttonRegister_MouseLeave);
            // 
            // pictureMinimize
            // 
            this.pictureMinimize.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.pictureMinimize.Cursor = System.Windows.Forms.Cursors.Hand;
            this.pictureMinimize.Image = ((System.Drawing.Image)(resources.GetObject("pictureMinimize.Image")));
            this.pictureMinimize.Location = new System.Drawing.Point(599, 2);
            this.pictureMinimize.Margin = new System.Windows.Forms.Padding(2);
            this.pictureMinimize.Name = "pictureMinimize";
            this.pictureMinimize.Size = new System.Drawing.Size(16, 15);
            this.pictureMinimize.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureMinimize.TabIndex = 6;
            this.pictureMinimize.TabStop = false;
            this.pictureMinimize.Click += new System.EventHandler(this.pictureMinimize_Click);
            // 
            // pictureMaximize
            // 
            this.pictureMaximize.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.pictureMaximize.Cursor = System.Windows.Forms.Cursors.Hand;
            this.pictureMaximize.Image = ((System.Drawing.Image)(resources.GetObject("pictureMaximize.Image")));
            this.pictureMaximize.Location = new System.Drawing.Point(615, 2);
            this.pictureMaximize.Margin = new System.Windows.Forms.Padding(2);
            this.pictureMaximize.Name = "pictureMaximize";
            this.pictureMaximize.Size = new System.Drawing.Size(16, 15);
            this.pictureMaximize.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureMaximize.TabIndex = 5;
            this.pictureMaximize.TabStop = false;
            this.pictureMaximize.Click += new System.EventHandler(this.pictureMaximize_Click);
            // 
            // pictureClose
            // 
            this.pictureClose.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.pictureClose.Cursor = System.Windows.Forms.Cursors.Hand;
            this.pictureClose.Image = ((System.Drawing.Image)(resources.GetObject("pictureClose.Image")));
            this.pictureClose.Location = new System.Drawing.Point(631, 2);
            this.pictureClose.Margin = new System.Windows.Forms.Padding(2);
            this.pictureClose.Name = "pictureClose";
            this.pictureClose.Size = new System.Drawing.Size(16, 15);
            this.pictureClose.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureClose.TabIndex = 4;
            this.pictureClose.TabStop = false;
            this.pictureClose.Click += new System.EventHandler(this.pictureClose_Click);
            // 
            // buttonLogin
            // 
            this.buttonLogin.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.buttonLogin.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(23)))), ((int)(((byte)(23)))), ((int)(((byte)(23)))));
            this.buttonLogin.Cursor = System.Windows.Forms.Cursors.Hand;
            this.buttonLogin.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonLogin.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonLogin.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(127)))), ((int)(((byte)(248)))), ((int)(((byte)(3)))));
            this.buttonLogin.Location = new System.Drawing.Point(592, 31);
            this.buttonLogin.Margin = new System.Windows.Forms.Padding(2);
            this.buttonLogin.Name = "buttonLogin";
            this.buttonLogin.Size = new System.Drawing.Size(58, 29);
            this.buttonLogin.TabIndex = 2;
            this.buttonLogin.Text = "LOGIN";
            this.buttonLogin.UseVisualStyleBackColor = false;
            this.buttonLogin.Click += new System.EventHandler(this.buttonLogin_Click);
            this.buttonLogin.MouseEnter += new System.EventHandler(this.buttonLogin_MouseEnter);
            this.buttonLogin.MouseLeave += new System.EventHandler(this.buttonLogin_MouseLeave);
            // 
            // panelSideBar
            // 
            this.panelSideBar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(23)))), ((int)(((byte)(23)))), ((int)(((byte)(23)))));
            this.panelSideBar.Controls.Add(this.buttonBJ);
            this.panelSideBar.Controls.Add(this.buttonHome);
            this.panelSideBar.Controls.Add(this.panelProfile);
            this.panelSideBar.Dock = System.Windows.Forms.DockStyle.Left;
            this.panelSideBar.Location = new System.Drawing.Point(0, 0);
            this.panelSideBar.Margin = new System.Windows.Forms.Padding(2);
            this.panelSideBar.Name = "panelSideBar";
            this.panelSideBar.Size = new System.Drawing.Size(150, 450);
            this.panelSideBar.TabIndex = 3;
            // 
            // buttonBJ
            // 
            this.buttonBJ.Cursor = System.Windows.Forms.Cursors.Hand;
            this.buttonBJ.Dock = System.Windows.Forms.DockStyle.Top;
            this.buttonBJ.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonBJ.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonBJ.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(140)))), ((int)(((byte)(140)))), ((int)(((byte)(140)))));
            this.buttonBJ.IconChar = FontAwesome.Sharp.IconChar.SackDollar;
            this.buttonBJ.IconColor = System.Drawing.Color.FromArgb(((int)(((byte)(252)))), ((int)(((byte)(228)))), ((int)(((byte)(100)))));
            this.buttonBJ.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.buttonBJ.IconSize = 26;
            this.buttonBJ.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.buttonBJ.Location = new System.Drawing.Point(0, 170);
            this.buttonBJ.Margin = new System.Windows.Forms.Padding(2);
            this.buttonBJ.Name = "buttonBJ";
            this.buttonBJ.Size = new System.Drawing.Size(150, 36);
            this.buttonBJ.TabIndex = 3;
            this.buttonBJ.Text = "BlackJack";
            this.buttonBJ.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.buttonBJ.UseVisualStyleBackColor = true;
            this.buttonBJ.Click += new System.EventHandler(this.buttonBJ_Click);
            // 
            // buttonHome
            // 
            this.buttonHome.Cursor = System.Windows.Forms.Cursors.Hand;
            this.buttonHome.Dock = System.Windows.Forms.DockStyle.Top;
            this.buttonHome.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonHome.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonHome.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(140)))), ((int)(((byte)(140)))), ((int)(((byte)(140)))));
            this.buttonHome.IconChar = FontAwesome.Sharp.IconChar.Home;
            this.buttonHome.IconColor = System.Drawing.Color.FromArgb(((int)(((byte)(252)))), ((int)(((byte)(228)))), ((int)(((byte)(100)))));
            this.buttonHome.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.buttonHome.IconSize = 26;
            this.buttonHome.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.buttonHome.Location = new System.Drawing.Point(0, 134);
            this.buttonHome.Margin = new System.Windows.Forms.Padding(2);
            this.buttonHome.Name = "buttonHome";
            this.buttonHome.Size = new System.Drawing.Size(150, 36);
            this.buttonHome.TabIndex = 4;
            this.buttonHome.Text = "Home";
            this.buttonHome.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.buttonHome.UseVisualStyleBackColor = true;
            this.buttonHome.Click += new System.EventHandler(this.buttonHome_Click);
            // 
            // panelProfile
            // 
            this.panelProfile.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(23)))), ((int)(((byte)(23)))), ((int)(((byte)(23)))));
            this.panelProfile.Controls.Add(this.buttonRecharge);
            this.panelProfile.Controls.Add(this.labelBalance);
            this.panelProfile.Controls.Add(this.labelUsername);
            this.panelProfile.Controls.Add(this.buttonLoginProfile);
            this.panelProfile.Controls.Add(this.pictureBox1);
            this.panelProfile.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelProfile.Location = new System.Drawing.Point(0, 0);
            this.panelProfile.Margin = new System.Windows.Forms.Padding(2);
            this.panelProfile.Name = "panelProfile";
            this.panelProfile.Size = new System.Drawing.Size(150, 134);
            this.panelProfile.TabIndex = 0;
            // 
            // labelBalance
            // 
            this.labelBalance.AutoSize = true;
            this.labelBalance.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelBalance.ForeColor = System.Drawing.Color.Gainsboro;
            this.labelBalance.Location = new System.Drawing.Point(41, 76);
            this.labelBalance.Name = "labelBalance";
            this.labelBalance.Size = new System.Drawing.Size(49, 15);
            this.labelBalance.TabIndex = 5;
            this.labelBalance.Text = "Credito:";
            this.labelBalance.Visible = false;
            // 
            // labelUsername
            // 
            this.labelUsername.AutoSize = true;
            this.labelUsername.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelUsername.ForeColor = System.Drawing.Color.Gainsboro;
            this.labelUsername.Location = new System.Drawing.Point(41, 55);
            this.labelUsername.Name = "labelUsername";
            this.labelUsername.Size = new System.Drawing.Size(63, 15);
            this.labelUsername.TabIndex = 4;
            this.labelUsername.Text = "username";
            this.labelUsername.Visible = false;
            // 
            // buttonLoginProfile
            // 
            this.buttonLoginProfile.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(23)))), ((int)(((byte)(23)))), ((int)(((byte)(23)))));
            this.buttonLoginProfile.Cursor = System.Windows.Forms.Cursors.Hand;
            this.buttonLoginProfile.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonLoginProfile.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonLoginProfile.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(127)))), ((int)(((byte)(248)))), ((int)(((byte)(3)))));
            this.buttonLoginProfile.Location = new System.Drawing.Point(34, 80);
            this.buttonLoginProfile.Margin = new System.Windows.Forms.Padding(2);
            this.buttonLoginProfile.Name = "buttonLoginProfile";
            this.buttonLoginProfile.Size = new System.Drawing.Size(75, 26);
            this.buttonLoginProfile.TabIndex = 3;
            this.buttonLoginProfile.Text = "LOGIN";
            this.buttonLoginProfile.UseVisualStyleBackColor = false;
            this.buttonLoginProfile.Click += new System.EventHandler(this.buttonLoginProfile_Click);
            this.buttonLoginProfile.MouseEnter += new System.EventHandler(this.buttonLoginProfile_MouseEnter);
            this.buttonLoginProfile.MouseLeave += new System.EventHandler(this.buttonLoginProfile_MouseLeave);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(34, 10);
            this.pictureBox1.Margin = new System.Windows.Forms.Padding(2);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(75, 41);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // timer1
            // 
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // buttonRecharge
            // 
            this.buttonRecharge.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(30)))));
            this.buttonRecharge.Cursor = System.Windows.Forms.Cursors.Hand;
            this.buttonRecharge.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonRecharge.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonRecharge.ForeColor = System.Drawing.Color.Black;
            this.buttonRecharge.Location = new System.Drawing.Point(24, 97);
            this.buttonRecharge.Margin = new System.Windows.Forms.Padding(2);
            this.buttonRecharge.Name = "buttonRecharge";
            this.buttonRecharge.Size = new System.Drawing.Size(96, 29);
            this.buttonRecharge.TabIndex = 8;
            this.buttonRecharge.Text = "RICARICA";
            this.buttonRecharge.UseVisualStyleBackColor = false;
            this.buttonRecharge.Visible = false;
            this.buttonRecharge.Click += new System.EventHandler(this.buttonRecharge_Click);
            // 
            // Client
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.panelDesktop);
            this.Controls.Add(this.panelTitle);
            this.Controls.Add(this.panelSideBar);
            this.Name = "Client";
            this.Text = "THC";
            this.Resize += new System.EventHandler(this.Client_Resize);
            this.panelDesktop.ResumeLayout(false);
            this.panelDesktop.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            this.panelTitle.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureMinimize)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureMaximize)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureClose)).EndInit();
            this.panelSideBar.ResumeLayout(false);
            this.panelProfile.ResumeLayout(false);
            this.panelProfile.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panelDesktop;
        private System.Windows.Forms.Panel panelTitle;
        private System.Windows.Forms.PictureBox pictureMinimize;
        private System.Windows.Forms.PictureBox pictureMaximize;
        private System.Windows.Forms.PictureBox pictureClose;
        private System.Windows.Forms.Button buttonLogin;
        private System.Windows.Forms.Panel panelSideBar;
        private System.Windows.Forms.Panel panelProfile;
        private System.Windows.Forms.Button buttonLoginProfile;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Button buttonRegister;
        private FontAwesome.Sharp.IconButton buttonBJ;
        private FontAwesome.Sharp.IconButton buttonHome;
        private System.Windows.Forms.Label labelUsername;
        private System.Windows.Forms.Label labelBalance;
        private System.Windows.Forms.Label labelDate;
        private System.Windows.Forms.Label labelTime;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.Button buttonRecharge;
    }
}

