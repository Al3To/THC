namespace Client.Forms
{
    partial class FormRegister
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
            this.panelTitle = new System.Windows.Forms.Panel();
            this.buttonClose = new FontAwesome.Sharp.IconButton();
            this.panel3 = new System.Windows.Forms.Panel();
            this.labelAlredyUser = new System.Windows.Forms.Label();
            this.buttonLogin = new System.Windows.Forms.Button();
            this.panel2 = new System.Windows.Forms.Panel();
            this.showPassword = new FontAwesome.Sharp.IconButton();
            this.textBoxPassword = new System.Windows.Forms.TextBox();
            this.textBoxUsername = new System.Windows.Forms.TextBox();
            this.iconPassword = new FontAwesome.Sharp.IconButton();
            this.iconUsername = new FontAwesome.Sharp.IconButton();
            this.iconButton1 = new FontAwesome.Sharp.IconButton();
            this.iconButton2 = new FontAwesome.Sharp.IconButton();
            this.textBoxPasswordConfirm = new System.Windows.Forms.TextBox();
            this.iconButton3 = new FontAwesome.Sharp.IconButton();
            this.textBoxEmail = new System.Windows.Forms.TextBox();
            this.buttonRegister = new System.Windows.Forms.Button();
            this.panelTitle.SuspendLayout();
            this.panel3.SuspendLayout();
            this.panel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // panelTitle
            // 
            this.panelTitle.BackColor = System.Drawing.Color.Black;
            this.panelTitle.Controls.Add(this.buttonClose);
            this.panelTitle.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelTitle.Location = new System.Drawing.Point(0, 0);
            this.panelTitle.Margin = new System.Windows.Forms.Padding(4);
            this.panelTitle.Name = "panelTitle";
            this.panelTitle.Size = new System.Drawing.Size(767, 75);
            this.panelTitle.TabIndex = 1;
            // 
            // buttonClose
            // 
            this.buttonClose.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.buttonClose.Cursor = System.Windows.Forms.Cursors.Hand;
            this.buttonClose.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonClose.IconChar = FontAwesome.Sharp.IconChar.X;
            this.buttonClose.IconColor = System.Drawing.Color.Gainsboro;
            this.buttonClose.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.buttonClose.IconSize = 40;
            this.buttonClose.Location = new System.Drawing.Point(712, 13);
            this.buttonClose.Margin = new System.Windows.Forms.Padding(4);
            this.buttonClose.Name = "buttonClose";
            this.buttonClose.Size = new System.Drawing.Size(42, 36);
            this.buttonClose.TabIndex = 42;
            this.buttonClose.UseVisualStyleBackColor = true;
            this.buttonClose.Click += new System.EventHandler(this.buttonClose_Click);
            // 
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(35)))), ((int)(((byte)(35)))), ((int)(((byte)(35)))));
            this.panel3.Controls.Add(this.buttonLogin);
            this.panel3.Controls.Add(this.labelAlredyUser);
            this.panel3.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel3.Location = new System.Drawing.Point(0, 327);
            this.panel3.Margin = new System.Windows.Forms.Padding(4);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(767, 123);
            this.panel3.TabIndex = 11;
            // 
            // labelAlredyUser
            // 
            this.labelAlredyUser.AutoSize = true;
            this.labelAlredyUser.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelAlredyUser.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(234)))), ((int)(((byte)(252)))), ((int)(((byte)(255)))));
            this.labelAlredyUser.Location = new System.Drawing.Point(271, 0);
            this.labelAlredyUser.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.labelAlredyUser.Name = "labelAlredyUser";
            this.labelAlredyUser.Size = new System.Drawing.Size(203, 24);
            this.labelAlredyUser.TabIndex = 9;
            this.labelAlredyUser.Text = "SEI GIA\' UN UTENTE?";
            // 
            // buttonLogin
            // 
            this.buttonLogin.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.buttonLogin.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(35)))), ((int)(((byte)(35)))), ((int)(((byte)(35)))));
            this.buttonLogin.Cursor = System.Windows.Forms.Cursors.Hand;
            this.buttonLogin.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonLogin.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonLogin.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(127)))), ((int)(((byte)(248)))), ((int)(((byte)(3)))));
            this.buttonLogin.Location = new System.Drawing.Point(305, 76);
            this.buttonLogin.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.buttonLogin.Name = "buttonLogin";
            this.buttonLogin.Size = new System.Drawing.Size(142, 36);
            this.buttonLogin.TabIndex = 10;
            this.buttonLogin.Text = "ACCEDI";
            this.buttonLogin.UseVisualStyleBackColor = false;
            this.buttonLogin.Click += new System.EventHandler(this.buttonLogin_Click);
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(23)))), ((int)(((byte)(23)))), ((int)(((byte)(23)))));
            this.panel2.Controls.Add(this.buttonRegister);
            this.panel2.Controls.Add(this.iconButton3);
            this.panel2.Controls.Add(this.textBoxEmail);
            this.panel2.Controls.Add(this.iconButton1);
            this.panel2.Controls.Add(this.iconButton2);
            this.panel2.Controls.Add(this.textBoxPasswordConfirm);
            this.panel2.Controls.Add(this.iconPassword);
            this.panel2.Controls.Add(this.iconUsername);
            this.panel2.Controls.Add(this.showPassword);
            this.panel2.Controls.Add(this.textBoxPassword);
            this.panel2.Controls.Add(this.textBoxUsername);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel2.Location = new System.Drawing.Point(0, 75);
            this.panel2.Margin = new System.Windows.Forms.Padding(4);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(767, 252);
            this.panel2.TabIndex = 12;
            // 
            // showPassword
            // 
            this.showPassword.Cursor = System.Windows.Forms.Cursors.Hand;
            this.showPassword.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.showPassword.IconChar = FontAwesome.Sharp.IconChar.Eye;
            this.showPassword.IconColor = System.Drawing.Color.Gainsboro;
            this.showPassword.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.showPassword.IconSize = 18;
            this.showPassword.Location = new System.Drawing.Point(473, 88);
            this.showPassword.Margin = new System.Windows.Forms.Padding(4);
            this.showPassword.Name = "showPassword";
            this.showPassword.Size = new System.Drawing.Size(31, 25);
            this.showPassword.TabIndex = 39;
            this.showPassword.UseVisualStyleBackColor = true;
            // 
            // textBoxPassword
            // 
            this.textBoxPassword.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(23)))), ((int)(((byte)(23)))), ((int)(((byte)(23)))));
            this.textBoxPassword.ForeColor = System.Drawing.SystemColors.InactiveCaption;
            this.textBoxPassword.Location = new System.Drawing.Point(253, 88);
            this.textBoxPassword.Margin = new System.Windows.Forms.Padding(4);
            this.textBoxPassword.Name = "textBoxPassword";
            this.textBoxPassword.Size = new System.Drawing.Size(221, 22);
            this.textBoxPassword.TabIndex = 3;
            this.textBoxPassword.Text = "Password";
            // 
            // textBoxUsername
            // 
            this.textBoxUsername.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(23)))), ((int)(((byte)(23)))), ((int)(((byte)(23)))));
            this.textBoxUsername.ForeColor = System.Drawing.SystemColors.InactiveCaption;
            this.textBoxUsername.Location = new System.Drawing.Point(253, 58);
            this.textBoxUsername.Margin = new System.Windows.Forms.Padding(4);
            this.textBoxUsername.Name = "textBoxUsername";
            this.textBoxUsername.Size = new System.Drawing.Size(221, 22);
            this.textBoxUsername.TabIndex = 2;
            this.textBoxUsername.Text = "Nome Utente";
            // 
            // iconPassword
            // 
            this.iconPassword.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.iconPassword.FlatAppearance.BorderSize = 0;
            this.iconPassword.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.iconPassword.IconChar = FontAwesome.Sharp.IconChar.Lock;
            this.iconPassword.IconColor = System.Drawing.Color.Black;
            this.iconPassword.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.iconPassword.IconSize = 26;
            this.iconPassword.Location = new System.Drawing.Point(208, 82);
            this.iconPassword.Margin = new System.Windows.Forms.Padding(4);
            this.iconPassword.Name = "iconPassword";
            this.iconPassword.Size = new System.Drawing.Size(37, 35);
            this.iconPassword.TabIndex = 45;
            this.iconPassword.UseVisualStyleBackColor = true;
            // 
            // iconUsername
            // 
            this.iconUsername.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.iconUsername.FlatAppearance.BorderSize = 0;
            this.iconUsername.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.iconUsername.IconChar = FontAwesome.Sharp.IconChar.User;
            this.iconUsername.IconColor = System.Drawing.Color.Black;
            this.iconUsername.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.iconUsername.IconSize = 26;
            this.iconUsername.Location = new System.Drawing.Point(208, 52);
            this.iconUsername.Margin = new System.Windows.Forms.Padding(4);
            this.iconUsername.Name = "iconUsername";
            this.iconUsername.Size = new System.Drawing.Size(37, 35);
            this.iconUsername.TabIndex = 44;
            this.iconUsername.UseVisualStyleBackColor = true;
            // 
            // iconButton1
            // 
            this.iconButton1.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.iconButton1.FlatAppearance.BorderSize = 0;
            this.iconButton1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.iconButton1.IconChar = FontAwesome.Sharp.IconChar.Lock;
            this.iconButton1.IconColor = System.Drawing.Color.Black;
            this.iconButton1.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.iconButton1.IconSize = 26;
            this.iconButton1.Location = new System.Drawing.Point(208, 115);
            this.iconButton1.Margin = new System.Windows.Forms.Padding(4);
            this.iconButton1.Name = "iconButton1";
            this.iconButton1.Size = new System.Drawing.Size(37, 35);
            this.iconButton1.TabIndex = 48;
            this.iconButton1.UseVisualStyleBackColor = true;
            // 
            // iconButton2
            // 
            this.iconButton2.Cursor = System.Windows.Forms.Cursors.Hand;
            this.iconButton2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.iconButton2.IconChar = FontAwesome.Sharp.IconChar.Eye;
            this.iconButton2.IconColor = System.Drawing.Color.Gainsboro;
            this.iconButton2.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.iconButton2.IconSize = 18;
            this.iconButton2.Location = new System.Drawing.Point(473, 121);
            this.iconButton2.Margin = new System.Windows.Forms.Padding(4);
            this.iconButton2.Name = "iconButton2";
            this.iconButton2.Size = new System.Drawing.Size(31, 25);
            this.iconButton2.TabIndex = 47;
            this.iconButton2.UseVisualStyleBackColor = true;
            // 
            // textBoxPasswordConfirm
            // 
            this.textBoxPasswordConfirm.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(23)))), ((int)(((byte)(23)))), ((int)(((byte)(23)))));
            this.textBoxPasswordConfirm.ForeColor = System.Drawing.SystemColors.InactiveCaption;
            this.textBoxPasswordConfirm.Location = new System.Drawing.Point(253, 121);
            this.textBoxPasswordConfirm.Margin = new System.Windows.Forms.Padding(4);
            this.textBoxPasswordConfirm.Name = "textBoxPasswordConfirm";
            this.textBoxPasswordConfirm.Size = new System.Drawing.Size(221, 22);
            this.textBoxPasswordConfirm.TabIndex = 46;
            this.textBoxPasswordConfirm.Text = "Password";
            // 
            // iconButton3
            // 
            this.iconButton3.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.iconButton3.FlatAppearance.BorderSize = 0;
            this.iconButton3.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.iconButton3.IconChar = FontAwesome.Sharp.IconChar.Envelope;
            this.iconButton3.IconColor = System.Drawing.Color.Black;
            this.iconButton3.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.iconButton3.IconSize = 26;
            this.iconButton3.Location = new System.Drawing.Point(208, 22);
            this.iconButton3.Margin = new System.Windows.Forms.Padding(4);
            this.iconButton3.Name = "iconButton3";
            this.iconButton3.Size = new System.Drawing.Size(37, 35);
            this.iconButton3.TabIndex = 50;
            this.iconButton3.UseVisualStyleBackColor = true;
            // 
            // textBoxEmail
            // 
            this.textBoxEmail.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(23)))), ((int)(((byte)(23)))), ((int)(((byte)(23)))));
            this.textBoxEmail.ForeColor = System.Drawing.SystemColors.InactiveCaption;
            this.textBoxEmail.Location = new System.Drawing.Point(253, 28);
            this.textBoxEmail.Margin = new System.Windows.Forms.Padding(4);
            this.textBoxEmail.Name = "textBoxEmail";
            this.textBoxEmail.Size = new System.Drawing.Size(221, 22);
            this.textBoxEmail.TabIndex = 49;
            this.textBoxEmail.Text = "Email";
            // 
            // buttonRegister
            // 
            this.buttonRegister.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.buttonRegister.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(252)))), ((int)(((byte)(228)))), ((int)(((byte)(3)))));
            this.buttonRegister.Cursor = System.Windows.Forms.Cursors.Hand;
            this.buttonRegister.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonRegister.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonRegister.ForeColor = System.Drawing.Color.Black;
            this.buttonRegister.Location = new System.Drawing.Point(308, 191);
            this.buttonRegister.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.buttonRegister.Name = "buttonRegister";
            this.buttonRegister.Size = new System.Drawing.Size(139, 36);
            this.buttonRegister.TabIndex = 51;
            this.buttonRegister.Text = "REGISTRATI";
            this.buttonRegister.UseVisualStyleBackColor = false;
            // 
            // FormRegister
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(767, 450);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.panelTitle);
            this.Name = "FormRegister";
            this.Text = "FormRegister";
            this.panelTitle.ResumeLayout(false);
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panelTitle;
        private FontAwesome.Sharp.IconButton buttonClose;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Label labelAlredyUser;
        private System.Windows.Forms.Button buttonLogin;
        private System.Windows.Forms.Panel panel2;
        private FontAwesome.Sharp.IconButton showPassword;
        private System.Windows.Forms.TextBox textBoxPassword;
        private System.Windows.Forms.TextBox textBoxUsername;
        private FontAwesome.Sharp.IconButton iconButton3;
        private System.Windows.Forms.TextBox textBoxEmail;
        private FontAwesome.Sharp.IconButton iconButton1;
        private FontAwesome.Sharp.IconButton iconButton2;
        private System.Windows.Forms.TextBox textBoxPasswordConfirm;
        private FontAwesome.Sharp.IconButton iconPassword;
        private FontAwesome.Sharp.IconButton iconUsername;
        private System.Windows.Forms.Button buttonRegister;
    }
}