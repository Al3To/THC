﻿namespace Client.Forms
{
    partial class FormLogin
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
            this.panel2 = new System.Windows.Forms.Panel();
            this.showPassword = new FontAwesome.Sharp.IconButton();
            this.panel3 = new System.Windows.Forms.Panel();
            this.buttonRegister = new System.Windows.Forms.Button();
            this.labelNewUser = new System.Windows.Forms.Label();
            this.buttonLogin = new System.Windows.Forms.Button();
            this.textBoxPassword = new System.Windows.Forms.TextBox();
            this.textBoxUsername = new System.Windows.Forms.TextBox();
            this.buttonClose = new FontAwesome.Sharp.IconButton();
            this.iconPassword = new FontAwesome.Sharp.IconButton();
            this.iconUsername = new FontAwesome.Sharp.IconButton();
            this.panelTitle.SuspendLayout();
            this.panel2.SuspendLayout();
            this.panel3.SuspendLayout();
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
            this.panelTitle.Size = new System.Drawing.Size(541, 75);
            this.panelTitle.TabIndex = 0;
            this.panelTitle.MouseDown += new System.Windows.Forms.MouseEventHandler(this.panelTitle_MouseDown);
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(23)))), ((int)(((byte)(23)))), ((int)(((byte)(23)))));
            this.panel2.Controls.Add(this.iconPassword);
            this.panel2.Controls.Add(this.iconUsername);
            this.panel2.Controls.Add(this.showPassword);
            this.panel2.Controls.Add(this.panel3);
            this.panel2.Controls.Add(this.buttonLogin);
            this.panel2.Controls.Add(this.textBoxPassword);
            this.panel2.Controls.Add(this.textBoxUsername);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel2.Location = new System.Drawing.Point(0, 75);
            this.panel2.Margin = new System.Windows.Forms.Padding(4);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(541, 479);
            this.panel2.TabIndex = 1;
            // 
            // showPassword
            // 
            this.showPassword.Cursor = System.Windows.Forms.Cursors.Hand;
            this.showPassword.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.showPassword.IconChar = FontAwesome.Sharp.IconChar.Eye;
            this.showPassword.IconColor = System.Drawing.Color.Black;
            this.showPassword.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.showPassword.IconSize = 18;
            this.showPassword.Location = new System.Drawing.Point(392, 149);
            this.showPassword.Margin = new System.Windows.Forms.Padding(4);
            this.showPassword.Name = "showPassword";
            this.showPassword.Size = new System.Drawing.Size(31, 25);
            this.showPassword.TabIndex = 39;
            this.showPassword.UseVisualStyleBackColor = true;
            this.showPassword.Click += new System.EventHandler(this.showPassword_Click);
            // 
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(35)))), ((int)(((byte)(35)))), ((int)(((byte)(35)))));
            this.panel3.Controls.Add(this.buttonRegister);
            this.panel3.Controls.Add(this.labelNewUser);
            this.panel3.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel3.Location = new System.Drawing.Point(0, 356);
            this.panel3.Margin = new System.Windows.Forms.Padding(4);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(541, 123);
            this.panel3.TabIndex = 10;
            // 
            // buttonRegister
            // 
            this.buttonRegister.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.buttonRegister.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(252)))), ((int)(((byte)(228)))), ((int)(((byte)(3)))));
            this.buttonRegister.Cursor = System.Windows.Forms.Cursors.Hand;
            this.buttonRegister.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonRegister.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonRegister.ForeColor = System.Drawing.Color.Black;
            this.buttonRegister.Location = new System.Drawing.Point(197, 74);
            this.buttonRegister.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.buttonRegister.Name = "buttonRegister";
            this.buttonRegister.Size = new System.Drawing.Size(139, 36);
            this.buttonRegister.TabIndex = 8;
            this.buttonRegister.Text = "REGISTRATI";
            this.buttonRegister.UseVisualStyleBackColor = false;
            this.buttonRegister.Click += new System.EventHandler(this.buttonRegister_Click);
            // 
            // labelNewUser
            // 
            this.labelNewUser.AutoSize = true;
            this.labelNewUser.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelNewUser.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(234)))), ((int)(((byte)(252)))), ((int)(((byte)(255)))));
            this.labelNewUser.Location = new System.Drawing.Point(200, 7);
            this.labelNewUser.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.labelNewUser.Name = "labelNewUser";
            this.labelNewUser.Size = new System.Drawing.Size(135, 24);
            this.labelNewUser.TabIndex = 9;
            this.labelNewUser.Text = "Nuovo Utente?";
            // 
            // buttonLogin
            // 
            this.buttonLogin.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.buttonLogin.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(23)))), ((int)(((byte)(23)))), ((int)(((byte)(23)))));
            this.buttonLogin.Cursor = System.Windows.Forms.Cursors.Hand;
            this.buttonLogin.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonLogin.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonLogin.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(127)))), ((int)(((byte)(248)))), ((int)(((byte)(3)))));
            this.buttonLogin.Location = new System.Drawing.Point(222, 213);
            this.buttonLogin.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.buttonLogin.Name = "buttonLogin";
            this.buttonLogin.Size = new System.Drawing.Size(77, 36);
            this.buttonLogin.TabIndex = 4;
            this.buttonLogin.Text = "LOGIN";
            this.buttonLogin.UseVisualStyleBackColor = false;
            this.buttonLogin.Click += new System.EventHandler(this.buttonLogin_Click);
            // 
            // textBoxPassword
            // 
            this.textBoxPassword.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(23)))), ((int)(((byte)(23)))), ((int)(((byte)(23)))));
            this.textBoxPassword.ForeColor = System.Drawing.SystemColors.InactiveCaption;
            this.textBoxPassword.Location = new System.Drawing.Point(171, 150);
            this.textBoxPassword.Margin = new System.Windows.Forms.Padding(4);
            this.textBoxPassword.Name = "textBoxPassword";
            this.textBoxPassword.Size = new System.Drawing.Size(221, 22);
            this.textBoxPassword.TabIndex = 3;
            this.textBoxPassword.Text = "Password";
            this.textBoxPassword.Enter += new System.EventHandler(this.textBoxPassword_Enter);
            this.textBoxPassword.KeyDown += new System.Windows.Forms.KeyEventHandler(this.textBoxPassword_KeyDown);
            this.textBoxPassword.Leave += new System.EventHandler(this.textBoxPassword_Leave);
            // 
            // textBoxUsername
            // 
            this.textBoxUsername.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(23)))), ((int)(((byte)(23)))), ((int)(((byte)(23)))));
            this.textBoxUsername.ForeColor = System.Drawing.SystemColors.InactiveCaption;
            this.textBoxUsername.Location = new System.Drawing.Point(171, 86);
            this.textBoxUsername.Margin = new System.Windows.Forms.Padding(4);
            this.textBoxUsername.Name = "textBoxUsername";
            this.textBoxUsername.Size = new System.Drawing.Size(221, 22);
            this.textBoxUsername.TabIndex = 2;
            this.textBoxUsername.Text = "Nome Utente";
            this.textBoxUsername.Enter += new System.EventHandler(this.textBoxUsername_Enter);
            this.textBoxUsername.Leave += new System.EventHandler(this.textBoxUsername_Leave);
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
            this.buttonClose.Location = new System.Drawing.Point(491, 18);
            this.buttonClose.Margin = new System.Windows.Forms.Padding(4);
            this.buttonClose.Name = "buttonClose";
            this.buttonClose.Size = new System.Drawing.Size(42, 36);
            this.buttonClose.TabIndex = 42;
            this.buttonClose.UseVisualStyleBackColor = true;
            this.buttonClose.Click += new System.EventHandler(this.buttonClose_Click);
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
            this.iconPassword.Location = new System.Drawing.Point(130, 144);
            this.iconPassword.Margin = new System.Windows.Forms.Padding(4);
            this.iconPassword.Name = "iconPassword";
            this.iconPassword.Size = new System.Drawing.Size(37, 35);
            this.iconPassword.TabIndex = 43;
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
            this.iconUsername.Location = new System.Drawing.Point(130, 80);
            this.iconUsername.Margin = new System.Windows.Forms.Padding(4);
            this.iconUsername.Name = "iconUsername";
            this.iconUsername.Size = new System.Drawing.Size(37, 35);
            this.iconUsername.TabIndex = 42;
            this.iconUsername.UseVisualStyleBackColor = true;
            // 
            // FormLogin
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(541, 554);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panelTitle);
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "FormLogin";
            this.Text = "FormLogin";
            this.Load += new System.EventHandler(this.FormLogin_Load);
            this.panelTitle.ResumeLayout(false);
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panelTitle;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.TextBox textBoxPassword;
        private System.Windows.Forms.TextBox textBoxUsername;
        private System.Windows.Forms.Button buttonLogin;
        private System.Windows.Forms.Button buttonRegister;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Label labelNewUser;
        private FontAwesome.Sharp.IconButton showPassword;
        private FontAwesome.Sharp.IconButton buttonClose;
        private FontAwesome.Sharp.IconButton iconPassword;
        private FontAwesome.Sharp.IconButton iconUsername;
    }
}