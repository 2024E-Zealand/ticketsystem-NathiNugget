// See https://aka.ms/new-console-template for more information
using System.Security.Cryptography.X509Certificates;
using System.Text.Json;
using System.Threading.Channels;
using TCPServerObligatiryAssignment;

//Server s = new Server();
ServerJSON s = new ServerJSON(); 
s.Start(); 