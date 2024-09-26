using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Sockets;
using System.Text;
using System.Text.Json;
using System.Threading.Tasks;

namespace TCPServerObligatiryAssignment
{
    public class ServerJSON
    {

        private int _PORT = 728;

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

        

        private void DoOneClient(TcpClient socket)
        {
            StreamReader sr = new StreamReader(socket.GetStream());
            StreamWriter sw = new StreamWriter(socket.GetStream());
            int[] args = new int[2];

            while (true)
            {
                
                try
                {
                    string toDo = sr.ReadLine()!;
                    try
                    {
                        CommandJSON obj = JsonSerializer.Deserialize<CommandJSON>(toDo)!;
                        args[0] = obj.Num1;
                        args[1] = obj.Num2;
                        toDo = obj.Method;

                        int result = 0;
                        switch (toDo)
                        {
                            case "Add":
                                {
                                    result = args[0] + args[1];
                                    Console.WriteLine($"{toDo}: {args[0]} {args[1]} result: {result}");
                                    sw.Write(result);
                                    sw.Flush();

                                }
                                break;
                            case "Random":
                                {


                                    Random r = new Random();
                                    result = r.Next(args[0], args[1] + 1);
                                    Console.WriteLine($"{toDo}: {args[0]} {args[1]} result: {result}");
                                    sw.Write(result);
                                    sw.Flush();
                                }
                                break;
                            case "Subtract":
                                {


                                    result = args[0] - args[1];
                                    Console.WriteLine($"{toDo}: {args[0]} {args[1]} result: {result}");
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
                        sw.WriteLine("Hey, you wrote a command a didn't understand. Please write either Add, Subtract or Random and provide the promt in JSON format");
                        sw.Flush();
                        continue;
                    }
                }
                catch (Exception e) {
                    Console.WriteLine("Client disconnected");
                    break;
                }
                
                
                



            }



        }

    }
}
