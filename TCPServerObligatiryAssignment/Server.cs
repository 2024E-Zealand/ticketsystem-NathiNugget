using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http.Headers;
using System.Net.Sockets;
using System.Reflection;
using System.Runtime.CompilerServices;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace TCPServerObligatiryAssignment
{
    public class Server
    {
        private int _PORT = 727;

        public void Start()
        {
            TcpListener server = new TcpListener(_PORT);
            server.Start();

            Console.WriteLine($"Server is now listening on port: {_PORT}");
            while (true)
            {
                TcpClient socket = server.AcceptTcpClient();
                
                Task.Run(() =>
                {
                    Console.WriteLine($"Connected to: {socket.Client.LocalEndPoint}");
                    DoOneClient(socket);
                }); 
                
            }

        }

        private int[] ReadArgs(StreamReader sr)
        {
            string input = sr.ReadLine();
            return input.Split(' ').Select(int.Parse).ToArray();
        }

        private void DoOneClient(TcpClient socket)
        {
            StreamReader sr = new StreamReader(socket.GetStream());
            StreamWriter sw = new StreamWriter(socket.GetStream());
            int[] args = new int[2];

            while (true)
            {
                try
                {
                    string toDo = sr.ReadLine()!.Trim();

                    int result = 0;
                    string _printToConsole = ""; 
                    switch (toDo)
                    {
                        
                        case "Add":
                            {
                                Console.WriteLine(toDo);
                                sw.Write("Input numbers");
                                sw.Flush();
                                args = ReadArgs(sr);
                                result = args[0] + args[1];
                                _printToConsole = $"Add: {args[0]} + {args[1]}"; 
                                sw.Write(result);
                                sw.Flush();

                            }
                            break;
                        case "Random":
                            {
                                sw.Write("Input numbers");
                                sw.Flush();
                                args = ReadArgs(sr);
                                Random r = new Random();
                                result = r.Next(args[0], args[1] + 1);
                                _printToConsole = $"Random: {args[0]} and {args[1]}";
                                sw.Write(result);
                                sw.Flush();
                            }
                            break;
                        case "Subtract":
                            {
                                sw.Write("Input numbers");
                                sw.Flush();
                                args = ReadArgs(sr);
                                result = args[0] - args[1];
                                _printToConsole = $"Subtract: {args[0]} - {args[1]}";
                                sw.Write(result);
                                sw.Flush();

                            }
                            break;
                        default:
                            break;
                    }
                }

                catch (Exception e)
                {
                    Console.WriteLine("Client disconnected");
                    break; 
                }
                



            }



        }
    }
}
