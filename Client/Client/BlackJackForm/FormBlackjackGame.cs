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
using static System.Windows.Forms.VisualStyles.VisualStyleElement.StartPanel;
using System.Windows.Markup;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;
using System.Threading;

namespace Client.ServerForms
{
    public partial class FormBlackjackGame : Form
    {
        public static IPAddress ipAddress = IPAddress.Parse("127.0.0.1");
        IPEndPoint remoteEP = new IPEndPoint(ipAddress, 8888);
        Socket socket;
        bool isSitten = false;
        public FormBlackjackGame()
        {
            InitializeComponent();
            this.Text = string.Empty;
            this.ControlBox = false;
            this.DoubleBuffered = true;
            //this.WindowState = FormWindowState.Maximized;
        }

        private void FormBlackjackGame1_Load(object sender, EventArgs e)
        {
            byte[] toSend = null;
            byte[] bytes = new byte[1024];
            string data = null;
            string[] split;
            string username;
            int seat;
            try
            {
                socket = new Socket(ipAddress.AddressFamily, SocketType.Stream, ProtocolType.Tcp);
                socket.Connect(remoteEP);
                Thread t = new Thread(ReceiveDatas);
                t.Start();
                toSend = Encoding.ASCII.GetBytes("connectToTableOne" + "/s/");
                socket.Send(toSend);
                int bytesRec = socket.Receive(bytes);
                data += Encoding.ASCII.GetString(bytes, 0, bytesRec);
                if (data.EndsWith("/c/"))
                {
                    if (data.StartsWith("noPlayers"))
                    {
                    }
                    if (data.StartsWith("seat"))
                    {
                        data = data.Remove(data.Length - 1);
                        data = data.Remove(data.Length - 1);
                        data = data.Remove(data.Length - 1);
                        split = data.Split(';');
                        for(int n = 1; n<split.Length; ++n)
                        {
                            switch (split[n + 1])
                            {
                                case "1":
                                    buttonSeat1.Visible = false;
                                    labelUsername1.Text = split[n];
                                    labelUsername1.Visible = true;
                                    isSitten = true;
                                    break;
                                    case "2":
                                    buttonSeat2.Visible = false;
                                    labelUsername2.Text = split[n];
                                    labelUsername2.Visible = true;
                                    isSitten = true;
                                    break;
                                    case "3":
                                    buttonSeat3.Visible = false;
                                    labelUsername3.Text = split[n];
                                    labelUsername3.Visible = true;
                                    isSitten = true;
                                    break;
                                    case "4":
                                    buttonSeat4.Visible = false;
                                    labelUsername4.Text = split[n];
                                    labelUsername4.Visible = true;
                                    isSitten = true;
                                    break;
                                    case "5":
                                    buttonSeat5.Visible = false;
                                    labelUsername5.Text = split[n];
                                    labelUsername5.Visible = true;
                                    isSitten = true;
                                    break;
                                    case "6":
                                    buttonSeat6.Visible = false;
                                    labelUsername6.Text = split[n];
                                    labelUsername6.Visible = true;
                                    isSitten = true;
                                    break;
                                    case "7":
                                    buttonSeat7.Visible = false;
                                    labelUsername7.Text = split[n];
                                    labelUsername7.Visible = true;
                                    isSitten = true;
                                    break;
                            }
                            ++n;
                        }
                        toSend = Encoding.ASCII.GetBytes("Disconnect/s/");
                        socket.Send(toSend);
                        socket.Shutdown(SocketShutdown.Both);
                        socket.Close();
                    }
                }
            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.ToString(), "Errore!");
                this.Close();
            }
        }

        private void buttonExit_Click(object sender, EventArgs e)
        {
            byte[] toSend = null;
            if (isSitten)
            {
                socket = new Socket(ipAddress.AddressFamily, SocketType.Stream, ProtocolType.Tcp);
                socket.Connect(remoteEP);
                toSend = Encoding.ASCII.GetBytes("disconnectFromTableOne" + "/s/");
                socket.Send(toSend);
                socket.Shutdown(SocketShutdown.Both);
                socket.Close();
            }
            else
            {
                this.Close();
            }
        }

        private void buttonSeat1_Click(object sender, EventArgs e)
        {

        }

        private void buttonSeat2_Click(object sender, EventArgs e)
        {

        }

        private void buttonSeat3_Click(object sender, EventArgs e)
        {

        }

        private void buttonSeat4_Click(object sender, EventArgs e)
        {

        }

        private void buttonSeat5_Click(object sender, EventArgs e)
        {

        }

        private void buttonSeat6_Click(object sender, EventArgs e)
        {

        }

        private void buttonSeat7_Click(object sender, EventArgs e)
        {

        }
        void ReceiveDatas()
        {
            Socket receive = socket;
            byte[] bytes = new byte[1024];
            string data = null;
            while (true)
            {
                try
                {
                    receive.Connect(remoteEP);
                    receive.Receive(bytes);
                    if (data.EndsWith("/c/"))
                    {
                        data = data.Remove(data.Length - 1);
                        data = data.Remove(data.Length - 1);
                        data = data.Remove(data.Length - 1);
                        if (data.StartsWith("playerDisconnect"))
                        {
                            string seat;
                            string[] split;
                            split = data.Split(';');
                            seat = split[1];
                            if (isSitten)
                            {
                                switch (seat)
                                {
                                    case "1":
                                        labelUsername1.Text = "";
                                        break;
                                    case "2":
                                        labelUsername2.Text = "";
                                        break;
                                    case "3":
                                        labelUsername3.Text = "";
                                        break;
                                    case "4":
                                        labelUsername4.Text = "";
                                        break;
                                    case "5":
                                        labelUsername5.Text = "";
                                        break;
                                    case "6":
                                        labelUsername6.Text = "";
                                        break;
                                    case "7":
                                        labelUsername7.Text = "";
                                        break;
                                }
                            }
                            else
                            {
                                switch (seat)
                                {
                                    case "1":
                                        buttonSeat1.Visible = true;
                                        labelUsername1.Text = "";
                                        break;
                                    case "2":
                                        buttonSeat2.Visible = true;
                                        labelUsername1.Text = "";
                                        break;
                                    case "3":
                                        buttonSeat3.Visible = true;
                                        labelUsername1.Text = "";
                                        break;
                                    case "4":
                                        buttonSeat4.Visible = true;
                                        labelUsername1.Text = "";
                                        break;
                                    case "5":
                                        buttonSeat5.Visible = true;
                                        labelUsername1.Text = "";
                                        break;
                                    case "6":
                                        buttonSeat6.Visible = true;
                                        labelUsername1.Text = "";
                                        break;
                                    case "7":
                                        buttonSeat7.Visible = true;
                                        labelUsername1.Text = "";
                                        break;
                                }
                            }
                        }
                    }
                }catch(Exception ex)
                {
                    Console.WriteLine(ex.ToString());
                }
            }
        }
    }
}
