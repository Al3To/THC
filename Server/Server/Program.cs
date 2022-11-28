﻿using System;
using System.Collections.Generic;
using System.Net.Sockets;
using System.Net;
using System.Text;
using System.Runtime.CompilerServices;
using System.Security.Principal;
using System.Linq;
using System.Timers;
using System.Reflection.Emit;
using System.Threading;


IPAddress ipAddress = System.Net.IPAddress.Parse("127.0.0.1");
IPEndPoint remoteEP = new IPEndPoint(ipAddress, 8888);
Socket _socket = new Socket(ipAddress.AddressFamily, SocketType.Stream, ProtocolType.Tcp);
_socket.Bind(remoteEP);

List<Socket> sockets = new List<Socket>();
List<Card> deck = new List<Card>();
List<Player> players = new List<Player>();
List<Player> playingPlayers = new List<Player>();
Dealer dealer = new Dealer();

Encoding asc = Encoding.ASCII;
bool betOpened = false;
bool gameStarted = false;
int turn = 0;
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
                data += asc.GetString(bytes, 0, bytesRec);
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
                                toSend = asc.GetBytes(role[j] + ";" + mail[j] + ";" + balance[j] + "/c/");
                                handler.Send(toSend);
                                exists = true;
                            }
                        if (!exists)
                        {
                            toSend = asc.GetBytes("none/c/");
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
                            toSend = asc.GetBytes("alredyUsed/c/");
                            handler.Send(toSend);
                        }
                        else
                        {
                            File.AppendAllText(@"../../../../files/users.txt","\n" + split[1] + ";" + split[2] + ";user;" + split[3] + ";0;" + split[4] + ";" + split[5] + ";" + split[6]);
                            toSend = asc.GetBytes("ok/c/");
                            handler.Send(toSend);
                        }
                    }
                    else if (data.StartsWith("connectToTableOne"))
                    {
                        string _toSend = "seats;";
                        if (players.Count == 0)
                        {
                            toSend = asc.GetBytes("noPlayers/c/");
                            handler.Send(toSend);
                        }
                        else
                        {
                            for (int n = 0; n < players.Count; ++n)
                                if (n == players.Count - 1)
                                    _toSend += players[n].username + ";" + players[n].seatPosition + "/c/";
                                else
                                    _toSend += players[n].username + ";" + players[n].seatPosition.ToString() + ";";
                            toSend = asc.GetBytes(_toSend);
                            handler.Send(toSend);
                        }
                    }
                    else if (data.StartsWith("seat"))
                    {
                        string[] split;
                        split = data.Split(";");
                        Console.Write(data);
                        Player player = new Player();
                        player.username = split[1];
                        player.seatPosition = Convert.ToInt32(split[2]);
                        player.playerSocket = handler;
                        players.Add(player);
                        toSend = asc.GetBytes("okSeat/c/");
                        handler.Send(toSend);
                        toSend = asc.GetBytes("playerConnect;" + split[1] + ";" + split[2] + "/c/");
                        for (int m = 0; m < sockets.Count; ++m)
                            if (sockets[m] != handler)
                                sockets[m].Send(toSend);
                        if (!betOpened && !gameStarted)
                            if (players.Count >= 2)
                            {
                                betOpened = true;
                                Timer();
                            }
                    }
                    else if (data.StartsWith("insuranceResponse"))
                    {
                        string[] split = data.Split(';');
                        bool insurance = false;
                        if (split[1] == "false")
                            insurance = false;
                        else if (split[1] == "true")
                            insurance = true;
                        for (int n = 0; n < playingPlayers.Count; ++n)
                            if (playingPlayers[n].playerSocket == handler)
                            {
                                playingPlayers[n].insurance = insurance;
                                if (insurance)
                                    playingPlayers[n].balance -= playingPlayers[n].bet / 2;
                            }
                    }
                    else if(data == "disconnectFromTableOne")
                    {
                        string seat = null;
                        for (int j = 0; j < players.Count; ++j)
                            if (handler == players[j].playerSocket)
                            {
                                Console.Write(j + "removed");
                                seat = players[j].seatPosition.ToString();
                                players.RemoveAt(j);

                                for (int l = 0; l < sockets.Count; ++l)
                                    if (handler == sockets[l])
                                        sockets.RemoveAt(l);
                                toSend = asc.GetBytes("playerDisconnect;" + seat + "/c/");
                                for (int m = 0; m < sockets.Count; ++m)
                                    sockets[m].Send(toSend);
                            }   
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
            Thread.Sleep(Timeout.Infinite);
    }
}

async void Timer()
{
    int timer = 5;
    while (timer >= 0)
    {
        byte[] toSend = asc.GetBytes("timerBet;" + timer.ToString() + "/c/");
        for (int m = 0; m < sockets.Count; ++m)
            sockets[m].Send(toSend);
        timer--;
        await Task.Delay(1000);
    }
    betOpened = false;
    gameStarted = true;
    SortPlayers();
    CreateDeck(4);
    ShuffleDeck();
    FillTable();
}
void CreateDeck(int nDecks)
{
    for (int k = 0; k < nDecks; ++k)
    {
        for (int n = 0; n < 4; ++n)
        {
            for (int j = 1; j < 10; ++j)
            {
                Card card = new Card();
                card.cardName = (j + 1).ToString();
                card.cardValue = j + 1;
                switch (n)
                {
                    case 0:
                        card.cardSymbol = "clubs";
                        break;
                    case 1:
                        card.cardSymbol = "spades";
                        break;
                    case 2:
                        card.cardSymbol = "diamonds";
                        break;
                    case 3:
                        card.cardSymbol = "hearts";
                        break;
                }
                deck.Add(card);
            }
            for(int m = 0; m<4; ++m)
            {
                Card card = new Card();
                switch (m)
                {
                    case 0:
                        card.cardName = "ace";
                        card.cardValue = 11;
                        break;
                    case 1:
                        card.cardName = "jack";
                        card.cardValue = 10;
                        break;
                    case 2:
                        card.cardName = "queen";
                        card.cardValue = 10;
                        break;
                    case 3:
                        card.cardName = "king";
                        card.cardValue = 10;
                        break;
                }
                switch (n)
                {
                    case 0:
                        card.cardSymbol = "clubs";
                        break;
                    case 1:
                        card.cardSymbol = "spades";
                        break;
                    case 2:
                        card.cardSymbol = "diamonds";
                        break;
                    case 3:
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
    while (n > 1)
    {
        n--;
        int k = rand.Next(0, deck.Count - 1);
        int j = rand.Next(0, deck.Count - 1);
        temp = deck[k];
        deck[k] = deck[j];
        deck[j] = temp;
    }
}
async void FillTable()
{
    byte[] toSend = null;
    for (int j = 0; j < 2; ++j) {
        for (int n = 0; n < playingPlayers.Count; ++n)
        {
            playingPlayers[n].playerCards.Add(deck[0]);
            playingPlayers[n].UpdateTotal();
            if (deck[0].cardName == "ace")
                playingPlayers[n].hasAce = true;
            toSend = asc.GetBytes("addCard;" + playingPlayers[n].seatPosition + ";" + playingPlayers[n].playerCards.Count.ToString() + ";" +deck[0].cardName + ";" + deck[0].cardSymbol + ";" + deck[0].cardValue.ToString() + ";" + playingPlayers[n].cardsTotal.ToString() + "/c/");
            for (int m = 0; m < sockets.Count; ++m)
                sockets[m].Send(toSend);
            deck.RemoveAt(0);
            await Task.Delay(100);
        }
        dealer.dealerCards.Add(deck[0]);
        dealer.UpdateTotal();
        if (j == 0)
            toSend = asc.GetBytes("addDealerCard;" + dealer.dealerCards.Count.ToString() + ";" + deck[0].cardName + ";" + deck[0].cardSymbol + ";" + deck[0].cardValue.ToString() + "/c/");
        else if (j == 1)
            toSend = asc.GetBytes("addDealerCard;covered/c/");
        for (int m = 0; m < sockets.Count; ++m)
            sockets[m].Send(toSend);
        deck.RemoveAt(0);
    }
    if (dealer.dealerCards[0].cardName == "ace")
    {
        toSend = asc.GetBytes("insuranceRequest/c/");
        for (int m = 0; m < playingPlayers.Count; ++m)
            playingPlayers[m].playerSocket.Send(toSend);
        int timer = 10;
        while (timer >= 0)
        {
            toSend = asc.GetBytes("timerInsurance;" + timer.ToString() + "/c/");
            for (int m = 0; m < playingPlayers.Count; ++m)
                playingPlayers[m].playerSocket.Send(toSend);
            timer--;
            await Task.Delay(1000);
        }
        await Task.Delay(1000);

        if (dealer.dealerCards[1].cardValue == 10)

            for (int m = 0; m < playingPlayers.Count; ++m)
            {
                if (playingPlayers[m].insurance)
                    playingPlayers[m].balance += playingPlayers[m].bet;
                else if (!playingPlayers[m].insurance && playingPlayers[m].cardsTotal == 21)
                    playingPlayers[m].balance += playingPlayers[m].bet;

                toSend = asc.GetBytes("dealerHasBJ;" + dealer.dealerCards[1].cardName + ";" + dealer.dealerCards[1].cardSymbol + ";" + playingPlayers[m].balance + "/c/");
                playingPlayers[m].playerSocket.Send(toSend);
            }
        else
            NextTurn();
        
    }
    
}
void ClearTable()
{
    for(int n = 0; n< playingPlayers.Count; ++n)
    {
        playingPlayers[n].playerCards.Clear();
    }
}
void SortPlayers()
{
    playingPlayers = players.OrderBy(o => o.seatPosition).ToList();
}
void CheckBlackJack()
{
    byte[] toSend;
    for (int n = 0; n < playingPlayers.Count; ++n)
        if (playingPlayers[n].cardsTotal == 21 && dealer.cardsTotal != 21)
        {
            playingPlayers[n].done = true;
            playingPlayers[n].win = playingPlayers[n].bet + (playingPlayers[n].bet * 1.5f);
            toSend = asc.GetBytes("blackjack;" + playingPlayers[n].win.ToString() + "/c/");
            playingPlayers[n].playerSocket.Send(toSend);
            for(int m = 0; m < playingPlayers.Count; ++m)
                if(m != n)
                {
                    toSend = asc.GetBytes("playerBlackJack;" + playingPlayers[n].seatPosition + "/c/");
                    playingPlayers[m].playerSocket.Send(toSend);
                }
        }
}
async void NextTurn()
{
    byte[] toSend = null;
    bool allPlayersDone = false;
    for(int n = 0; n<playingPlayers.Count; ++n)
    {
        if (!playingPlayers[n].done) break;
        if(n == playingPlayers.Count - 1) 
            allPlayersDone = true;
    }
    if (allPlayersDone)
        EndGame();

    if (turn >= playingPlayers.Count -1 && !allPlayersDone)
        turn = 0;

    while (playingPlayers[turn].done)
        turn++;


    if (playingPlayers[turn].cardsTotal == 21)
    {
        playingPlayers[turn].done = true;
        NextTurn();
    }
    else if (playingPlayers[turn].playerCards[0] == playingPlayers[turn].playerCards[1] && playingPlayers[turn].playerCards.Count == 2)
        toSend = asc.GetBytes("makeChoose;canSplit/c/");
    else
        toSend = asc.GetBytes("makeChoose;cantSplit/c/");
    playingPlayers[turn].playerSocket.Send(toSend);
    int timer = 15;
    while (timer >= 0)
    {
        toSend = asc.GetBytes("timerChoose;" + timer.ToString() + "/c/");
        playingPlayers[turn].playerSocket.Send(toSend);
        timer--;
        await Task.Delay(1000);
    }
}
void EndGame()
{

}
class Dealer
{
    public List<Card> dealerCards = new List<Card>();
    public int cardsTotal = 0;
    public bool hasAce;
    bool aceValueOne = false;
    public void UpdateTotal()
    {
        for (int n = 0; n < dealerCards.Count; ++n)
            cardsTotal += dealerCards[n].cardValue;
        if (this.hasAce && !aceValueOne)
        {
            if (cardsTotal > 21)
                for (int n = 0; n < dealerCards.Count; ++n)
                    if (dealerCards[n].cardName == "ace")
                    {
                        dealerCards[n].cardValue = 1;
                        aceValueOne = true;
                    }
            this.UpdateTotal();
        }
    }
}
class Player
{
    public Socket playerSocket;
    public string username;
    public float balance;
    public int seatPosition;
    public List<Card> playerCards = new List<Card>();
    public List<Card> playerSplitCards = new List<Card>();
    public bool hasAce;
    bool aceValueOne = false;
    public int cardsTotal = 0;
    public float bet;
    public float win;
    public bool done = false;
    public bool insurance = false;

    public void UpdateTotal()
    {
        for(int n = 0; n<playerCards.Count; ++n)
            cardsTotal += playerCards[n].cardValue;
        if (this.hasAce && !aceValueOne)
        {
            if (cardsTotal > 21)
                for (int n = 0; n < playerCards.Count; ++n)
                    if (playerCards[n].cardName == "ace")
                    {
                        playerCards[n].cardValue = 1;
                        aceValueOne = true;
                    }
            this.UpdateTotal();
        }
    }
}

class Card
{
    public int cardValue;
    public string cardName;
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