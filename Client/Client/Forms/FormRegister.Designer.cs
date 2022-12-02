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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormRegister));
            this.panelTitle = new System.Windows.Forms.Panel();
            this.buttonClose = new FontAwesome.Sharp.IconButton();
            this.panelBottonBar = new System.Windows.Forms.Panel();
            this.buttonLogin = new System.Windows.Forms.Button();
            this.labelAlredyUser = new System.Windows.Forms.Label();
            this.panelRegister1 = new System.Windows.Forms.Panel();
            this.labelPage = new System.Windows.Forms.Label();
            this.labelResult = new System.Windows.Forms.Label();
            this.buttonForward = new System.Windows.Forms.Button();
            this.iconEmail = new FontAwesome.Sharp.IconButton();
            this.textBoxEmail = new System.Windows.Forms.TextBox();
            this.iconPasswordConfirm = new FontAwesome.Sharp.IconButton();
            this.showPasswordConfirm = new FontAwesome.Sharp.IconButton();
            this.textBoxPasswordConfirm = new System.Windows.Forms.TextBox();
            this.iconPassword = new FontAwesome.Sharp.IconButton();
            this.iconUsername = new FontAwesome.Sharp.IconButton();
            this.showPassword = new FontAwesome.Sharp.IconButton();
            this.textBoxPassword = new System.Windows.Forms.TextBox();
            this.textBoxUsername = new System.Windows.Forms.TextBox();
            this.buttonRegister = new System.Windows.Forms.Button();
            this.panelRegister2 = new System.Windows.Forms.Panel();
            this.buttonBack = new System.Windows.Forms.Button();
            this.iconBirthDate = new FontAwesome.Sharp.IconButton();
            this.dateBirthDate = new System.Windows.Forms.DateTimePicker();
            this.labelResult2 = new System.Windows.Forms.Label();
            this.iconButton1 = new FontAwesome.Sharp.IconButton();
            this.textBoxName = new System.Windows.Forms.TextBox();
            this.iconSurname = new FontAwesome.Sharp.IconButton();
            this.textBoxSurname = new System.Windows.Forms.TextBox();
            this.pictureLogo = new System.Windows.Forms.PictureBox();
            this.panelTitle.SuspendLayout();
            this.panelBottonBar.SuspendLayout();
            this.panelRegister1.SuspendLayout();
            this.panelRegister2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureLogo)).BeginInit();
            this.SuspendLayout();
            // 
            // panelTitle
            // 
            this.panelTitle.BackColor = System.Drawing.Color.Black;
            this.panelTitle.Controls.Add(this.pictureLogo);
            this.panelTitle.Controls.Add(this.buttonClose);
            this.panelTitle.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelTitle.Location = new System.Drawing.Point(0, 0);
            this.panelTitle.Name = "panelTitle";
            this.panelTitle.Size = new System.Drawing.Size(575, 61);
            this.panelTitle.TabIndex = 100;
            this.panelTitle.MouseDown += new System.Windows.Forms.MouseEventHandler(this.panelTitle_MouseDown);
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
            this.buttonClose.Location = new System.Drawing.Point(533, 11);
            this.buttonClose.Name = "buttonClose";
            this.buttonClose.Size = new System.Drawing.Size(33, 44);
            this.buttonClose.TabIndex = 11;
            this.buttonClose.UseVisualStyleBackColor = true;
            this.buttonClose.Click += new System.EventHandler(this.buttonClose_Click);
            // 
            // panelBottonBar
            // 
            this.panelBottonBar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(35)))), ((int)(((byte)(35)))), ((int)(((byte)(35)))));
            this.panelBottonBar.Controls.Add(this.buttonLogin);
            this.panelBottonBar.Controls.Add(this.labelAlredyUser);
            this.panelBottonBar.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panelBottonBar.Location = new System.Drawing.Point(0, 266);
            this.panelBottonBar.Name = "panelBottonBar";
            this.panelBottonBar.Size = new System.Drawing.Size(575, 100);
            this.panelBottonBar.TabIndex = 103;
            // 
            // buttonLogin
            // 
            this.buttonLogin.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.buttonLogin.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(35)))), ((int)(((byte)(35)))), ((int)(((byte)(35)))));
            this.buttonLogin.Cursor = System.Windows.Forms.Cursors.Hand;
            this.buttonLogin.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonLogin.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonLogin.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(127)))), ((int)(((byte)(248)))), ((int)(((byte)(3)))));
            this.buttonLogin.Location = new System.Drawing.Point(229, 62);
            this.buttonLogin.Margin = new System.Windows.Forms.Padding(2);
            this.buttonLogin.Name = "buttonLogin";
            this.buttonLogin.Size = new System.Drawing.Size(106, 29);
            this.buttonLogin.TabIndex = 20;
            this.buttonLogin.Text = "ACCEDI";
            this.buttonLogin.UseVisualStyleBackColor = false;
            this.buttonLogin.Click += new System.EventHandler(this.buttonLogin_Click);
            // 
            // labelAlredyUser
            // 
            this.labelAlredyUser.AutoSize = true;
            this.labelAlredyUser.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelAlredyUser.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(234)))), ((int)(((byte)(252)))), ((int)(((byte)(255)))));
            this.labelAlredyUser.Location = new System.Drawing.Point(203, 0);
            this.labelAlredyUser.Name = "labelAlredyUser";
            this.labelAlredyUser.Size = new System.Drawing.Size(160, 18);
            this.labelAlredyUser.TabIndex = 102;
            this.labelAlredyUser.Text = "SEI GIA\' UN UTENTE?";
            // 
            // panelRegister1
            // 
            this.panelRegister1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(23)))), ((int)(((byte)(23)))), ((int)(((byte)(23)))));
            this.panelRegister1.Controls.Add(this.labelPage);
            this.panelRegister1.Controls.Add(this.labelResult);
            this.panelRegister1.Controls.Add(this.buttonForward);
            this.panelRegister1.Controls.Add(this.iconEmail);
            this.panelRegister1.Controls.Add(this.textBoxEmail);
            this.panelRegister1.Controls.Add(this.iconPasswordConfirm);
            this.panelRegister1.Controls.Add(this.showPasswordConfirm);
            this.panelRegister1.Controls.Add(this.textBoxPasswordConfirm);
            this.panelRegister1.Controls.Add(this.iconPassword);
            this.panelRegister1.Controls.Add(this.iconUsername);
            this.panelRegister1.Controls.Add(this.showPassword);
            this.panelRegister1.Controls.Add(this.textBoxPassword);
            this.panelRegister1.Controls.Add(this.textBoxUsername);
            this.panelRegister1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelRegister1.Location = new System.Drawing.Point(0, 61);
            this.panelRegister1.Name = "panelRegister1";
            this.panelRegister1.Size = new System.Drawing.Size(575, 205);
            this.panelRegister1.TabIndex = 99;
            // 
            // labelPage
            // 
            this.labelPage.AutoSize = true;
            this.labelPage.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelPage.ForeColor = System.Drawing.Color.White;
            this.labelPage.Location = new System.Drawing.Point(542, 3);
            this.labelPage.Name = "labelPage";
            this.labelPage.Size = new System.Drawing.Size(24, 15);
            this.labelPage.TabIndex = 101;
            this.labelPage.Text = "1/2";
            // 
            // labelResult
            // 
            this.labelResult.AutoSize = true;
            this.labelResult.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelResult.ForeColor = System.Drawing.Color.Gainsboro;
            this.labelResult.Location = new System.Drawing.Point(228, 138);
            this.labelResult.Name = "labelResult";
            this.labelResult.Size = new System.Drawing.Size(69, 15);
            this.labelResult.TabIndex = 52;
            this.labelResult.Text = "Credenziali";
            this.labelResult.Visible = false;
            // 
            // buttonForward
            // 
            this.buttonForward.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.buttonForward.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(252)))), ((int)(((byte)(228)))), ((int)(((byte)(3)))));
            this.buttonForward.Cursor = System.Windows.Forms.Cursors.Hand;
            this.buttonForward.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonForward.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonForward.ForeColor = System.Drawing.Color.Black;
            this.buttonForward.Location = new System.Drawing.Point(462, 171);
            this.buttonForward.Margin = new System.Windows.Forms.Padding(2);
            this.buttonForward.Name = "buttonForward";
            this.buttonForward.Size = new System.Drawing.Size(104, 29);
            this.buttonForward.TabIndex = 5;
            this.buttonForward.Text = "AVANTI";
            this.buttonForward.UseVisualStyleBackColor = false;
            this.buttonForward.Click += new System.EventHandler(this.buttonForward_Click);
            // 
            // iconEmail
            // 
            this.iconEmail.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.iconEmail.FlatAppearance.BorderSize = 0;
            this.iconEmail.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.iconEmail.IconChar = FontAwesome.Sharp.IconChar.Envelope;
            this.iconEmail.IconColor = System.Drawing.Color.Black;
            this.iconEmail.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.iconEmail.IconSize = 26;
            this.iconEmail.Location = new System.Drawing.Point(156, 18);
            this.iconEmail.Name = "iconEmail";
            this.iconEmail.Size = new System.Drawing.Size(28, 28);
            this.iconEmail.TabIndex = 98;
            this.iconEmail.UseVisualStyleBackColor = true;
            // 
            // textBoxEmail
            // 
            this.textBoxEmail.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(23)))), ((int)(((byte)(23)))), ((int)(((byte)(23)))));
            this.textBoxEmail.ForeColor = System.Drawing.SystemColors.InactiveCaption;
            this.textBoxEmail.Location = new System.Drawing.Point(190, 23);
            this.textBoxEmail.Name = "textBoxEmail";
            this.textBoxEmail.Size = new System.Drawing.Size(167, 20);
            this.textBoxEmail.TabIndex = 1;
            this.textBoxEmail.Text = "Email";
            this.textBoxEmail.Enter += new System.EventHandler(this.textBoxEmail_Enter);
            this.textBoxEmail.Leave += new System.EventHandler(this.textBoxEmail_Leave);
            // 
            // iconPasswordConfirm
            // 
            this.iconPasswordConfirm.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.iconPasswordConfirm.FlatAppearance.BorderSize = 0;
            this.iconPasswordConfirm.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.iconPasswordConfirm.IconChar = FontAwesome.Sharp.IconChar.Lock;
            this.iconPasswordConfirm.IconColor = System.Drawing.Color.Black;
            this.iconPasswordConfirm.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.iconPasswordConfirm.IconSize = 26;
            this.iconPasswordConfirm.Location = new System.Drawing.Point(156, 93);
            this.iconPasswordConfirm.Name = "iconPasswordConfirm";
            this.iconPasswordConfirm.Size = new System.Drawing.Size(28, 28);
            this.iconPasswordConfirm.TabIndex = 95;
            this.iconPasswordConfirm.UseVisualStyleBackColor = true;
            // 
            // showPasswordConfirm
            // 
            this.showPasswordConfirm.Cursor = System.Windows.Forms.Cursors.Hand;
            this.showPasswordConfirm.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.showPasswordConfirm.IconChar = FontAwesome.Sharp.IconChar.Eye;
            this.showPasswordConfirm.IconColor = System.Drawing.Color.Gainsboro;
            this.showPasswordConfirm.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.showPasswordConfirm.IconSize = 18;
            this.showPasswordConfirm.Location = new System.Drawing.Point(356, 98);
            this.showPasswordConfirm.Name = "showPasswordConfirm";
            this.showPasswordConfirm.Size = new System.Drawing.Size(23, 20);
            this.showPasswordConfirm.TabIndex = 47;
            this.showPasswordConfirm.UseVisualStyleBackColor = true;
            this.showPasswordConfirm.Click += new System.EventHandler(this.showPasswordConfirm_Click);
            // 
            // textBoxPasswordConfirm
            // 
            this.textBoxPasswordConfirm.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(23)))), ((int)(((byte)(23)))), ((int)(((byte)(23)))));
            this.textBoxPasswordConfirm.ForeColor = System.Drawing.SystemColors.InactiveCaption;
            this.textBoxPasswordConfirm.Location = new System.Drawing.Point(190, 98);
            this.textBoxPasswordConfirm.Name = "textBoxPasswordConfirm";
            this.textBoxPasswordConfirm.Size = new System.Drawing.Size(167, 20);
            this.textBoxPasswordConfirm.TabIndex = 4;
            this.textBoxPasswordConfirm.Text = "Conferma Password";
            this.textBoxPasswordConfirm.Enter += new System.EventHandler(this.textBoxPasswordConfirm_Enter);
            this.textBoxPasswordConfirm.Leave += new System.EventHandler(this.textBoxPasswordConfirm_Leave);
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
            this.iconPassword.Location = new System.Drawing.Point(156, 67);
            this.iconPassword.Name = "iconPassword";
            this.iconPassword.Size = new System.Drawing.Size(28, 28);
            this.iconPassword.TabIndex = 96;
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
            this.iconUsername.Location = new System.Drawing.Point(156, 42);
            this.iconUsername.Name = "iconUsername";
            this.iconUsername.Size = new System.Drawing.Size(28, 28);
            this.iconUsername.TabIndex = 97;
            this.iconUsername.UseVisualStyleBackColor = true;
            // 
            // showPassword
            // 
            this.showPassword.Cursor = System.Windows.Forms.Cursors.Hand;
            this.showPassword.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.showPassword.IconChar = FontAwesome.Sharp.IconChar.Eye;
            this.showPassword.IconColor = System.Drawing.Color.Gainsboro;
            this.showPassword.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.showPassword.IconSize = 18;
            this.showPassword.Location = new System.Drawing.Point(356, 72);
            this.showPassword.Name = "showPassword";
            this.showPassword.Size = new System.Drawing.Size(23, 20);
            this.showPassword.TabIndex = 39;
            this.showPassword.UseVisualStyleBackColor = true;
            this.showPassword.Click += new System.EventHandler(this.showPassword_Click);
            // 
            // textBoxPassword
            // 
            this.textBoxPassword.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(23)))), ((int)(((byte)(23)))), ((int)(((byte)(23)))));
            this.textBoxPassword.ForeColor = System.Drawing.SystemColors.InactiveCaption;
            this.textBoxPassword.Location = new System.Drawing.Point(190, 72);
            this.textBoxPassword.Name = "textBoxPassword";
            this.textBoxPassword.Size = new System.Drawing.Size(167, 20);
            this.textBoxPassword.TabIndex = 3;
            this.textBoxPassword.Text = "Password";
            this.textBoxPassword.Enter += new System.EventHandler(this.textBoxPassword_Enter);
            this.textBoxPassword.Leave += new System.EventHandler(this.textBoxPassword_Leave);
            // 
            // textBoxUsername
            // 
            this.textBoxUsername.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(23)))), ((int)(((byte)(23)))), ((int)(((byte)(23)))));
            this.textBoxUsername.ForeColor = System.Drawing.SystemColors.InactiveCaption;
            this.textBoxUsername.Location = new System.Drawing.Point(190, 47);
            this.textBoxUsername.Name = "textBoxUsername";
            this.textBoxUsername.Size = new System.Drawing.Size(167, 20);
            this.textBoxUsername.TabIndex = 2;
            this.textBoxUsername.Text = "Nome Utente";
            this.textBoxUsername.Enter += new System.EventHandler(this.textBoxUsername_Enter);
            this.textBoxUsername.Leave += new System.EventHandler(this.textBoxUsername_Leave);
            // 
            // buttonRegister
            // 
            this.buttonRegister.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.buttonRegister.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(252)))), ((int)(((byte)(228)))), ((int)(((byte)(3)))));
            this.buttonRegister.Cursor = System.Windows.Forms.Cursors.Hand;
            this.buttonRegister.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonRegister.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonRegister.ForeColor = System.Drawing.Color.Black;
            this.buttonRegister.Location = new System.Drawing.Point(218, 155);
            this.buttonRegister.Margin = new System.Windows.Forms.Padding(2);
            this.buttonRegister.Name = "buttonRegister";
            this.buttonRegister.Size = new System.Drawing.Size(104, 29);
            this.buttonRegister.TabIndex = 9;
            this.buttonRegister.Text = "REGISTRATI";
            this.buttonRegister.UseVisualStyleBackColor = false;
            this.buttonRegister.Click += new System.EventHandler(this.buttonRegister_Click);
            // 
            // panelRegister2
            // 
            this.panelRegister2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(23)))), ((int)(((byte)(23)))), ((int)(((byte)(23)))));
            this.panelRegister2.Controls.Add(this.buttonBack);
            this.panelRegister2.Controls.Add(this.iconBirthDate);
            this.panelRegister2.Controls.Add(this.dateBirthDate);
            this.panelRegister2.Controls.Add(this.labelResult2);
            this.panelRegister2.Controls.Add(this.iconButton1);
            this.panelRegister2.Controls.Add(this.textBoxName);
            this.panelRegister2.Controls.Add(this.iconSurname);
            this.panelRegister2.Controls.Add(this.textBoxSurname);
            this.panelRegister2.Controls.Add(this.buttonRegister);
            this.panelRegister2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelRegister2.Location = new System.Drawing.Point(0, 61);
            this.panelRegister2.Name = "panelRegister2";
            this.panelRegister2.Size = new System.Drawing.Size(575, 205);
            this.panelRegister2.TabIndex = 52;
            this.panelRegister2.Visible = false;
            // 
            // buttonBack
            // 
            this.buttonBack.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.buttonBack.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(35)))), ((int)(((byte)(35)))), ((int)(((byte)(35)))));
            this.buttonBack.Cursor = System.Windows.Forms.Cursors.Hand;
            this.buttonBack.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonBack.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonBack.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(127)))), ((int)(((byte)(248)))), ((int)(((byte)(3)))));
            this.buttonBack.Location = new System.Drawing.Point(2, 155);
            this.buttonBack.Margin = new System.Windows.Forms.Padding(2);
            this.buttonBack.Name = "buttonBack";
            this.buttonBack.Size = new System.Drawing.Size(74, 29);
            this.buttonBack.TabIndex = 10;
            this.buttonBack.Text = "INDIETRO";
            this.buttonBack.UseVisualStyleBackColor = false;
            this.buttonBack.Click += new System.EventHandler(this.buttonBack_Click);
            // 
            // iconBirthDate
            // 
            this.iconBirthDate.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.iconBirthDate.FlatAppearance.BorderSize = 0;
            this.iconBirthDate.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.iconBirthDate.IconChar = FontAwesome.Sharp.IconChar.CakeCandles;
            this.iconBirthDate.IconColor = System.Drawing.Color.Black;
            this.iconBirthDate.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.iconBirthDate.IconSize = 26;
            this.iconBirthDate.Location = new System.Drawing.Point(156, 93);
            this.iconBirthDate.Name = "iconBirthDate";
            this.iconBirthDate.Size = new System.Drawing.Size(28, 28);
            this.iconBirthDate.TabIndex = 65;
            this.iconBirthDate.UseVisualStyleBackColor = true;
            // 
            // dateBirthDate
            // 
            this.dateBirthDate.Location = new System.Drawing.Point(190, 95);
            this.dateBirthDate.Name = "dateBirthDate";
            this.dateBirthDate.Size = new System.Drawing.Size(200, 20);
            this.dateBirthDate.TabIndex = 8;
            // 
            // labelResult2
            // 
            this.labelResult2.AutoSize = true;
            this.labelResult2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelResult2.ForeColor = System.Drawing.Color.Gainsboro;
            this.labelResult2.Location = new System.Drawing.Point(228, 123);
            this.labelResult2.Name = "labelResult2";
            this.labelResult2.Size = new System.Drawing.Size(69, 15);
            this.labelResult2.TabIndex = 63;
            this.labelResult2.Text = "Credenziali";
            this.labelResult2.Visible = false;
            // 
            // iconButton1
            // 
            this.iconButton1.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.iconButton1.FlatAppearance.BorderSize = 0;
            this.iconButton1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.iconButton1.IconChar = FontAwesome.Sharp.IconChar.IdBadge;
            this.iconButton1.IconColor = System.Drawing.Color.Black;
            this.iconButton1.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.iconButton1.IconSize = 26;
            this.iconButton1.Location = new System.Drawing.Point(156, 37);
            this.iconButton1.Name = "iconButton1";
            this.iconButton1.Size = new System.Drawing.Size(28, 28);
            this.iconButton1.TabIndex = 62;
            this.iconButton1.UseVisualStyleBackColor = true;
            // 
            // textBoxName
            // 
            this.textBoxName.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(23)))), ((int)(((byte)(23)))), ((int)(((byte)(23)))));
            this.textBoxName.ForeColor = System.Drawing.SystemColors.InactiveCaption;
            this.textBoxName.Location = new System.Drawing.Point(190, 42);
            this.textBoxName.Name = "textBoxName";
            this.textBoxName.Size = new System.Drawing.Size(167, 20);
            this.textBoxName.TabIndex = 6;
            this.textBoxName.Text = "Nome";
            this.textBoxName.Enter += new System.EventHandler(this.textBoxName_Enter);
            this.textBoxName.Leave += new System.EventHandler(this.textBoxName_Leave);
            // 
            // iconSurname
            // 
            this.iconSurname.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.iconSurname.FlatAppearance.BorderSize = 0;
            this.iconSurname.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.iconSurname.IconChar = FontAwesome.Sharp.IconChar.IdBadge;
            this.iconSurname.IconColor = System.Drawing.Color.Black;
            this.iconSurname.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.iconSurname.IconSize = 26;
            this.iconSurname.Location = new System.Drawing.Point(156, 64);
            this.iconSurname.Name = "iconSurname";
            this.iconSurname.Size = new System.Drawing.Size(28, 28);
            this.iconSurname.TabIndex = 56;
            this.iconSurname.UseVisualStyleBackColor = true;
            // 
            // textBoxSurname
            // 
            this.textBoxSurname.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(23)))), ((int)(((byte)(23)))), ((int)(((byte)(23)))));
            this.textBoxSurname.ForeColor = System.Drawing.SystemColors.InactiveCaption;
            this.textBoxSurname.Location = new System.Drawing.Point(190, 69);
            this.textBoxSurname.Name = "textBoxSurname";
            this.textBoxSurname.Size = new System.Drawing.Size(167, 20);
            this.textBoxSurname.TabIndex = 7;
            this.textBoxSurname.Text = "Cognome";
            this.textBoxSurname.Enter += new System.EventHandler(this.textBoxSurname_Enter);
            this.textBoxSurname.Leave += new System.EventHandler(this.textBoxSurname_Leave);
            // 
            // pictureLogo
            // 
            this.pictureLogo.BackColor = System.Drawing.Color.Transparent;
            this.pictureLogo.Dock = System.Windows.Forms.DockStyle.Left;
            this.pictureLogo.Image = ((System.Drawing.Image)(resources.GetObject("pictureLogo.Image")));
            this.pictureLogo.Location = new System.Drawing.Point(0, 0);
            this.pictureLogo.Name = "pictureLogo";
            this.pictureLogo.Size = new System.Drawing.Size(126, 61);
            this.pictureLogo.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureLogo.TabIndex = 21;
            this.pictureLogo.TabStop = false;
            // 
            // FormRegister
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(575, 366);
            this.Controls.Add(this.panelRegister2);
            this.Controls.Add(this.panelRegister1);
            this.Controls.Add(this.panelBottonBar);
            this.Controls.Add(this.panelTitle);
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "FormRegister";
            this.Text = "FormRegister";
            this.panelTitle.ResumeLayout(false);
            this.panelBottonBar.ResumeLayout(false);
            this.panelBottonBar.PerformLayout();
            this.panelRegister1.ResumeLayout(false);
            this.panelRegister1.PerformLayout();
            this.panelRegister2.ResumeLayout(false);
            this.panelRegister2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureLogo)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panelTitle;
        private System.Windows.Forms.Panel panelBottonBar;
        private System.Windows.Forms.Label labelAlredyUser;
        private System.Windows.Forms.Button buttonLogin;
        private System.Windows.Forms.Panel panelRegister1;
        private FontAwesome.Sharp.IconButton showPassword;
        private System.Windows.Forms.TextBox textBoxPassword;
        private System.Windows.Forms.TextBox textBoxUsername;
        private FontAwesome.Sharp.IconButton iconEmail;
        private System.Windows.Forms.TextBox textBoxEmail;
        private FontAwesome.Sharp.IconButton iconPasswordConfirm;
        private FontAwesome.Sharp.IconButton showPasswordConfirm;
        private System.Windows.Forms.TextBox textBoxPasswordConfirm;
        private FontAwesome.Sharp.IconButton iconPassword;
        private FontAwesome.Sharp.IconButton iconUsername;
        private System.Windows.Forms.Button buttonForward;
        private System.Windows.Forms.Button buttonRegister;
        private System.Windows.Forms.Panel panelRegister2;
        private System.Windows.Forms.Label labelResult;
        private System.Windows.Forms.Label labelPage;
        private System.Windows.Forms.Label labelResult2;
        private FontAwesome.Sharp.IconButton iconButton1;
        private System.Windows.Forms.TextBox textBoxName;
        private FontAwesome.Sharp.IconButton iconSurname;
        private System.Windows.Forms.TextBox textBoxSurname;
        private FontAwesome.Sharp.IconButton buttonClose;
        private FontAwesome.Sharp.IconButton iconBirthDate;
        private System.Windows.Forms.DateTimePicker dateBirthDate;
        private System.Windows.Forms.Button buttonBack;
        private System.Windows.Forms.PictureBox pictureLogo;
    }
}