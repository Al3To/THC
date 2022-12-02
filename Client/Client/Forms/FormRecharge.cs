using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Forms;

namespace Client.Forms
{
    public partial class FormRecharge : Form
    {
        public float recharge;
        public FormRecharge()
        {
            InitializeComponent();
            StartPosition = FormStartPosition.CenterScreen;
            this.Text = string.Empty;
            this.ControlBox = false;
        }

        private void buttonClose_Click(object sender, EventArgs e)
        {
            DialogResult = DialogResult.Cancel;
            this.Close();
        }

        private void buttonRecharge_Click(object sender, EventArgs e)
        {
            MessageBoxResult mr = System.Windows.MessageBox.Show("Confermare la ricarica?", "Conferma");
            if(mr == MessageBoxResult.OK) 
            {
                recharge = Convert.ToInt32(textBoxRecharge.Text);
                DialogResult = DialogResult.OK;
                this.Close();
            }
        }

        private void textBoxRecharge_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar))
                e.Handled = true;
        }
    }
}
