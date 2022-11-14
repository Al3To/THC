using System;
using System.Collections.Generic;
using System.Net.Sockets;
using System.Net;
using System.Text;
using System.Runtime.CompilerServices;

IPAddress ipAddress = System.Net.IPAddress.Parse("127.0.0.1");
IPEndPoint remoteEP = new IPEndPoint(ipAddress, 8888);
Socket _socket = new Socket(ipAddress.AddressFamily, SocketType.Stream, ProtocolType.Tcp);
_socket.Bind(remoteEP);
int players = 0;

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
    startThread();
}

void startThread()
{
    Thread t = new Thread(game);
    t.Start();
}

void game()
{
    Thread.Sleep(1000);
    Socket handler;
    handler = _socket.Accept();
    Console.WriteLine("Someone connected to the server");
    startThread();
    while (true)
    {
        string data = null;
        byte[] bytes = new byte[1024];
        if (SocketExtensions.IsConnected(handler))
        {
            try
            {
                int bytesRec = handler.Receive(bytes);
                data += Encoding.ASCII.GetString(bytes, 0, bytesRec);
                if (data.EndsWith("/o/"))
                    Console.WriteLine(data);

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