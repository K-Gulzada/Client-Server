using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Sockets;
using System.Text;
using System.Threading.Tasks;

namespace Server
{
    class Program
    {
        static void Main(string[] args)
        {
            TcpListener server = null;
            try
            {                
                int port = 5001;
                IPAddress localAddr = IPAddress.Parse("127.0.0.1");
                                
                server = new TcpListener(localAddr, port);
                                
                server.Start();
                                
                byte[] bytes = new byte[1024];               
                                
                while (true)
                {
                    Console.Write("Waiting for a connection... ");

                    TcpClient client = server.AcceptTcpClient();
                    Console.WriteLine("Connected!");
                    NetworkStream stream = client.GetStream();
                
                    
                    Console.WriteLine("Enter str");
                    string msg = Console.ReadLine();                    
                   
                    byte[] data = Encoding.UTF8.GetBytes(msg);
                                        
                    stream.Write(data, 0, data.Length);
                    Console.WriteLine("Sent: {0}", msg);
                    Console.ReadKey();
                                        
                    client.Close();
                }
            }
            catch (SocketException e)
            {
                Console.WriteLine("SocketException: {0}", e);
            }
            finally
            {                
                server.Stop();
            }
                        
            Console.Read();
        }
    }
}
