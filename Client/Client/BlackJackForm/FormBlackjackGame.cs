using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Client.ServerForms
{
    public partial class FormBlackjackGame : Form
    {
        public FormBlackjackGame()
        {
            InitializeComponent();
            this.Text = string.Empty;
            this.ControlBox = false;
            this.DoubleBuffered = true;
            this.WindowState = FormWindowState.Maximized;
        }

        private void FormBlackjackGame1_Load(object sender, EventArgs e)
        {
            //Connection
        }
    }
}
