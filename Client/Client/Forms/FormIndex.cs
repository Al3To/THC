using Client.Forms;
using Client.ServerForms;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Forms;
using System.Threading;
using System.Net.Sockets;
using System.Net;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.StartPanel;
using System.Windows.Markup;

namespace Client
{
    public partial class Client : Form
    {
        public static IPAddress ipAddress = IPAddress.Parse("127.0.0.1");
        IPEndPoint remoteEP = new IPEndPoint(ipAddress, 8888);
        Socket socket;
        static public bool loggedIn = false;
        private Form currentChildForm;
        User user;
        public Client()
        {
            InitializeComponent();
            StartPosition = FormStartPosition.CenterScreen;
            this.Text = string.Empty;
            this.ControlBox = false;
            this.DoubleBuffered = true;
            this.Icon = new Icon("../../../icon.ico");
            timer1.Start();

        }

        private void userAdmin()
        {

        }
        void UpdateBalance()
        {
            while (true)
            {
                user.balance = Program.balance;
                labelBalance.Text = "Credito: " + user.balance.ToString();
            }
        }
        //Child Forms
        private void OpenChildForm(Form childForm)
        {
            if (currentChildForm != null)
            {
                //Open only one form
                currentChildForm.Close();
            }
            currentChildForm = childForm;
            childForm.TopLevel = false;
            childForm.FormBorderStyle = FormBorderStyle.None;
            childForm.Dock = DockStyle.Fill;
            panelDesktop.Controls.Add(childForm);
            panelDesktop.Tag = childForm;
            childForm.BringToFront();
            childForm.Show();
        }


        //Buttons
        private void buttonHome_Click(object sender, EventArgs e)
        {
            if (currentChildForm != null)
            {
                currentChildForm.Close();
                currentChildForm=null;
            }
        }
        private void buttonBJ_Click(object sender, EventArgs e)
        {
            if (!loggedIn)
                System.Windows.MessageBox.Show("Devi creare un account o accedere ad uno esistente prima di poter giocare!", "Errore!", MessageBoxButton.OK);
            else
            {
                Thread t = new Thread(UpdateBalance);
                t.Start();
                OpenChildForm(new FormBlackJack(user.username, user.balance));
            }
        }
        private void buttonLogin_Click(object sender, EventArgs e)
        {
            FormLogin formLogin = new FormLogin();
            var result = formLogin.ShowDialog();
            if (result == DialogResult.Retry)
                buttonRegister_Click(this, e);
            else if(result == DialogResult.OK)
            {
                user = new User();
                user.username = FormLogin.username;
                user.mail = FormLogin.mail;
                user.balance = float.Parse(FormLogin.balance);
                Program.balance = user.balance;
                if(FormLogin.role == "admin")
                {
                    user.admin = true;
                    userAdmin();
                }
                buttonLogin.Visible = false;
                buttonRegister.Visible = false;
                buttonLoginProfile.Visible = false;
                labelUsername.Text = user.username;
                labelUsername.Visible = true;
                labelBalance.Text = "Credito: " + user.balance.ToString();
                labelBalance.Visible = true;
                loggedIn = true;
                buttonRecharge.Visible = true;
            }
        }
        private void buttonRegister_Click(object sender, EventArgs e)
        {
            FormRegister formRegister = new FormRegister();
            var result = formRegister.ShowDialog();
            if (result == DialogResult.Retry)
                buttonLogin_Click(this, e);
            else if(result == DialogResult.OK)
            {
                user = new User();
                user.username = FormRegister.username;
                user.mail = FormRegister.email;
                user.balance = 0;
                buttonLogin.Visible = false;
                buttonRegister.Visible = false;
                buttonLoginProfile.Visible = false;
                labelUsername.Text = user.username;
                labelUsername.Visible = true;
                labelBalance.Text = "Credito: " + user.balance.ToString();
                labelBalance.Visible = true;
                loggedIn = true;
            }
        }
        private void buttonLoginProfile_Click(object sender, EventArgs e)
        {
            buttonLogin_Click(this, e);
        }
        //Buttons Color
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
        private void buttonRegister_MouseEnter(object sender, EventArgs e)
        {
            buttonRegister.BackColor = Color.Black;
            buttonRegister.ForeColor = Color.FromArgb(252, 228, 3);
        }

        private void buttonRegister_MouseLeave(object sender, EventArgs e)
        {
            buttonRegister.BackColor = Color.FromArgb(252, 228, 3);
            buttonRegister.ForeColor = Color.Black;
        }
        //Window Controls
        private void pictureClose_Click(object sender, EventArgs e)
        {
            Environment.Exit(0);
        }

        private void pictureMaximize_Click(object sender, EventArgs e)
        {
            if (this.WindowState == FormWindowState.Maximized)
            {
                FormBorderStyle = FormBorderStyle.Sizable;
                this.WindowState = FormWindowState.Normal;
            }
            else
            {
                FormBorderStyle = FormBorderStyle.None;
                this.MaximizedBounds = Screen.FromHandle(this.Handle).WorkingArea;
                this.WindowState = FormWindowState.Maximized;
            }
        }

        private void pictureMinimize_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }

        private void Client_Resize(object sender, EventArgs e)
        {
            if (this.WindowState != FormWindowState.Maximized)
                FormBorderStyle = FormBorderStyle.Sizable;
            else
                FormBorderStyle = FormBorderStyle.None;
        }
        //Move Form
        [DllImport("user32.DLL", EntryPoint = "ReleaseCapture")]
        private extern static void ReleaseCapture();
        [DllImport("user32.DLL", EntryPoint = "SendMessage")]
        private extern static void SendMessage(System.IntPtr hWnd, int wMsg, int wParam, int lParam);

        private void panelTitle_MouseDown(object sender, MouseEventArgs e)
        {
            base.OnMouseDown(e);

            if (e.Button == MouseButtons.Left)
                if (e.Clicks > 1)
                    pictureMaximize_Click(this.pictureMaximize, e);
                else
                {
                    FormBorderStyle = FormBorderStyle.Sizable;
                    ReleaseCapture();
                    SendMessage(this.Handle, 0x112, 0xf012, 0);
                }
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            labelTime.Text = DateTime.Now.ToString("T");
            labelDate.Text = DateTime.Now.ToString("dddd" + "," + " d" + " MMMM" + "," + "yyyy");
        }

        private void buttonRecharge_Click(object sender, EventArgs e)
        {
            FormRecharge formRecharge = new FormRecharge();
            DialogResult dr = formRecharge.ShowDialog();
            if(dr == DialogResult.OK)
            {
                string data = null;
                byte[] bytes = new byte[1024];
                socket = new Socket(ipAddress.AddressFamily, SocketType.Stream, ProtocolType.Tcp);
                socket.Connect(remoteEP);
                byte[] toSend = Encoding.ASCII.GetBytes("recharge;" + user.username +";"+(formRecharge.recharge + user.balance).ToString()+ "/s/");
                socket.Send(toSend);
                int bytesRec = socket.Receive(bytes);
                data += Encoding.ASCII.GetString(bytes, 0, bytesRec);
                if (data == "rechargeOK/c/")
                {
                    user.balance += formRecharge.recharge;
                    labelBalance.Text = "Credito: €" + user.balance.ToString();
                    Program.balance = user.balance;
                    System.Windows.MessageBox.Show("Ricarica effettuata con successo!");
                    socket.Close();
                }
                else
                {
                    System.Windows.MessageBox.Show("C'è stato un'errore nella tua ricarica, riprova!", "Errore!");
                    socket.Close();
                }
            }
        }
    }
    class User
    {
        public string mail;
        public string username;
        public float balance;
        public bool admin;
        Image propic;
    }
}
