using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Client.Forms
{
    public partial class FormLogin : Form
    {
        string[] username;
        string[] password;
        public FormLogin()
        {
            InitializeComponent();
            StartPosition = FormStartPosition.CenterScreen;
            this.Text = string.Empty;
            this.ControlBox = false;
        }
        private void FormLogin_Load(object sender, EventArgs e)
        {

        }
        private void buttonLogin_Click(object sender, EventArgs e)
        {

        }
        private void buttonRegister_Click(object sender, EventArgs e)
        {
            this.DialogResult = DialogResult.Retry;
            this.Close();           
        }
        private void buttonClose_Click(object sender, EventArgs e)
        {
            this.DialogResult = DialogResult.No;
            this.Close();
        }
        private void textBoxUsername_Enter(object sender, EventArgs e)
        {
            if (textBoxUsername.Text == "Nome Utente")
            {
                textBoxUsername.Text = "";
                textBoxUsername.ForeColor = Color.FromArgb(225,225,225); ;
            }
        }

        private void textBoxUsername_Leave(object sender, EventArgs e)
        {
            if (textBoxUsername.Text == "")
            {
                textBoxUsername.Text = "Nome Utente";
                textBoxUsername.ForeColor = Color.FromArgb(191, 205, 219);
            }
        }

        private void textBoxPassword_Enter(object sender, EventArgs e)
        {
            if (textBoxPassword.Text == "Password")
            {
                textBoxPassword.Text = "";
                textBoxPassword.PasswordChar = '●';
                textBoxPassword.ForeColor = Color.FromArgb(225,225,225);
            }
        }

        private void textBoxPassword_Leave(object sender, EventArgs e)
        {
            if (textBoxPassword.Text == "")
            {
                textBoxPassword.PasswordChar = '\0';
                textBoxPassword.Text = "Password";
                textBoxPassword.ForeColor = Color.FromArgb(191, 205, 219);
            }
        }
        private void showPassword_Click(object sender, EventArgs e)
        {
            if (textBoxPassword.PasswordChar == '●')
            {
                textBoxPassword.PasswordChar = '\0';
                showPassword.IconChar = FontAwesome.Sharp.IconChar.EyeSlash;
            }
            else
            {
                textBoxPassword.PasswordChar = '●';
                showPassword.IconChar = FontAwesome.Sharp.IconChar.Eye;
            }
        }

        //Move Form
        [DllImport("user32.DLL", EntryPoint = "ReleaseCapture")]
        private extern static void ReleaseCapture();
        [DllImport("user32.DLL", EntryPoint = "SendMessage")]
        private extern static void SendMessage(System.IntPtr hWnd, int wMsg, int wParam, int lParam);
        private void panelTitle_MouseDown(object sender, MouseEventArgs e)
        {
                    ReleaseCapture();
                    SendMessage(this.Handle, 0x112, 0xf012, 0);
        }

        private void textBoxPassword_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                buttonLogin.PerformClick();
                e.Handled = true;
                e.SuppressKeyPress = true;
            }
        }
    }
}
