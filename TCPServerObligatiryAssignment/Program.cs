// See https://aka.ms/new-console-template for more information
using System.Security.Cryptography.X509Certificates;
using System.Text.Json;
using System.Threading.Channels;
using TCPServerObligatiryAssignment;


Console.WriteLine("Welcome to the server-starter\r\nOptions:\r\n\ts: Start a server on port 727 using regular protocol\r\n\tj: Start a server on port 728 using JSON-parsing" +
    "\r\n\th: Help, print this menu again");
Console.WriteLine("Please enter a character: ");
char opt = '.';

while (opt != 'q')
{

    opt = Console.ReadKey().KeyChar;
    if (opt == 'h')
    {
        Console.WriteLine("Options:\r\n\ts: Start a server on port 727 using regular protocol\r\n\tj: Start a server on port 728 using JSON-parsing" +
    "\r\n\th: Help, print this menu again");
    }
    else if (opt == 's')
    {
        Server s = new Server();
        s = new Server();
        s.Start();
    }
    else if (opt == 'j')
    {
        ServerJSON s = new ServerJSON();
        s.Start();
    }
    else
    {
        Console.WriteLine("That was not a valid key, please try again");
    }


}

