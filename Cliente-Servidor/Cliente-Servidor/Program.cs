using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Net;
using System.Net.Sockets;

namespace Cliente_Servidor
{
    internal class Program
    {
        static void Main(string[] args)
        {
          Socket listen = new Socket(AddressFamily.InterNetwork, SocketType.Stream, ProtocolType.Tcp);
          IPEndPoint connect = new IPEndPoint(IPAddress.Parse("127.0.0.1"), 6400);
          
          listen.Connect(connect);
          byte[] enviar_info = new byte[100];
          string data;
          Console.WriteLine("Ingrese la informacion a enviar");
          data = Console.ReadLine();
          
          enviar_info = Encoding.Default.GetBytes(data);
          listen.Send(enviar_info);
          Console.ReadKey();

          
        }
    }
}
