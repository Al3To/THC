using System;
using System.Collections.Generic;
using System.Net.Sockets;
using System.Net;

IPAddress ipAddress = System.Net.IPAddress.Parse("127.0.0.1");
IPEndPoint remoteEP = new IPEndPoint(ipAddress, 8888);
Socket _socket = new Socket(ipAddress.AddressFamily, SocketType.Stream, ProtocolType.Tcp);
_socket.Bind(remoteEP);

bool temp = false;
while (!temp)
{
    string command = Console.ReadLine();
    switch (command)
    {
        case "start":
            temp = true;
            startServer();
            break;
        case "help":
            helpCommand();
            break;
        default:
            Console.WriteLine("Comando errato, digitare 'help' per la lista dei comandi" + Environment.NewLine);
            break;
    }
}

void helpCommand()
{
    Console.WriteLine("start: Avvia il server" + Environment.NewLine);
}

void startServer()
{
    _socket.Listen(100);
}