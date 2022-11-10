namespace Client.Forms
{
    partial class FormBlackJack
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormBlackJack));
            this.pictureBoxServer1 = new System.Windows.Forms.PictureBox();
            this.label1 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxServer1)).BeginInit();
            this.SuspendLayout();
            // 
            // pictureBoxServer1
            // 
            this.pictureBoxServer1.Cursor = System.Windows.Forms.Cursors.Hand;
            this.pictureBoxServer1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBoxServer1.Image")));
            this.pictureBoxServer1.Location = new System.Drawing.Point(12, 12);
            this.pictureBoxServer1.Name = "pictureBoxServer1";
            this.pictureBoxServer1.Size = new System.Drawing.Size(235, 130);
            this.pictureBoxServer1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBoxServer1.TabIndex = 0;
            this.pictureBoxServer1.TabStop = false;
            this.pictureBoxServer1.Click += new System.EventHandler(this.pictureBoxServer1_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.Gainsboro;
            this.label1.Location = new System.Drawing.Point(77, 149);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(111, 20);
            this.label1.TabIndex = 1;
            this.label1.Text = "BlackJack - 1";
            // 
            // FormBlackJack
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(37)))), ((int)(((byte)(37)))), ((int)(((byte)(37)))));
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.pictureBoxServer1);
            this.Name = "FormBlackJack";
            this.Text = "FormBlackJack";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxServer1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBoxServer1;
        private System.Windows.Forms.Label label1;
    }
}