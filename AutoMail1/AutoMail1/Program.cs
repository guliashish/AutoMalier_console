using System;
using System.Collections;
using System.Net.NetworkInformation;
using System.Threading.Tasks;


namespace AutoMail1
{
    class Program
    {
        
        static void Main(string[] args)
        {
            

           string[] ServerList = new string[] { "www.google.com", "www.facebook.com" };


            Console.WriteLine( ServerStatus(ServerList));
        }

        static string ServerStatus(string[] serverList)
        {
            Ping pingSender = new Ping();
            PingReply reply = pingSender.Send(serverList[0]);
            Console.WriteLine("Status of Host: {0}", serverList[0]);
            if (reply.Status == IPStatus.Success)
            {
                 
                string ServerStatus = " "+ reply.Address.ToString() + " , " + reply.Status.ToString() + "  ";
                return ServerStatus;
            }
            else
            {
                string ServerStatus = " " + reply.Address.ToString() + " , " + reply.Status.ToString() + "  ";
                return ServerStatus;
            }
            
        }

    }

}

