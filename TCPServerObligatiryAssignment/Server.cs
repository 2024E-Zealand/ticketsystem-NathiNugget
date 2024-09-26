using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Sockets;
using System.Reflection;
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
                Task.Run(() =>
                {
                    TcpClient socket = server.AcceptTcpClient();
                    DoOneClient(socket);

                });
            }

        }

        private int[] ReadArgs(StreamReader sr)
        {
            return sr.ReadLine().Split(' ').Select(int.Parse).ToArray();
        }

        private void DoOneClient(TcpClient socket)
        {
            StreamReader sr = new StreamReader(socket.GetStream());
            StreamWriter sw = new StreamWriter(socket.GetStream());
            int[] args = new int[2];

            while (true)
            {
                string toDo = sr.ReadLine()!.Trim();

                int result = 0;
                switch (toDo)
                {
                    case "Add":
                        {
                            sw.WriteLine("Input numbers");
                            sw.Flush(); 
                            args = ReadArgs(sr);
                            result = args[0] + args[1];
                            sw.WriteLine(result);
                            sw.Flush(); 

                        }
                        break;
                    case "Random":
                        {
                            sw.WriteLine("Input numbers"); 
                            sw.Flush();
                            args = ReadArgs(sr); 
                            Random r = new Random();
                            result = r.Next(args[1]+1, args[0]);
                            sw.WriteLine(result);
                            sw.Flush();
                        }
                        break;
                    case "Subtract":
                        {
                            sw.WriteLine("Input numbers"); 
                            sw.Flush();
                            args = ReadArgs(sr);
                            result = args[0] - args[1];
                            sw.WriteLine(result);
                            sw.Flush();

                        }
                        break; 
                    default:
                        break;
                }



            }



        }
    }
}
