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
using System.Runtime.InteropServices;

namespace Client.ServerForms
{
    public partial class FormBlackjackGame : Form
    {
        public static IPAddress ipAddress = IPAddress.Parse("127.0.0.1");
        IPEndPoint remoteEP = new IPEndPoint(ipAddress, 8888);
        Socket socket;
        Thread Treceive;
        bool isSitten = false;
        bool isConnected = false;
        string playerUsername;
        int playerSeat;
        float playerBalance;
        List<int> betLog = new List<int>();
        float bet;
        bool splitCard = false;
        bool insurance = false;
        public FormBlackjackGame(string playerUsername, float playerBalance)
        {
            InitializeComponent();
            this.StartPosition = FormStartPosition.CenterScreen;
            this.FormBorderStyle = FormBorderStyle.Sizable;
            this.MinimumSize = new Size(1483, 970);
            this.Text = string.Empty;
            this.ControlBox = false;
            this.DoubleBuffered = true;
            this.playerUsername = playerUsername;
            this.playerBalance = playerBalance;
            labelBalance.Text = "Saldo: " + playerBalance.ToString();
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
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString(), "Errore!");
                this.Close();
            }
        }

        private void buttonExit_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void buttonSeat1_Click(object sender, EventArgs e)
        {
            Seat(1);
            labelUsername1.Text = playerUsername;
            labelUsername1.BackColor = Color.Yellow;
            labelUsername1.Visible = true;
        }

        private void buttonSeat2_Click(object sender, EventArgs e)
        {
            Seat(2);
            labelUsername2.Text = playerUsername;
            labelUsername2.BackColor = Color.Yellow;
            labelUsername2.Visible = true;
        }

        private void buttonSeat3_Click(object sender, EventArgs e)
        {
            Seat(3);
            labelUsername3.Text = playerUsername;
            labelUsername3.BackColor = Color.Yellow;
            labelUsername3.Visible = true;
        }

        private void buttonSeat4_Click(object sender, EventArgs e)
        {
            Seat(4);
            labelUsername4.Text = playerUsername;
            labelUsername4.BackColor = Color.Yellow;
            labelUsername4.Visible = true;
        }

        private void buttonSeat5_Click(object sender, EventArgs e)
        {
            Seat(5);
            labelUsername5.Text = playerUsername;
            labelUsername5.BackColor = Color.Yellow;
            labelUsername5.Visible = true;
        }


        private void buttonSeat6_Click(object sender, EventArgs e)
        {
            Seat(6);
            labelUsername6.Text = playerUsername;
            labelUsername6.BackColor = Color.Yellow;
            labelUsername6.Visible = true;
        }

        private void buttonSeat7_Click(object sender, EventArgs e)
        {
            Seat(7);
            labelUsername7.Text = playerUsername;
            labelUsername7.BackColor = Color.Yellow;
            labelUsername7.Visible = true;
        }
        void Seat(int seat)
        {
            byte[] bytes = new byte[1024];
            byte[] toSend = Encoding.ASCII.GetBytes("seat;" + playerUsername + ";" + seat.ToString() + ";" + playerBalance.ToString() + "/s/");
            socket.Send(toSend);
            playerSeat = seat;
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
                            Invoke((MethodInvoker)delegate
                            {
                                PlayerDisconnect(data);
                            });

                        }
                        else if (data.StartsWith("seat"))
                        {
                            Invoke((MethodInvoker)delegate
                            {
                                OccupiedSeat(data);
                            });
                        }
                        else if (data == "okSeat")
                        {
                            Invoke(new MethodInvoker(Seat));
                        }
                        else if (data.StartsWith("playerConnect"))
                        {
                            Invoke((MethodInvoker)delegate
                            {
                                PlayerConnect(data);
                            });
                        }
                        else if (data.StartsWith("timerBet"))
                        {
                            Invoke((MethodInvoker)delegate
                            {
                                UpdateTimer(data);
                            });
                        }
                        else if (data.StartsWith("addCard"))
                        {
                            Invoke((MethodInvoker)delegate
                            {
                                UpdateCard(data);
                            });
                        }
                        else if (data.StartsWith("addSplitCard"))
                        {
                            Invoke((MethodInvoker)delegate
                            {
                                UpdateSplitCard(data);
                            });

                        }
                        else if (data.StartsWith("addDealerCard"))
                        {
                            Invoke((MethodInvoker)delegate
                            {
                                UpdateDealerCard(data);
                            });
                        }
                        else if (data.StartsWith("playerBlackjack"))
                        {
                            Invoke((MethodInvoker)delegate
                            {
                                UpdateBlackJack(data);
                            });
                        }
                        else if (data.StartsWith("blackjack"))
                        {
                            Invoke((MethodInvoker)delegate
                            {
                                BlackJack(data);
                            });
                        }
                        else if (data == "insuranceRequest")
                        {
                            Invoke(new MethodInvoker(InsuranceRequest));
                        }
                        else if (data.StartsWith("timerInsurance"))
                        {
                            Invoke((MethodInvoker)delegate
                            {
                                UpdateInsuranceTimer(data);
                            });
                        }
                        else if (data.StartsWith("dealerHasBJ"))
                        {
                            Invoke((MethodInvoker)delegate
                            {
                                DealerHasBJ(data);
                            });
                        }
                        else if (data.StartsWith("makeChoose"))
                        {
                            Invoke((MethodInvoker)delegate
                            {
                                MakeChoose(data);
                            });
                        }
                        else if (data.StartsWith("timerChoose"))
                        {
                            Invoke((MethodInvoker)delegate
                            {
                                UpdateChooseTimer(data);
                            });
                        }
                    }
                }
                catch (Exception ex)
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
                    labelUsername1.Text = username;
                    labelUsername1.Visible = true;
                    buttonSeat1.Visible = false;
                    break;
                case 2:
                    labelUsername2.Text = username;
                    labelUsername2.Visible = true;
                    buttonSeat2.Visible = false;
                    break;
                case 3:
                    labelUsername3.Text = username;
                    labelUsername3.Visible = true;
                    buttonSeat3.Visible = false;
                    break;
                case 4:
                    labelUsername4.Text = username;
                    labelUsername4.Visible = true;
                    buttonSeat4.Visible = false;
                    break;
                case 5:
                    labelUsername5.Text = username;
                    labelUsername5.Visible = true;
                    buttonSeat5.Visible = false;
                    break;
                case 6:
                    labelUsername6.Text = username;
                    labelUsername6.Visible = true;
                    buttonSeat6.Visible = false;
                    break;
                case 7:
                    labelUsername7.Text = username;
                    labelUsername7.Visible = true;
                    buttonSeat7.Visible = false;
                    break;
            }
        }
        void UpdateTimer(string data)
        {
            string[] split = data.Split(';');
            if (Convert.ToInt32(split[1]) == 30)
            {
                labelOpenedBet.Text = "SCOMMESSE APERTE";
                labelOpenedBet.Visible = true;
                labelTimer.Visible = true;
            }
            labelTimer.Text = split[1];
            if (Convert.ToInt32(split[1]) == 0)
            {
                panelFiches.Visible = false;
                pictureFiche.Enabled = false;
                labelTimer.Visible = false;
                labelOpenedBet.Text = "SCOMMESSE CHIUSE";
            }
        }
        void UpdateCard(string data)
        {
            string[] split = data.Split(';');
            string dir = "../../../Images/cards/" + split[3] + split[4] + ".png";
            if (split[1] == "1")
            {
                if (Convert.ToInt32(split[6]) > 21)
                {
                    labelResult1.Text = "BUSTED";
                    labelResult1.Visible = true;
                }
                labelCardsTotal1.Text = split[6];
                labelCardsTotal1.Visible = true;
                switch (split[2])
                {
                    case "1":
                        card1_1.ImageLocation = dir;
                        card1_1.Visible = true;
                        break;
                    case "2":
                        Console.WriteLine("case 2");
                        card2_1.ImageLocation = dir;
                        card2_1.Visible = true;
                        break;
                    case "3":
                        card3_1.ImageLocation = dir;
                        card3_1.Visible = true;
                        break;
                    case "4":
                        card4_1.ImageLocation = dir;
                        card4_1.Visible = true;
                        break;
                    case "5":
                        card5_1.ImageLocation = dir;
                        card5_1.Visible = true;
                        break;

                }
            }
            else if (split[1] == "2")
            {
                if (Convert.ToInt32(split[6]) > 21)
                {
                    labelResult2.Text = "BUSTED";
                    labelResult2.Visible = true;
                }
                labelCardsTotal2.Text = split[6];
                labelCardsTotal2.Visible = true;
                switch (split[2])
                {
                    case "1":
                        card1_2.ImageLocation = dir;
                        card1_2.Visible = true;
                        break;
                    case "2":
                        card2_2.ImageLocation = dir;
                        card2_2.Visible = true;
                        break;
                    case "3":
                        card3_2.ImageLocation = dir;
                        card3_2.Visible = true;
                        break;
                    case "4":
                        card4_2.ImageLocation = dir;
                        card4_2.Visible = true;
                        break;
                    case "5":
                        card5_2.ImageLocation = dir;
                        card5_2.Visible = true;
                        break;

                }
            }
            else if (split[1] == "3")
            {
                if (Convert.ToInt32(split[6]) > 21)
                {
                    labelResult3.Text = "BUSTED";
                    labelResult3.Visible = true;
                }
                labelCardsTotal3.Visible = true;
                labelCardsTotal3.Text = split[6];
                switch (split[2])
                {
                    case "1":
                        card1_3.ImageLocation = dir;
                        card1_3.Visible = true;
                        break;
                    case "2":
                        card2_3.ImageLocation = dir;
                        card2_3.Visible = true;
                        break;
                    case "3":
                        card3_3.ImageLocation = dir;
                        card3_3.Visible = true;
                        break;
                    case "4":
                        card4_3.ImageLocation = dir;
                        card4_3.Visible = true;
                        break;
                    case "5":
                        card5_3.ImageLocation = dir;
                        card5_3.Visible = true;
                        break;

                }
            }
            else if (split[1] == "4")
            {
                if (Convert.ToInt32(split[6]) > 21)
                {
                    labelResult4.Text = "BUSTED";
                    labelResult4.Visible = true;
                }
                labelCardsTotal4.Text = split[6];
                labelCardsTotal4.Visible = true;
                switch (split[2])
                {
                    case "1":
                        card1_4.ImageLocation = dir;
                        card1_4.Visible = true;
                        break;
                    case "2":
                        card2_4.ImageLocation = dir;
                        card2_4.Visible = true;
                        break;
                    case "3":
                        card3_4.ImageLocation = dir;
                        card3_4.Visible = true;
                        break;
                    case "4":
                        card4_4.ImageLocation = dir;
                        card4_4.Visible = true;
                        break;
                    case "5":
                        card5_4.ImageLocation = dir;
                        card5_4.Visible = true;
                        break;

                }
            }
            else if (split[1] == "5")
            {
                if (Convert.ToInt32(split[6]) > 21)
                {
                    labelResult5.Text = "BUSTED";
                    labelResult5.Visible = true;
                }
                labelCardsTotal5.Text = split[6];
                labelCardsTotal5.Visible = true;
                switch (split[2])
                {
                    case "1":
                        card1_5.ImageLocation = dir;
                        card1_5.Visible = true;
                        break;
                    case "2":
                        card2_5.ImageLocation = dir;
                        card2_5.Visible = true;
                        break;
                    case "3":
                        card3_5.ImageLocation = dir;
                        card3_5.Visible = true;
                        break;
                    case "4":
                        card4_5.ImageLocation = dir;
                        card4_5.Visible = true;
                        break;
                    case "5":
                        card5_5.ImageLocation = dir;
                        card5_5.Visible = true;
                        break;

                }
            }
            else if (split[1] == "6")
            {
                if (Convert.ToInt32(split[6]) > 21)
                {
                    labelResult6.Text = "BUSTED";
                    labelResult6.Visible = true;
                }
                labelCardsTotal6.Text = split[6];
                labelCardsTotal6.Visible = true;
                switch (split[2])
                {
                    case "1":
                        card1_6.ImageLocation = dir;
                        card1_6.Visible = true;
                        break;
                    case "2":
                        card2_6.ImageLocation = dir;
                        card2_6.Visible = true;
                        break;
                    case "3":
                        card3_6.ImageLocation = dir;
                        card3_6.Visible = true;
                        break;
                    case "4":
                        card4_6.ImageLocation = dir;
                        card4_6.Visible = true;
                        break;
                    case "5":
                        card5_6.ImageLocation = dir;
                        card5_6.Visible = true;
                        break;

                }
            }
            else if (split[1] == "7")
            {
                if (Convert.ToInt32(split[6]) > 21)
                {
                    labelResult7.Text = "BUSTED";
                    labelResult7.Visible = true;
                }
                labelCardsTotal7.Text = split[6];
                labelCardsTotal7.Visible = true;
                switch (split[2])
                {
                    case "1":
                        card1_7.ImageLocation = dir;
                        card1_7.Visible = true;
                        break;
                    case "2":
                        card2_7.ImageLocation = dir;
                        card2_7.Visible = true;
                        break;
                    case "3":
                        card3_7.ImageLocation = dir;
                        card3_7.Visible = true;
                        break;
                    case "4":
                        card4_7.ImageLocation = dir;
                        card4_7.Visible = true;
                        break;
                    case "5":
                        card5_7.ImageLocation = dir;
                        card5_7.Visible = true;
                        break;

                }
            }
        }
        void UpdateSplitCard(string data)
        {
            string[] split = data.Split(';');
            string dir = "../../../Images/cards/" + split[3] + split[4] + ".png";
            if (split[1] == "1")
            {
                if (Convert.ToInt32(split[6]) > 21)
                {
                    labelSplitResult1.Text = "BUSTED";
                    labelSplitResult1.Visible = true;
                }
                labelSplitCardsTotal1.Text = split[6];
                labelSplitCardsTotal1.Visible = true;
                switch (split[2])
                {
                    case "2":
                        cardSplit2_1.ImageLocation = dir;
                        cardSplit2_1.Visible = true;
                        break;
                    case "3":
                        cardSplit3_1.ImageLocation = dir;
                        cardSplit3_1.Visible = true;
                        break;
                    case "4":
                        cardSplit4_1.ImageLocation = dir;
                        cardSplit4_1.Visible = true;
                        break;

                }
            }
            else if (split[1] == "2")
            {
                if (Convert.ToInt32(split[6]) > 21)
                {
                    labelSplitResult2.Text = "BUSTED";
                    labelSplitResult2.Visible = true;
                }
                labelSplitCardsTotal2.Text = split[6];
                labelSplitCardsTotal2.Visible = true;
                switch (split[2])
                {
                    case "2":
                        cardSplit2_2.ImageLocation = dir;
                        cardSplit2_2.Visible = true;
                        break;
                    case "3":
                        cardSplit3_2.ImageLocation = dir;
                        cardSplit3_2.Visible = true;
                        break;
                    case "4":
                        cardSplit4_2.ImageLocation = dir;
                        cardSplit4_2.Visible = true;
                        break;
                }
            }
            else if (split[1] == "3")
            {
                if (Convert.ToInt32(split[6]) > 21)
                {
                    labelSplitResult3.Text = "BUSTED";
                    labelSplitResult3.Visible = true;
                }
                labelSplitCardsTotal3.Visible = true;
                labelSplitCardsTotal3.Text = split[6];
                switch (split[2])
                {
                    case "2":
                        cardSplit2_3.ImageLocation = dir;
                        cardSplit2_3.Visible = true;
                        break;
                    case "3":
                        cardSplit3_3.ImageLocation = dir;
                        cardSplit3_3.Visible = true;
                        break;
                    case "4":
                        cardSplit4_3.ImageLocation = dir;
                        cardSplit4_3.Visible = true;
                        break;
                }
            }
            else if (split[1] == "4")
            {
                if (Convert.ToInt32(split[6]) > 21)
                {
                    labelSplitResult4.Text = "BUSTED";
                    labelSplitResult4.Visible = true;
                }
                labelSplitCardsTotal4.Text = split[6];
                labelSplitCardsTotal4.Visible = true;
                switch (split[2])
                {
                    case "2":
                        cardSplit2_4.ImageLocation = dir;
                        cardSplit2_4.Visible = true;
                        break;
                    case "3":
                        cardSplit3_4.ImageLocation = dir;
                        cardSplit3_4.Visible = true;
                        break;
                    case "4":
                        cardSplit4_4.ImageLocation = dir;
                        cardSplit4_4.Visible = true;
                        break;
                }
            }
            else if (split[1] == "5")
            {
                if (Convert.ToInt32(split[6]) > 21)
                {
                    labelSplitResult5.Text = "BUSTED";
                    labelSplitResult5.Visible = true;
                }
                labelCardsTotal5.Text = split[6];
                labelCardsTotal5.Visible = true;
                switch (split[2])
                {
                    case "2":
                        cardSplit2_5.ImageLocation = dir;
                        cardSplit2_5.Visible = true;
                        break;
                    case "3":
                        cardSplit3_5.ImageLocation = dir;
                        cardSplit3_5.Visible = true;
                        break;
                    case "4":
                        cardSplit4_5.ImageLocation = dir;
                        cardSplit4_5.Visible = true;
                        break;
                }
            }
            else if (split[1] == "6")
            {
                if (Convert.ToInt32(split[6]) > 21)
                {
                    labelSplitResult6.Text = "BUSTED";
                    labelSplitResult6.Visible = true;
                }
                labelSplitCardsTotal6.Text = split[6];
                labelSplitCardsTotal6.Visible = true;
                switch (split[2])
                {
                    case "2":
                        cardSplit2_6.ImageLocation = dir;
                        cardSplit2_6.Visible = true;
                        break;
                    case "3":
                        cardSplit3_6.ImageLocation = dir;
                        cardSplit3_6.Visible = true;
                        break;
                    case "4":
                        cardSplit4_6.ImageLocation = dir;
                        cardSplit4_6.Visible = true;
                        break;
                }
            }
            else if (split[1] == "7")
            {
                if (Convert.ToInt32(split[6]) > 21)
                {
                    labelSplitResult7.Text = "BUSTED";
                    labelSplitResult7.Visible = true;
                }
                labelSplitCardsTotal7.Text = split[6];
                labelSplitCardsTotal7.Visible = true;
                switch (split[2])
                {
                    case "2":
                        cardSplit2_7.ImageLocation = dir;
                        cardSplit2_7.Visible = true;
                        break;
                    case "3":
                        cardSplit3_7.ImageLocation = dir;
                        cardSplit3_7.Visible = true;
                        break;
                    case "4":
                        cardSplit4_7.ImageLocation = dir;
                        cardSplit4_7.Visible = true;
                        break;
                }
            }
        }
        void UpdateDealerCard(string data)
        {
            string[] split = data.Split(';');
            if (split[1] == "covered")
            {
                card2_D.ImageLocation = "../../../Images/cards/covered.jpg";
                card2_D.Visible = true;
            }
            else
            {
                string dir = "../../../Images/cards/" + split[2] + split[3] + ".png";
                switch (split[1])
                {
                    case "1":
                        card1_D.ImageLocation = dir;
                        card1_D.Visible = true;
                        break;
                    case "2":
                        card2_D.ImageLocation = dir;
                        card2_D.Visible = true;
                        break;
                    case "3":
                        card3_D.ImageLocation = dir;
                        card3_D.Visible = true;
                        break;
                    case "4":
                        card4_D.ImageLocation = dir;
                        card4_D.Visible = true;
                        break;
                    case "5":
                        card5_D.ImageLocation = dir;
                        card5_D.Visible = true;
                        break;
                    case "6":
                        card6_D.ImageLocation = dir;
                        card6_D.Visible = true;
                        break;
                    case "7":
                        card7_D.ImageLocation = dir;
                        card7_D.Visible = true;
                        break;
                    case "8":
                        card8_D.ImageLocation = dir;
                        card8_D.Visible = true;
                        break;
                    case "9":
                        card9_D.ImageLocation = dir;
                        card9_D.Visible = true;
                        break;
                    case "10":
                        card10_D.ImageLocation = dir;
                        card10_D.Visible = true;
                        break;
                    case "11":
                        card11_D.ImageLocation = dir;
                        card11_D.Visible = true;
                        break;
                }
            }
        }
        void UpdateBlackJack(string data)
        {
            string[] split = data.Split(';');
            switch (split[1])
            {
                case "1":
                    labelResult1.Text = "BLACKJACK";
                    labelResult1.Visible = true;
                    break;
                case "2":
                    labelResult2.Text = "BLACKJACK";
                    labelResult2.Visible = true;
                    break;
                case "3":
                    labelResult3.Text = "BLACKJACK";
                    labelResult3.Visible = true;
                    break;
                case "4":
                    labelResult4.Text = "BLACKJACK";
                    labelResult4.Visible = true;
                    break;
                case "5":
                    labelResult5.Text = "BLACKJACK";
                    labelResult5.Visible = true;
                    break;
                case "6":
                    labelResult6.Text = "BLACKJACK";
                    labelResult6.Visible = true;
                    break;
                case "7":
                    labelResult7.Text = "BLACKJACK";
                    labelResult7.Visible = true;
                    break;
            }
        }
        void BlackJack(string data)
        {
            string[] split = data.Split(';');
            playerBalance += float.Parse(split[1]);
            labelBalance.Text = "Saldo: " + playerBalance.ToString();
            labelBet.Text = "Puntata: 0";
            labelLastWin.Text = "Ultima Vincita: " + split[1].ToString();
            switch (playerSeat)
            {
                case 1:
                    labelResult1.Text = "BLACKJACK";
                    labelResult1.Visible = true;
                    break;
                case 2:
                    labelResult2.Text = "BLACKJACK";
                    labelResult2.Visible = true;
                    break;
                case 3:
                    labelResult3.Text = "BLACKJACK";
                    labelResult3.Visible = true;
                    break;
                case 4:
                    labelResult4.Text = "BLACKJACK";
                    labelResult4.Visible = true;
                    break;
                case 5:
                    labelResult5.Text = "BLACKJACK";
                    labelResult5.Visible = true;
                    break;
                case 6:
                    labelResult6.Text = "BLACKJACK";
                    labelResult6.Visible = true;
                    break;
                case 7:
                    labelResult7.Text = "BLACKJACK";
                    labelResult7.Visible = true;
                    break;
            }
        }
        void InsuranceRequest()
        {
            panelInsurance.Visible = true;
        }
        void UpdateInsuranceTimer(string data)
        {
            byte[] toSend = null;
            string[] split = data.Split(';');
            labelInsuranceTimer.Text = split[1];
            if (Convert.ToInt32(split[1]) == 0)
            {
                panelInsurance.Visible = false;
                if (!insurance)
                    toSend = Encoding.ASCII.GetBytes("insuranceResponse;false/s/");
                else
                    toSend = Encoding.ASCII.GetBytes("insuranceResponse;true/s/");
                socket.Send(toSend);
            }
        }
        void DealerHasBJ(string data)
        {
            string[] split = data.Split(';');
            string dir = "../../../Images/cards/" + split[1] + split[2] + ".png";
            card2_D.ImageLocation = dir;
            playerBalance = Convert.ToInt32(split[3]);
            labelBalance.Text = "Saldo: " + split[3];
        }
        void MakeChoose(string data)
        {
            string[] split = data.Split(';');
            if (split[1] == "canSplit")
                buttonSplit.Enabled = true;
            else if (split[1] == "cantSplit")
                buttonSplit.Enabled = false;
            panelChoose.Visible = true;
        }
        void UpdateChooseTimer(string data)
        {
            string[] split = data.Split(';');
            labelInsuranceTimer.Text = split[1];
        }
        private void FormBlackjackGame_FormClosing(object sender, FormClosingEventArgs e)
        {
            byte[] toSend = null;
            if (isSitten)
                toSend = Encoding.ASCII.GetBytes("disconnectFromTableOne/s/");
            else
                toSend = Encoding.ASCII.GetBytes("Disconnect/s/");
            socket.Send(toSend);
            socket.Shutdown(SocketShutdown.Both);
            socket.Close();
            Treceive.Abort();
        }

        private void buttonInsuranceNo_Click(object sender, EventArgs e)
        {
            panelInsurance.Visible = false;
            insurance = false;
        }

        private void buttonInsuranceYes_Click(object sender, EventArgs e)
        {
            if (playerBalance >= bet / 2)
            {
                labelBalance.Text = (playerBalance - (bet / 2)).ToString();
                panelInsurance.Visible = false;
                insurance = true;
            }
            else
                MessageBox.Show("Non hai abbastanza credito!");
        }
        private void buttonDouble_Click(object sender, EventArgs e)
        {
            if (playerBalance >= bet)
            {
                panelChoose.Visible = false;
                bet *= 2;
                labelBet.Text = "Puntata: " + bet.ToString();
                byte[] toSend = Encoding.ASCII.GetBytes("double/s/");
                socket.Send(toSend);
            }
            else
            {
                MessageBox.Show("Non hai abbastanza credito!");
                panelChoose.Visible = true;
            }
        }

        private void buttonCard_Click(object sender, EventArgs e)
        {
            panelChoose.Visible = false;
            byte[] toSend = Encoding.ASCII.GetBytes("getCard/s/");
            socket.Send(toSend);
            
        }

        private void buttonStay_Click(object sender, EventArgs e)
        {
            panelChoose.Visible = false;
            byte[] toSend = Encoding.ASCII.GetBytes("stay/s/");
            socket.Send(toSend);
        }

        private void buttonSplit_Click(object sender, EventArgs e)
        {
            panelChoose.Visible = false;
            if (playerBalance >= bet)
            {
                splitCard = true;
                switch (playerSeat)
                {
                    case 1:
                        cardSplit1_1.ImageLocation = card2_1.ImageLocation;
                        card2_1.ImageLocation = card1_1.ImageLocation;
                        card1_1.Visible = false;
                        card1_1.ImageLocation = null;
                        break;
                    case 2:
                        cardSplit1_2.ImageLocation = card2_2.ImageLocation;
                        card2_2.ImageLocation = card1_2.ImageLocation;
                        card1_2.Visible = false;
                        card1_2.ImageLocation = null;
                        break;
                    case 3:
                        cardSplit1_3.ImageLocation = card2_3.ImageLocation;
                        card2_3.ImageLocation = card1_3.ImageLocation;
                        card1_3.Visible = false;
                        card1_3.ImageLocation = null;
                        break;
                    case 4:
                        cardSplit1_4.ImageLocation = card2_4.ImageLocation;
                        card2_4.ImageLocation = card1_4.ImageLocation;
                        card1_4.Visible = false;
                        card1_4.ImageLocation = null;
                        break;
                    case 5:
                        cardSplit1_5.ImageLocation = card2_5.ImageLocation;
                        card2_5.ImageLocation = card1_5.ImageLocation;
                        card1_5.Visible = false;
                        card1_5.ImageLocation = null;
                        break;
                    case 6:
                        cardSplit1_6.ImageLocation = card2_6.ImageLocation;
                        card2_6.ImageLocation = card1_6.ImageLocation;
                        card1_6.Visible = false;
                        card1_6.ImageLocation = null;
                        break;
                    case 7:
                        cardSplit1_7.ImageLocation = card2_7.ImageLocation;
                        card2_7.ImageLocation = card1_7.ImageLocation;
                        card1_7.Visible = false;
                        card1_7.ImageLocation = null;
                        break;
                }
                bet *= 2;
                labelBet.Text = "Puntata: " + bet.ToString();
                byte[] toSend = Encoding.ASCII.GetBytes("split/s/");
                socket.Send(toSend);
            }
            else
            {
                MessageBox.Show("Non hai abbastanza credito!");
                panelChoose.Visible = true;
            }
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
                    buttonMaximize_Click(this.buttonMaximize, e);
                else
                {
                    FormBorderStyle = FormBorderStyle.Sizable;
                    ReleaseCapture();
                    SendMessage(this.Handle, 0x112, 0xf012, 0);
                }
        }

        private void buttonMaximize_Click(object sender, EventArgs e)
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

        private void buttonMinimize_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }

        private void FormBlackjackGame_Resize(object sender, EventArgs e)
        {
            if (this.WindowState != FormWindowState.Maximized)
                FormBorderStyle = FormBorderStyle.Sizable;
            else
                FormBorderStyle = FormBorderStyle.None;
        }

        private void pictureFiche_Click(object sender, EventArgs e)
        {
            if (panelFiches.Visible == false)
                panelFiches.Visible = true;
            else
                panelFiches.Visible = false;
        }
        void ApplyBet(int tag)
        {
            if (playerBalance >= Convert.ToInt32(tag))
            {
                bet += Convert.ToInt32(tag);
                playerBalance -= Convert.ToInt32(tag);
                betLog.Add(Convert.ToInt32(tag));
                pictureBack.Enabled = true;
            }
            else
                MessageBox.Show("Non hai abbastamza credito!");
        }

        private void pictureFiche1_Click(object sender, EventArgs e)
        {
            ApplyBet(Convert.ToInt32(pictureFiche1.Tag));
        }

        private void pictureFiche5_Click(object sender, EventArgs e)
        {
            ApplyBet(Convert.ToInt32(pictureFiche5.Tag));
        }

        private void pictureFiche10_Click(object sender, EventArgs e)
        {
            ApplyBet(Convert.ToInt32(pictureFiche10.Tag));
        }

        private void pictureFiche20_Click(object sender, EventArgs e)
        {
            ApplyBet(Convert.ToInt32(pictureFiche20.Tag));
        }

        private void pictureFiche50_Click(object sender, EventArgs e)
        {
            ApplyBet(Convert.ToInt32(pictureFiche50.Tag));
        }

        private void pictureFiche100_Click(object sender, EventArgs e)
        {
            ApplyBet(Convert.ToInt32(pictureFiche100.Tag));
        }

        private void pictureBack_Click(object sender, EventArgs e)
        {
            if (betLog.Count == 1)
                pictureBack.Enabled = false;
            bet -= betLog[betLog.Count - 1];
            playerBalance += betLog[betLog.Count - 1];
            betLog.RemoveAt(betLog.Count - 1);
        }
    }
}
