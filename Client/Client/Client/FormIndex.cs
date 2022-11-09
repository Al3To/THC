using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Client
{
    public partial class FormIndex : Form
    {
        bool loggedIn = false;
        public FormIndex()
        {
            InitializeComponent();
        }
        //Login Button
        private void buttonLogin_MouseLeave(object sender, EventArgs e)
        {
            buttonLogin.BackColor = Color.FromArgb(23, 23, 23);
            buttonLogin.ForeColor = Color.FromArgb(127, 248, 3);
        }

        private void buttonLogin_MouseEnter(object sender, EventArgs e)
        {
            buttonLogin.BackColor = Color.FromArgb(127, 248, 3);
            buttonLogin.ForeColor = Color.FromArgb(23, 23, 23);
        }

        private void buttonLoginProfile_MouseEnter(object sender, EventArgs e)
        {
            buttonLoginProfile.BackColor = Color.FromArgb(127, 248, 3);
            buttonLoginProfile.ForeColor = Color.FromArgb(23, 23, 23);
        }

        private void buttonLoginProfile_MouseLeave(object sender, EventArgs e)
        {
            buttonLoginProfile.BackColor = Color.FromArgb(23, 23, 23);
            buttonLoginProfile.ForeColor = Color.FromArgb(127, 248, 3);
        }

        private void pictureClose_Click(object sender, EventArgs e)
        {
            Environment.Exit(0);
        }

        private void pictureMaximize_Click(object sender, EventArgs e)
        {

        }

        private void pictureMinimize_Click(object sender, EventArgs e)
        {

        }
        private void FormIndex_Resize(object sender, EventArgs e)
        {
            if (this.WindowState != FormWindowState.Maximized)
                FormBorderStyle = FormBorderStyle.Sizable;
            else
                FormBorderStyle = FormBorderStyle.None;
        }
    }
    class User
    {
        string mail;
        string username;
        string password;
        float balance;
    }
}
