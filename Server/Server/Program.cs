using System;
using System.Collections.Generic;
using System.Net.Sockets;
using System.Net;
using System.Text;
using System.Runtime.CompilerServices;
using System.Security.Principal;
using System.Linq;

IPAddress ipAddress = System.Net.IPAddress.Parse("127.0.0.1");
IPEndPoint remoteEP = new IPEndPoint(ipAddress, 8888);
Socket _socket = new Socket(ipAddress.AddressFamily, SocketType.Stream, ProtocolType.Tcp);
_socket.Bind(remoteEP);
List<Socket> sockets = new List<Socket>();
List<Card> deck = new List<Card>();
List<Player> players = new List<Player>();

Console.WriteLine("THC - Tommasi Hall Casino [Versione BETA]\n(c) Tommasi Corporation.\n");
bool temp = false;
while (!temp)
{
    Console.Write(">>");
    string command = Console.ReadLine();
    switch (command)
    {
        case "start":
            temp = true;
            StartServer();
            break;
        case "op":
            makeUserAdmin();
            break;
        case "help":
            HelpCommand();
            break;
        default:
            Console.WriteLine("Comando errato, digitare 'help' per la lista dei comandi");
            break;
    }
}
void makeUserAdmin()
{

}
void HelpCommand()
{
    Console.WriteLine("start: Avvia il server\n" +
        "op: Dai i permessi da amministratore ad un utente");
}

void StartServer()
{
    _socket.Listen(100);
    Console.WriteLine("Server avviato!");
    StartThread();
}

void StartThread()
{
    Thread t = new Thread(Game);
    t.Start();
}

void Game()
{
    Socket handler;
    handler = _socket.Accept();
    sockets.Add(handler);
    Console.WriteLine(handler.RemoteEndPoint.ToString() + " has connected to the server");
    StartThread();
    while (true)
    {
        string data = null;
        byte[] bytes = new byte[1024];
        byte[] toSend = null;
        if (SocketExtensions.IsConnected(handler))
        {
            try
            {
                int bytesRec = handler.Receive(bytes);
                data += Encoding.ASCII.GetString(bytes, 0, bytesRec);
                if (data.EndsWith("/s/"))
                {
                    data = data.Remove(data.Length - 1);
                    data = data.Remove(data.Length - 1);
                    data = data.Remove(data.Length - 1);
                    Console.WriteLine(data);
                    if (data.StartsWith("login"))
                    {
                        bool exists = false;
                        List<string> username = new List<string>();
                        List<string> password = new List<string>();
                        List<string> role = new List<string>();
                        List<string> mail = new List<string>();
                        List<string> balance = new List<string>();
                        string[] split;
                        int n = 0;
                        string[] credentials = data.Split(";");
                        Console.Write(credentials[1] + "\n");
                        Console.Write(credentials[2]);
                        foreach (string line in File.ReadLines(@"../../../../files/users.txt"))
                        {
                            split = line.Split(";");
                            username.Add(split[0]);
                            password.Add(split[1]);
                            role.Add(split[2]);
                            mail.Add(split[3]);
                            balance.Add(split[4]);
                            n++;
                        }
                        for (int j = 0; j < username.Count; ++j)
                            if (credentials[1] == username[j] && credentials[2] == password[j])
                            {
                                toSend = Encoding.ASCII.GetBytes(role[j] + ";" + mail[j] + ";" + balance[j] + "/c/");
                                handler.Send(toSend);
                                exists = true;
                            }
                        if (!exists)
                        {
                            toSend = Encoding.ASCII.GetBytes("none/c/");
                            handler.Send(toSend);
                        }
                        
                    }
                    else if (data.StartsWith("register"))
                    {
                        string[] _split;
                        string[] split;
                        bool alredyUsedEmail = false;
                        split = data.Split(";");
                        foreach (string line in File.ReadLines(@"../../../../files/users.txt"))
                        {
                            _split = line.Split(";");
                            if (_split[3] == split[3])
                                alredyUsedEmail = true;
                        }
                        if (alredyUsedEmail) 
                        {
                            toSend = Encoding.ASCII.GetBytes("alredyUsed/c/");
                            handler.Send(toSend);
                        }
                        else
                        {
                            File.AppendAllText(@"../../../../files/users.txt", split[1] + ";" + split[2] + ";user;" + split[3] + ";0;" + split[4] + ";" + split[5] + ";" + split[6]);
                            toSend = Encoding.ASCII.GetBytes("ok/c/");
                            handler.Send(toSend);
                        }
                    }
                    else if (data.StartsWith("connectToTableOne"))
                    {
                        string[] split;
                        split = data.Split(";");
                        Player player = new Player();
                        player.username = split[1];
                        player.seatPosition = Convert.ToInt32(split[2]);
                        players.Add(player);
                    }
                    else if (data == "startGame")
                    {
                        CreateDeck(4);
                        ShuffleDeck();
                        FillTable();
                    }
                    else if(data == "update")
                    {

                    }
                    else if(data == "Disconnect")
                    {
                        for (int j = 0; j < sockets.Count; ++j)
                            if (handler == sockets[j])
                                sockets.RemoveAt(j);
                    }
                }

            }
            catch (Exception e)
            {
                Console.WriteLine(e);
            }
        }
        else
        {
            Thread.Sleep(Timeout.Infinite);
        }

    }


}


void FillTable()
{
    for (int j = 0; j < 2; ++j) {
        for (int n = 0; n < players.Count; ++n)
        {
            players[n].playerCards.Add(deck[0]);
            deck.RemoveAt(0);
        }
    }
}
void ClearTable()
{
    for(int n = 0; n<players.Count; ++n)
    {
        players[n].playerCards.Clear();
    }
}
void CreateDeck(int nDecks)
{
    for (int k = 0; k < nDecks; ++k)
    {
        for (int n = 0; n < 4; ++n)
        {
            for (int j = 0; j < 13; ++j)
            {
                Card card = new Card();
                switch (n)
                {
                    case 0:
                        card.cardValue = j + 1;
                        card.cardSymbol = "clubs";
                        break;
                    case 1:
                        card.cardValue = j + 1;
                        card.cardSymbol = "spades";
                        break;
                    case 2:
                        card.cardValue = j + 1;
                        card.cardSymbol = "diamonds";
                        break;
                    case 3:
                        card.cardValue = j + 1;
                        card.cardSymbol = "hearts";
                        break;
                }
                deck.Add(card);
            }
        }
    }
}
void ShuffleDeck()
{
    Card temp = new Card();
    Random rand = new Random();
    int n = deck.Count * 3;
    while(n > 1)
    {
        n--;
        int k = rand.Next(0, deck.Count-1);
        int j = rand.Next(0, deck.Count-1);
        temp = deck[k];
        deck[k] = deck[j];
        deck[j] = temp;
    }
}
void SortPlayers()
{
    List<Player> SortedList = players.OrderBy(o => o.seatPosition).ToList();
    players = SortedList;
}
class Player
{
    public string username;
    public int seatPosition;
    public List<Card> playerCards = new List<Card>();
    public float bet;
    public float win;
}

class Card
{
    public int cardValue;
    public string cardSymbol;
}
static class SocketExtensions
{
    public static bool IsConnected(this Socket socket)
    {
        try
        {
            return !(socket.Poll(1, SelectMode.SelectRead) && socket.Available == 0);
        }
        catch (SocketException) { return false; }
    }
}