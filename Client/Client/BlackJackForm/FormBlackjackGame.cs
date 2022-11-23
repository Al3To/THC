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
        bool isConnected = false;
        string playerUsername;
        Thread Treceive;
        public FormBlackjackGame(string playerUsername)
        {
            InitializeComponent();
            this.Text = string.Empty;
            this.ControlBox = false;
            this.DoubleBuffered = true;
            this.playerUsername = playerUsername;
            //this.WindowState = FormWindowState.Maximized;
        }

        private void FormBlackjackGame1_Load(object sender, EventArgs e)
        {
            byte[] toSend = null;
            

            try
            {
                socket = new Socket(ipAddress.AddressFamily, SocketType.Stream, ProtocolType.Tcp);
                socket.Connect(remoteEP);
                isConnected = true;
                Treceive = new Thread(ReceiveDatas);
                Treceive.Start();
                toSend = Encoding.ASCII.GetBytes("connectToTableOne" + "/s/");
                socket.Send(toSend);
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
                toSend = Encoding.ASCII.GetBytes("disconnectFromTableOne/s/");
                socket.Send(toSend);
                socket.Shutdown(SocketShutdown.Both);
                socket.Close();
                Treceive.Abort();
                this.Close();
            }
            else
            {
                toSend = Encoding.ASCII.GetBytes("Disconnect/s/");
                socket.Send(toSend);
                socket.Shutdown(SocketShutdown.Both);
                socket.Close();
                Treceive.Abort();
                this.Close();
            }
        }

        private void buttonSeat1_Click(object sender, EventArgs e)
        {
            Seat(1);
            labelUsername1.Text = playerUsername;
            labelUsername1.Visible = true;
        }

        private void buttonSeat2_Click(object sender, EventArgs e)
        {
            Seat(2);
            labelUsername2.Text = playerUsername;
            labelUsername2.Visible = true;
        }

        private void buttonSeat3_Click(object sender, EventArgs e)
        {
            Seat(3);
            labelUsername3.Text = playerUsername;
            labelUsername3.Visible = true;
        }

        private void buttonSeat4_Click(object sender, EventArgs e)
        {
            Seat(4);
            labelUsername4.Text = playerUsername;
            labelUsername4.Visible = true;
        }

        private void buttonSeat5_Click(object sender, EventArgs e)
        {
            Seat(5);
            labelUsername5.Text = playerUsername;
            labelUsername5.Visible = true;
        }


        private void buttonSeat6_Click(object sender, EventArgs e)
        {
            Seat(6);
            labelUsername6.Text = playerUsername;
            labelUsername6.Visible = true;
        }

        private void buttonSeat7_Click(object sender, EventArgs e)
        {
            Seat(7);
            labelUsername7.Text = playerUsername;
            labelUsername7.Visible = true;
        }
        void Seat(int seat)
        {
            byte[] bytes = new byte[1024];
            byte[] toSend = Encoding.ASCII.GetBytes("seat;" + playerUsername + ";" + seat.ToString() +"/s/");
            socket.Send(toSend);
        }
        void ReceiveDatas()
        {
            byte[] bytes = new byte[1024];
            while (isConnected)
            {
                string data = null;
                try
                {
                    int bytesRec = socket.Receive(bytes);
                    data += Encoding.ASCII.GetString(bytes, 0, bytesRec);
                    Console.WriteLine(data);
                    
                    if (data.EndsWith("/c/"))
                    {
                        data = data.Remove(data.Length - 1);
                        data = data.Remove(data.Length - 1);
                        data = data.Remove(data.Length - 1);
                        if (data.StartsWith("playerDisconnect"))
                        {
                            Invoke((MethodInvoker)delegate {
                                PlayerDisconnect(data);
                            });

                        }
                        else if (data.StartsWith("seat"))
                        {
                            Invoke((MethodInvoker)delegate {
                                OccupiedSeat(data);
                            });
                        }
                        else if (data == "okSeat")
                        {
                            Invoke(new MethodInvoker(Seat));
                        }
                        else if(data.StartsWith("playerConnect"))
                        {
                            Invoke((MethodInvoker)delegate {
                                PlayerConnect(data);
                            });
                        }
                    }
                }catch(Exception ex)
                {
                    Console.WriteLine(ex.ToString(), "Errore!");
                }
            }
        }
        void PlayerDisconnect(string data)
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
        void OccupiedSeat(string data)
        {
            
            string[] split;
            split = data.Split(';');
            for (int n = 1; n < split.Length; ++n)
            {
                switch (split[n + 1])
                {
                    case "1":
                        buttonSeat1.Visible = false;
                        labelUsername1.Text = split[n];
                        labelUsername1.Visible = true;
                        break;
                    case "2":
                        buttonSeat2.Visible = false;
                        labelUsername2.Text = split[n];
                        labelUsername2.Visible = true;
                        break;
                    case "3":
                        buttonSeat3.Visible = false;
                        labelUsername3.Text = split[n];
                        labelUsername3.Visible = true;
                        break;
                    case "4":
                        buttonSeat4.Visible = false;
                        labelUsername4.Text = split[n];
                        labelUsername4.Visible = true;
                        break;
                    case "5":
                        buttonSeat5.Visible = false;
                        labelUsername5.Text = split[n];
                        labelUsername5.Visible = true;
                        break;
                    case "6":
                        buttonSeat6.Visible = false;
                        labelUsername6.Text = split[n];
                        labelUsername6.Visible = true;
                        break;
                    case "7":
                        buttonSeat7.Visible = false;
                        labelUsername7.Text = split[n];
                        labelUsername7.Visible = true;
                        break;
                }
                ++n;
            }
        }
        void Seat()
        {
            isSitten = true;
            pictureFiche.Visible = true;
            buttonSeat1.Visible = false;
            buttonSeat2.Visible = false;
            buttonSeat3.Visible = false;
            buttonSeat4.Visible = false;
            buttonSeat5.Visible = false;
            buttonSeat6.Visible = false;
            buttonSeat7.Visible = false;
        }
        void PlayerConnect(string data)
        {
            string[] split;
            split = data.Split(';');
            int seat = Convert.ToInt32(split[2]);
            string username = split[1];
            Console.WriteLine(data);
            Console.WriteLine(username);
            Console.WriteLine(seat);
            Console.WriteLine(split[0] + " " + split[1] + " " + split[2]);
            switch (seat)
            {
                case 1:
                    Console.WriteLine("Entrato nel case 1");
                    labelUsername1.Text = username;
                    labelUsername1.Visible = true;
                    break;
                case 2:
                    labelUsername2.Text = username;
                    labelUsername2.Visible = true;
                    break;
                case 3:
                    labelUsername3.Text = username;
                    labelUsername3.Visible = true;
                    break;
                case 4:
                    labelUsername4.Text = username;
                    labelUsername4.Visible = true;
                    break;
                case 5:
                    labelUsername5.Text = username;
                    labelUsername5.Visible = true;
                    break;
                case 6:
                    labelUsername6.Text = username;
                    labelUsername6.Visible = true;
                    break;
                case 7:
                    labelUsername7.Text = username;
                    labelUsername7.Visible = true;
                    break;
            }
        }
    }
}
