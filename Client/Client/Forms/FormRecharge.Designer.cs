namespace Client.Forms
{
    partial class FormRecharge
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormRecharge));
            this.panel2 = new System.Windows.Forms.Panel();
            this.labelRecharge = new System.Windows.Forms.Label();
            this.iconUsername = new FontAwesome.Sharp.IconButton();
            this.textBoxRecharge = new System.Windows.Forms.TextBox();
            this.buttonRecharge = new System.Windows.Forms.Button();
            this.panelTitle = new System.Windows.Forms.Panel();
            this.pictureLogo = new System.Windows.Forms.PictureBox();
            this.buttonClose = new FontAwesome.Sharp.IconButton();
            this.panel2.SuspendLayout();
            this.panelTitle.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureLogo)).BeginInit();
            this.SuspendLayout();
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(23)))), ((int)(((byte)(23)))), ((int)(((byte)(23)))));
            this.panel2.Controls.Add(this.labelRecharge);
            this.panel2.Controls.Add(this.iconUsername);
            this.panel2.Controls.Add(this.textBoxRecharge);
            this.panel2.Controls.Add(this.buttonRecharge);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel2.Location = new System.Drawing.Point(0, 61);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(406, 389);
            this.panel2.TabIndex = 3;
            // 
            // labelRecharge
            // 
            this.labelRecharge.AutoSize = true;
            this.labelRecharge.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelRecharge.ForeColor = System.Drawing.Color.Gainsboro;
            this.labelRecharge.Location = new System.Drawing.Point(160, 124);
            this.labelRecharge.Name = "labelRecharge";
            this.labelRecharge.Size = new System.Drawing.Size(86, 20);
            this.labelRecharge.TabIndex = 44;
            this.labelRecharge.Text = "IMPORTO:";
            // 
            // iconUsername
            // 
            this.iconUsername.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.iconUsername.FlatAppearance.BorderSize = 0;
            this.iconUsername.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.iconUsername.IconChar = FontAwesome.Sharp.IconChar.Eur;
            this.iconUsername.IconColor = System.Drawing.Color.Gainsboro;
            this.iconUsername.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.iconUsername.IconSize = 26;
            this.iconUsername.Location = new System.Drawing.Point(93, 155);
            this.iconUsername.Name = "iconUsername";
            this.iconUsername.Size = new System.Drawing.Size(28, 30);
            this.iconUsername.TabIndex = 43;
            this.iconUsername.UseVisualStyleBackColor = true;
            // 
            // textBoxRecharge
            // 
            this.textBoxRecharge.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(23)))), ((int)(((byte)(23)))), ((int)(((byte)(23)))));
            this.textBoxRecharge.ForeColor = System.Drawing.SystemColors.InactiveCaption;
            this.textBoxRecharge.Location = new System.Drawing.Point(127, 161);
            this.textBoxRecharge.Name = "textBoxRecharge";
            this.textBoxRecharge.Size = new System.Drawing.Size(151, 20);
            this.textBoxRecharge.TabIndex = 10;
            this.textBoxRecharge.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.textBoxRecharge_KeyPress);
            // 
            // buttonRecharge
            // 
            this.buttonRecharge.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(23)))), ((int)(((byte)(23)))), ((int)(((byte)(23)))));
            this.buttonRecharge.Cursor = System.Windows.Forms.Cursors.Hand;
            this.buttonRecharge.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonRecharge.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonRecharge.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(30)))));
            this.buttonRecharge.Location = new System.Drawing.Point(150, 207);
            this.buttonRecharge.Margin = new System.Windows.Forms.Padding(2);
            this.buttonRecharge.Name = "buttonRecharge";
            this.buttonRecharge.Size = new System.Drawing.Size(96, 29);
            this.buttonRecharge.TabIndex = 9;
            this.buttonRecharge.Text = "RICARICA";
            this.buttonRecharge.UseVisualStyleBackColor = false;
            this.buttonRecharge.Click += new System.EventHandler(this.buttonRecharge_Click);
            // 
            // panelTitle
            // 
            this.panelTitle.BackColor = System.Drawing.Color.Black;
            this.panelTitle.Controls.Add(this.pictureLogo);
            this.panelTitle.Controls.Add(this.buttonClose);
            this.panelTitle.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelTitle.Location = new System.Drawing.Point(0, 0);
            this.panelTitle.Name = "panelTitle";
            this.panelTitle.Size = new System.Drawing.Size(406, 61);
            this.panelTitle.TabIndex = 2;
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
            this.pictureLogo.TabIndex = 20;
            this.pictureLogo.TabStop = false;
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
            this.buttonClose.Location = new System.Drawing.Point(366, 15);
            this.buttonClose.Name = "buttonClose";
            this.buttonClose.Size = new System.Drawing.Size(34, 40);
            this.buttonClose.TabIndex = 42;
            this.buttonClose.UseVisualStyleBackColor = true;
            this.buttonClose.Click += new System.EventHandler(this.buttonClose_Click);
            // 
            // FormRecharge
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(406, 450);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panelTitle);
            this.Name = "FormRecharge";
            this.Text = "FormRecharge";
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.panelTitle.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureLogo)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Panel panelTitle;
        private System.Windows.Forms.PictureBox pictureLogo;
        private FontAwesome.Sharp.IconButton buttonClose;
        private System.Windows.Forms.Button buttonRecharge;
        private System.Windows.Forms.TextBox textBoxRecharge;
        private System.Windows.Forms.Label labelRecharge;
        private FontAwesome.Sharp.IconButton iconUsername;
    }
}