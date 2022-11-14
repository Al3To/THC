namespace Client.ServerForms
{
    partial class FormBlackjackGame
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormBlackjackGame));
            this.panelTitle = new System.Windows.Forms.Panel();
            this.panelBottom = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.labelBet = new System.Windows.Forms.Label();
            this.labelBalance = new System.Windows.Forms.Label();
            this.panelGame = new System.Windows.Forms.Panel();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.panelFiches = new System.Windows.Forms.Panel();
            this.pictureFiche1 = new System.Windows.Forms.PictureBox();
            this.pictureFiche5 = new System.Windows.Forms.PictureBox();
            this.pictureFiche10 = new System.Windows.Forms.PictureBox();
            this.pictureBox5 = new System.Windows.Forms.PictureBox();
            this.pictureFiche50 = new System.Windows.Forms.PictureBox();
            this.pictureFiche20 = new System.Windows.Forms.PictureBox();
            this.pictureFiche = new System.Windows.Forms.PictureBox();
            this.panelBottom.SuspendLayout();
            this.panelGame.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.panelFiches.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureFiche1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureFiche5)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureFiche10)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox5)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureFiche50)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureFiche20)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureFiche)).BeginInit();
            this.SuspendLayout();
            // 
            // panelTitle
            // 
            this.panelTitle.BackColor = System.Drawing.Color.Black;
            this.panelTitle.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelTitle.Location = new System.Drawing.Point(0, 0);
            this.panelTitle.Name = "panelTitle";
            this.panelTitle.Size = new System.Drawing.Size(1027, 54);
            this.panelTitle.TabIndex = 0;
            // 
            // panelBottom
            // 
            this.panelBottom.BackColor = System.Drawing.Color.Black;
            this.panelBottom.Controls.Add(this.panelFiches);
            this.panelBottom.Controls.Add(this.label1);
            this.panelBottom.Controls.Add(this.labelBet);
            this.panelBottom.Controls.Add(this.labelBalance);
            this.panelBottom.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panelBottom.Location = new System.Drawing.Point(0, 477);
            this.panelBottom.Name = "panelBottom";
            this.panelBottom.Size = new System.Drawing.Size(1027, 79);
            this.panelBottom.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.Gainsboro;
            this.label1.Location = new System.Drawing.Point(12, 50);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(118, 20);
            this.label1.TabIndex = 2;
            this.label1.Text = "Ultima Vincita:";
            // 
            // labelBet
            // 
            this.labelBet.AutoSize = true;
            this.labelBet.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelBet.ForeColor = System.Drawing.Color.Gainsboro;
            this.labelBet.Location = new System.Drawing.Point(12, 25);
            this.labelBet.Name = "labelBet";
            this.labelBet.Size = new System.Drawing.Size(71, 20);
            this.labelBet.TabIndex = 1;
            this.labelBet.Text = "Puntata:";
            // 
            // labelBalance
            // 
            this.labelBalance.AutoSize = true;
            this.labelBalance.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelBalance.ForeColor = System.Drawing.Color.Gainsboro;
            this.labelBalance.Location = new System.Drawing.Point(12, 3);
            this.labelBalance.Name = "labelBalance";
            this.labelBalance.Size = new System.Drawing.Size(56, 20);
            this.labelBalance.TabIndex = 0;
            this.labelBalance.Text = "Saldo:";
            // 
            // panelGame
            // 
            this.panelGame.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("panelGame.BackgroundImage")));
            this.panelGame.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.panelGame.Controls.Add(this.pictureBox1);
            this.panelGame.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelGame.Location = new System.Drawing.Point(0, 54);
            this.panelGame.Name = "panelGame";
            this.panelGame.Size = new System.Drawing.Size(1027, 423);
            this.panelGame.TabIndex = 2;
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackColor = System.Drawing.Color.Transparent;
            this.pictureBox1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(0, 0);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(1027, 423);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // panelFiches
            // 
            this.panelFiches.Controls.Add(this.pictureFiche);
            this.panelFiches.Controls.Add(this.pictureBox5);
            this.panelFiches.Controls.Add(this.pictureFiche50);
            this.panelFiches.Controls.Add(this.pictureFiche20);
            this.panelFiches.Controls.Add(this.pictureFiche10);
            this.panelFiches.Controls.Add(this.pictureFiche5);
            this.panelFiches.Controls.Add(this.pictureFiche1);
            this.panelFiches.Location = new System.Drawing.Point(245, 12);
            this.panelFiches.Name = "panelFiches";
            this.panelFiches.Size = new System.Drawing.Size(563, 64);
            this.panelFiches.TabIndex = 4;
            // 
            // pictureFiche1
            // 
            this.pictureFiche1.Location = new System.Drawing.Point(73, 7);
            this.pictureFiche1.Name = "pictureFiche1";
            this.pictureFiche1.Size = new System.Drawing.Size(58, 50);
            this.pictureFiche1.TabIndex = 0;
            this.pictureFiche1.TabStop = false;
            // 
            // pictureFiche5
            // 
            this.pictureFiche5.Location = new System.Drawing.Point(149, 7);
            this.pictureFiche5.Name = "pictureFiche5";
            this.pictureFiche5.Size = new System.Drawing.Size(58, 50);
            this.pictureFiche5.TabIndex = 1;
            this.pictureFiche5.TabStop = false;
            // 
            // pictureFiche10
            // 
            this.pictureFiche10.Location = new System.Drawing.Point(229, 7);
            this.pictureFiche10.Name = "pictureFiche10";
            this.pictureFiche10.Size = new System.Drawing.Size(58, 50);
            this.pictureFiche10.TabIndex = 2;
            this.pictureFiche10.TabStop = false;
            // 
            // pictureBox5
            // 
            this.pictureBox5.Location = new System.Drawing.Point(465, 7);
            this.pictureBox5.Name = "pictureBox5";
            this.pictureBox5.Size = new System.Drawing.Size(58, 50);
            this.pictureBox5.TabIndex = 5;
            this.pictureBox5.TabStop = false;
            // 
            // pictureFiche50
            // 
            this.pictureFiche50.Location = new System.Drawing.Point(383, 7);
            this.pictureFiche50.Name = "pictureFiche50";
            this.pictureFiche50.Size = new System.Drawing.Size(58, 50);
            this.pictureFiche50.TabIndex = 4;
            this.pictureFiche50.TabStop = false;
            // 
            // pictureFiche20
            // 
            this.pictureFiche20.Location = new System.Drawing.Point(308, 7);
            this.pictureFiche20.Name = "pictureFiche20";
            this.pictureFiche20.Size = new System.Drawing.Size(58, 50);
            this.pictureFiche20.TabIndex = 3;
            this.pictureFiche20.TabStop = false;
            // 
            // pictureFiche
            // 
            this.pictureFiche.Location = new System.Drawing.Point(0, 7);
            this.pictureFiche.Name = "pictureFiche";
            this.pictureFiche.Size = new System.Drawing.Size(58, 50);
            this.pictureFiche.TabIndex = 6;
            this.pictureFiche.TabStop = false;
            // 
            // FormBlackjackGame1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.ClientSize = new System.Drawing.Size(1027, 556);
            this.Controls.Add(this.panelGame);
            this.Controls.Add(this.panelBottom);
            this.Controls.Add(this.panelTitle);
            this.Name = "FormBlackjackGame1";
            this.Text = "FormBlackJack1";
            this.Load += new System.EventHandler(this.FormBlackjackGame1_Load);
            this.panelBottom.ResumeLayout(false);
            this.panelBottom.PerformLayout();
            this.panelGame.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.panelFiches.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureFiche1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureFiche5)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureFiche10)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox5)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureFiche50)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureFiche20)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureFiche)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panelTitle;
        private System.Windows.Forms.Panel panelBottom;
        private System.Windows.Forms.Label labelBalance;
        private System.Windows.Forms.Panel panelGame;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label labelBet;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Panel panelFiches;
        private System.Windows.Forms.PictureBox pictureFiche;
        private System.Windows.Forms.PictureBox pictureBox5;
        private System.Windows.Forms.PictureBox pictureFiche50;
        private System.Windows.Forms.PictureBox pictureFiche20;
        private System.Windows.Forms.PictureBox pictureFiche10;
        private System.Windows.Forms.PictureBox pictureFiche5;
        private System.Windows.Forms.PictureBox pictureFiche1;
    }
}