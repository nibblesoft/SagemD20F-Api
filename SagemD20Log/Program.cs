using System;
using System.Net;
using System.Net.Sockets;
using System.Text;

namespace SagemD20Log
{
    class Program
    {
        static void Main(string[] args)
        {
            // make a udp listener
            var udpClient = new UdpClient(514);

            while (true)
            {
                IPEndPoint endPointIp = null;
                Console.WriteLine("Waiting for logs...");
                byte[] data = udpClient.Receive(ref endPointIp);
                string dataString = Encoding.UTF8.GetString(data);
                Console.WriteLine(dataString);
            }

            // note: make sure router is configured ip matched to this computer/server
            // Management/System Log
        }
    }
}
