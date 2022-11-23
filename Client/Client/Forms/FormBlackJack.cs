using Client.ServerForms;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Client.Forms
{
    public partial class FormBlackJack : Form
    {
        string username;
        public FormBlackJack(string username)
        {
            InitializeComponent();
            this.username = username;
        }

        private void pictureBoxServer1_Click(object sender, EventArgs e)
        {
            FormBlackjackGame formBlackjackGame1 = new FormBlackjackGame(username);
            formBlackjackGame1.ShowDialog();
            
        }
    }
}
