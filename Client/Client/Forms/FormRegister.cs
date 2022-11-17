using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Net.Sockets;
using System.Net;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Runtime.InteropServices;
using System.Windows.Markup;
using System.Threading;

namespace Client.Forms
{
    public partial class FormRegister : Form
    {
        public static IPAddress ipAddress = IPAddress.Parse("127.0.0.1");
        IPEndPoint remoteEP = new IPEndPoint(ipAddress, 8888);
        Socket socket;

        public static string username, email, balance;
        string password, name, surname, DOB;
        public FormRegister()
        {
            InitializeComponent();
            StartPosition = FormStartPosition.CenterScreen;
            this.Text = string.Empty;
            this.ControlBox = false;
        }

        private void buttonForward_Click(object sender, EventArgs e)
        {
            email = textBoxEmail.Text;
            username = textBoxUsername.Text;
            password = textBoxPassword.Text;
            if(!IsValidEmail(textBoxEmail.Text) || textBoxUsername.Text == "" || textBoxPassword.Text == "" || textBoxPassword.Text != textBoxPasswordConfirm.Text || textBoxUsername.Text == "Nome Utente" || textBoxPassword.Text == "Password")
            {
                labelResult.Text = "Credenziali non valide";
                labelResult.ForeColor = Color.Red;
                labelResult.Visible = true;
            }
            else
            {
                panelRegister1.Visible = false;
                panelRegister2.Visible = true;
            }
        }
        private void buttonRegister_Click(object sender, EventArgs e)
        {
            buttonRegister.Enabled = false;
            name = textBoxName.Text;
            surname = textBoxSurname.Text;
            DOB = dateBirthDate.Value.ToString("dd-MM-yyyy");
            if (textBoxName.Text == "" || textBoxSurname.Text == "" || !isAdult(dateBirthDate))
            {
                labelResult2.Text = "Credenziali non valide";
                labelResult2.ForeColor = Color.Red;
                labelResult2.Visible = true;
                buttonRegister.Enabled = true;
            }
            else
            {
                byte[] bytes = new byte[1024];
                byte[] toSend;
                string data = null;
                socket = new Socket(ipAddress.AddressFamily, SocketType.Stream, ProtocolType.Tcp);
                socket.Connect(remoteEP);
                toSend = Encoding.ASCII.GetBytes("\nregister;" + username + ";" + password + ";" + email + ";" + name + ";" + surname + ";" + DOB + "/s/");
                socket.Send(toSend);
                int bytesRec = socket.Receive(bytes);
                data += Encoding.ASCII.GetString(bytes, 0, bytesRec);
                if (data.EndsWith("/c/"))
                {
                    if (data == "alredyUsed/c/")
                    {
                        labelResult2.Text = "Mail già in uso";
                        labelResult2.ForeColor = Color.Red;
                        labelResult2.Visible = true;
                        toSend = Encoding.ASCII.GetBytes("Disconnect/s/");
                        socket.Send(toSend);
                        socket.Shutdown(SocketShutdown.Both);
                        socket.Close();
                        buttonRegister.Enabled = true;
                    }
                    else
                    {
                        labelResult.ForeColor = Color.Gainsboro;
                        labelResult.Text = "Accesso Eseguito!";
                        labelResult.Visible = true;
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

        bool isAdult(DateTimePicker dateTime)
        {
            string[] date = dateTime.Value.ToString("dd-MM-yyyy").Split('-');
            string[] currentDate = DateTime.Today.ToString("dd-MM-yyyy").Split('-');
            if (Convert.ToInt32(currentDate[2]) - Convert.ToInt32(date[2]) > 18) return true;
            if (Convert.ToInt32(currentDate[2]) - Convert.ToInt32(date[2]) == 18)
                if (Convert.ToInt32(currentDate[1]) - Convert.ToInt32(date[1]) > 0)
                    return true;
                else if (Convert.ToInt32(currentDate[1]) - Convert.ToInt32(date[1]) < 0) return false;
                else if (Convert.ToInt32(currentDate[1]) - Convert.ToInt32(date[1]) == 0)
                    if (Convert.ToInt32(currentDate[0]) - Convert.ToInt32(date[0]) >= 0) return true;
            return false;
        }
        bool IsValidEmail(string email)
        {
            var trimmedEmail = email.Trim();

            if (trimmedEmail.EndsWith("."))
            {
                return false; 
            }
            try
            {
                var addr = new System.Net.Mail.MailAddress(email);
                return addr.Address == trimmedEmail;
            }
            catch
            {
                return false;
            }
        }
        //Controls
        private void buttonLogin_Click(object sender, EventArgs e)
        {
            this.DialogResult = DialogResult.Retry;
            this.Close();
        }

        private void buttonClose_Click(object sender, EventArgs e)
        {
            this.DialogResult = DialogResult.No;
            this.Close();
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

        private void showPasswordConfirm_Click(object sender, EventArgs e)
        {
            if (textBoxPasswordConfirm.PasswordChar == '●')
            {
                textBoxPasswordConfirm.PasswordChar = '\0';
                showPasswordConfirm.IconChar = FontAwesome.Sharp.IconChar.EyeSlash;

            }
            else
            {
                textBoxPasswordConfirm.PasswordChar = '●';
                showPasswordConfirm.IconChar = FontAwesome.Sharp.IconChar.Eye;
            }
        }

        private void textBoxEmail_Enter(object sender, EventArgs e)
        {
            if (textBoxEmail.Text == "Email")
            {
                textBoxEmail.Text = "";
                textBoxEmail.ForeColor = Color.FromArgb(225, 225, 225); ;
            }
        }

        private void textBoxEmail_Leave(object sender, EventArgs e)
        {
            if (textBoxEmail.Text == "")
            {
                textBoxEmail.Text = "Email";
                textBoxEmail.ForeColor = Color.FromArgb(191, 205, 219);
            }
        }
        private void textBoxUsername_Enter(object sender, EventArgs e)
        {
            if (textBoxUsername.Text == "Nome Utente")
            {
                textBoxUsername.Text = "";
                textBoxUsername.ForeColor = Color.FromArgb(225, 225, 225); ;
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
                textBoxPassword.ForeColor = Color.FromArgb(225, 225, 225);
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

        private void buttonBack_Click(object sender, EventArgs e)
        {
            panelRegister1.Visible = true;
            panelRegister2.Visible = false;
        }

        private void textBoxName_Leave(object sender, EventArgs e)
        {
            if (textBoxName.Text == "")
            {
                textBoxName.Text = "Nome";
                textBoxName.ForeColor = Color.FromArgb(191, 205, 219);
            }
        }

        private void textBoxName_Enter(object sender, EventArgs e)
        {
            if (textBoxName.Text == "Nome")
            {
                textBoxName.Text = "";
                textBoxName.ForeColor = Color.FromArgb(225, 225, 225); ;
            }
        }

        private void textBoxSurname_Leave(object sender, EventArgs e)
        {
            if (textBoxSurname.Text == "")
            {
                textBoxSurname.Text = "Cognome";
                textBoxSurname.ForeColor = Color.FromArgb(191, 205, 219);
            }
        }

        private void textBoxSurname_Enter(object sender, EventArgs e)
        {
            if (textBoxSurname.Text == "Cognome")
            {
                textBoxSurname.Text = "";
                textBoxSurname.ForeColor = Color.FromArgb(225, 225, 225); ;
            }
        }

        private void textBoxPasswordConfirm_Enter(object sender, EventArgs e)
        {
            if (textBoxPasswordConfirm.Text == "Conferma Password")
            {
                textBoxPasswordConfirm.Text = "";
                textBoxPasswordConfirm.PasswordChar = '●';
                textBoxPasswordConfirm.ForeColor = Color.FromArgb(225, 225, 225);
            }
        }

        private void textBoxPasswordConfirm_Leave(object sender, EventArgs e)
        {
            if (textBoxPasswordConfirm.Text == "")
            {
                textBoxPasswordConfirm.PasswordChar = '\0';
                textBoxPasswordConfirm.Text = "Conferma Password";
                textBoxPasswordConfirm.ForeColor = Color.FromArgb(191, 205, 219);
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
    }
}
