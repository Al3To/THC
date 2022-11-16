using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Net.Sockets;
using System.Net;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Windows.Markup;
using System.Threading;

namespace Client.Forms
{
    public partial class FormLogin : Form
    {
        public static string username, role,mail,balance;
        public static IPAddress ipAddress = IPAddress.Parse("127.0.0.1");
        IPEndPoint remoteEP = new IPEndPoint(ipAddress, 8888);
        Socket socket;
        int trys = 0;
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
            if(textBoxUsername.Text == "" || textBoxPassword.Text == "" || textBoxUsername.Text == "Nome Utente" || textBoxPassword.Text == "Password")
            {
                labelResult.ForeColor = Color.Red;
                labelResult.Text = "Credenziali non valide!";
                labelResult.Visible = true;
                textBoxUsername.Focus();
            }
            else
            {
                string data = null, password;
                string[] split;
                byte[] bytes = new byte[1024];
                byte[] toSend;

                username = textBoxUsername.Text;
                password = textBoxPassword.Text;


                socket = new Socket(ipAddress.AddressFamily, SocketType.Stream, ProtocolType.Tcp);
                socket.Connect(remoteEP);

                toSend = Encoding.ASCII.GetBytes("login;" + username + ";" + password +"/s/");
                socket.Send(toSend);
                int bytesRec = socket.Receive(bytes);
                data += Encoding.ASCII.GetString(bytes, 0, bytesRec);
                if (data.EndsWith("/c/"))
                {
                    if (data == "none/c/")
                    {
                        labelResult.ForeColor = Color.Red;
                        labelResult.Text = "Credenziali non valide!";
                        labelResult.Visible = true;
                        trys++;
                        textBoxUsername.Focus();
                        toSend = Encoding.ASCII.GetBytes("Disconnect/s/");
                        socket.Send(toSend);
                        socket.Shutdown(SocketShutdown.Both);
                        socket.Close();
                    }
                    else
                    {
                        labelResult.ForeColor = Color.Gainsboro;
                        labelResult.Text = "Accesso Eseguito!";
                        labelResult.Visible = true;
                        data = data.Remove(data.Length - 1);
                        data = data.Remove(data.Length - 1);
                        data = data.Remove(data.Length - 1);
                        split = data.Split(';');
                        role = split[0];
                        mail = split[1];
                        balance = split[2];
                        buttonLogin.Enabled = false;
                        toSend = Encoding.ASCII.GetBytes("Disconnect/s/");
                        socket.Send(toSend);
                        socket.Shutdown(SocketShutdown.Both);
                        socket.Close();
                        Thread.Sleep(1000);
                        this.DialogResult = DialogResult.OK;
                        this.Close();
                    }
                }
            }
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
