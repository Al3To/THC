namespace Client
{
    partial class FormIndex
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormIndex));
            this.panelSideBar = new System.Windows.Forms.Panel();
            this.buttonBJ = new System.Windows.Forms.Button();
            this.panelProfile = new System.Windows.Forms.Panel();
            this.buttonLoginProfile = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.panelTitle = new System.Windows.Forms.Panel();
            this.pictureMinimize = new System.Windows.Forms.PictureBox();
            this.pictureMaximize = new System.Windows.Forms.PictureBox();
            this.pictureClose = new System.Windows.Forms.PictureBox();
            this.buttonLogin = new System.Windows.Forms.Button();
            this.panelDesktop = new System.Windows.Forms.Panel();
            this.panelSideBar.SuspendLayout();
            this.panelProfile.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.panelTitle.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureMinimize)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureMaximize)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureClose)).BeginInit();
            this.SuspendLayout();
            // 
            // panelSideBar
            // 
            this.panelSideBar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(23)))), ((int)(((byte)(23)))), ((int)(((byte)(23)))));
            this.panelSideBar.Controls.Add(this.buttonBJ);
            this.panelSideBar.Controls.Add(this.panelProfile);
            this.panelSideBar.Dock = System.Windows.Forms.DockStyle.Left;
            this.panelSideBar.Location = new System.Drawing.Point(0, 0);
            this.panelSideBar.Name = "panelSideBar";
            this.panelSideBar.Size = new System.Drawing.Size(200, 450);
            this.panelSideBar.TabIndex = 0;
            // 
            // buttonBJ
            // 
            this.buttonBJ.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(33)))), ((int)(((byte)(33)))));
            this.buttonBJ.Cursor = System.Windows.Forms.Cursors.Hand;
            this.buttonBJ.Dock = System.Windows.Forms.DockStyle.Top;
            this.buttonBJ.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonBJ.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonBJ.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(127)))), ((int)(((byte)(248)))), ((int)(((byte)(3)))));
            this.buttonBJ.Location = new System.Drawing.Point(0, 126);
            this.buttonBJ.Name = "buttonBJ";
            this.buttonBJ.Size = new System.Drawing.Size(200, 35);
            this.buttonBJ.TabIndex = 1;
            this.buttonBJ.Text = "BlackJack";
            this.buttonBJ.UseVisualStyleBackColor = false;
            // 
            // panelProfile
            // 
            this.panelProfile.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(23)))), ((int)(((byte)(23)))), ((int)(((byte)(23)))));
            this.panelProfile.Controls.Add(this.buttonLoginProfile);
            this.panelProfile.Controls.Add(this.pictureBox1);
            this.panelProfile.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelProfile.Location = new System.Drawing.Point(0, 0);
            this.panelProfile.Name = "panelProfile";
            this.panelProfile.Size = new System.Drawing.Size(200, 126);
            this.panelProfile.TabIndex = 0;
            // 
            // buttonLoginProfile
            // 
            this.buttonLoginProfile.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(23)))), ((int)(((byte)(23)))), ((int)(((byte)(23)))));
            this.buttonLoginProfile.Cursor = System.Windows.Forms.Cursors.Hand;
            this.buttonLoginProfile.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonLoginProfile.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonLoginProfile.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(127)))), ((int)(((byte)(248)))), ((int)(((byte)(3)))));
            this.buttonLoginProfile.Location = new System.Drawing.Point(61, 68);
            this.buttonLoginProfile.Name = "buttonLoginProfile";
            this.buttonLoginProfile.Size = new System.Drawing.Size(76, 32);
            this.buttonLoginProfile.TabIndex = 3;
            this.buttonLoginProfile.Text = "Login";
            this.buttonLoginProfile.UseVisualStyleBackColor = false;
            this.buttonLoginProfile.MouseEnter += new System.EventHandler(this.buttonLoginProfile_MouseEnter);
            this.buttonLoginProfile.MouseLeave += new System.EventHandler(this.buttonLoginProfile_MouseLeave);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(46, 12);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(100, 50);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // panelTitle
            // 
            this.panelTitle.BackColor = System.Drawing.Color.Black;
            this.panelTitle.Controls.Add(this.pictureMinimize);
            this.panelTitle.Controls.Add(this.pictureMaximize);
            this.panelTitle.Controls.Add(this.pictureClose);
            this.panelTitle.Controls.Add(this.buttonLogin);
            this.panelTitle.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelTitle.Location = new System.Drawing.Point(200, 0);
            this.panelTitle.Name = "panelTitle";
            this.panelTitle.Size = new System.Drawing.Size(600, 100);
            this.panelTitle.TabIndex = 1;
            // 
            // pictureMinimize
            // 
            this.pictureMinimize.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.pictureMinimize.Cursor = System.Windows.Forms.Cursors.Hand;
            this.pictureMinimize.Image = ((System.Drawing.Image)(resources.GetObject("pictureMinimize.Image")));
            this.pictureMinimize.Location = new System.Drawing.Point(532, 3);
            this.pictureMinimize.Name = "pictureMinimize";
            this.pictureMinimize.Size = new System.Drawing.Size(22, 18);
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
            this.pictureMaximize.Location = new System.Drawing.Point(553, 3);
            this.pictureMaximize.Name = "pictureMaximize";
            this.pictureMaximize.Size = new System.Drawing.Size(22, 18);
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
            this.pictureClose.Location = new System.Drawing.Point(575, 3);
            this.pictureClose.Name = "pictureClose";
            this.pictureClose.Size = new System.Drawing.Size(22, 18);
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
            this.buttonLogin.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonLogin.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(127)))), ((int)(((byte)(248)))), ((int)(((byte)(3)))));
            this.buttonLogin.Location = new System.Drawing.Point(514, 27);
            this.buttonLogin.Name = "buttonLogin";
            this.buttonLogin.Size = new System.Drawing.Size(83, 35);
            this.buttonLogin.TabIndex = 2;
            this.buttonLogin.Text = "Login";
            this.buttonLogin.UseVisualStyleBackColor = false;
            this.buttonLogin.MouseEnter += new System.EventHandler(this.buttonLogin_MouseEnter);
            this.buttonLogin.MouseLeave += new System.EventHandler(this.buttonLogin_MouseLeave);
            // 
            // panelDesktop
            // 
            this.panelDesktop.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(37)))), ((int)(((byte)(37)))), ((int)(((byte)(37)))));
            this.panelDesktop.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelDesktop.Location = new System.Drawing.Point(200, 100);
            this.panelDesktop.Name = "panelDesktop";
            this.panelDesktop.Size = new System.Drawing.Size(600, 350);
            this.panelDesktop.TabIndex = 2;
            // 
            // FormIndex
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.panelDesktop);
            this.Controls.Add(this.panelTitle);
            this.Controls.Add(this.panelSideBar);
            this.Name = "FormIndex";
            this.Text = "THC";
            this.panelSideBar.ResumeLayout(false);
            this.panelProfile.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.panelTitle.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureMinimize)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureMaximize)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureClose)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panelSideBar;
        private System.Windows.Forms.Panel panelProfile;
        private System.Windows.Forms.Panel panelTitle;
        private System.Windows.Forms.Panel panelDesktop;
        private System.Windows.Forms.Button buttonBJ;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Button buttonLogin;
        private System.Windows.Forms.Button buttonLoginProfile;
        private System.Windows.Forms.PictureBox pictureMinimize;
        private System.Windows.Forms.PictureBox pictureMaximize;
        private System.Windows.Forms.PictureBox pictureClose;
    }
}

