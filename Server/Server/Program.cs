using System;
using System.Collections.Generic;
using System.Net.Sockets;
using System.Net;
using System.Text;
using System.Runtime.CompilerServices;
using System.Security.Principal;

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
            StartServer();
            break;
        case "help":
            HelpCommand();
            break;
        default:
            Console.WriteLine("Comando errato, digitare 'help' per la lista dei comandi" + Environment.NewLine);
            break;
    }
}

void HelpCommand()
{
    Console.WriteLine("start: Avvia il server" + Environment.NewLine);
}

void StartServer()
{
    _socket.Listen(100);
    StartThread();
}

void StartThread()
{
    Thread t = new Thread(Game);
    t.Start();
}

void Game()
{
    Thread.Sleep(1000);
    Socket handler;
    handler = _socket.Accept();
    Console.WriteLine("Someone connected to the server");
    players++;
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
                    switch (data)
                    {
                        case "Login":
                            List<string> username = new List<string>();
                            List<string> password = new List<string>();
                            List<string> role = new List<string>();
                            string[] temp;
                            int n = 0;
                            bytesRec = handler.Receive(bytes);
                            data = null;
                            data += Encoding.ASCII.GetString(bytes, 0, bytesRec);
                            string[] credentials = data.Split(";");
                            Console.Write(credentials[0] + "\n");
                            Console.Write(credentials[1]);
                            foreach (string line in File.ReadLines(@"../../../../files/users.txt"))
                            {
                                temp = line.Split(";");
                                username.Add(temp[0]);
                                password.Add(temp[1]);
                                role.Add(temp[2]);
                                n++;
                            }

                            for (int j = 0; j < username.Count; ++j)
                            {
                                if (credentials[0] == username[j] && credentials[1] == password[j])
                                {
                                    toSend = Encoding.ASCII.GetBytes(role[j] + "/c/");
                                    handler.Send(toSend);
                                    Console.Write(toSend);
                                }
                                Console.Write(j);

                            }
                            Console.Write("finito");
                            break;
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
            players--;
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