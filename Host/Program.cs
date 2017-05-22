using System;
using System.Collections.Generic;
using System.Linq;
using System.ServiceModel;
using System.ServiceModel.Description;
using System.Text;
using System.Threading.Tasks;
using WcfContract;

namespace Host
{
    class Program
    {
        static void Main(string[] args)
        {
            /*
                        // Krok 1 Utworz URI dla bazowego adresu serwisu.       
                        Uri baseAddress = new Uri("http://localhost:10003/Host1");
                        // Krok 2 Utworz instancje serwisu.       
                        ServiceHost mojHost = new ServiceHost(typeof(BankManager), baseAddress);

                        String baseAddress2 = "net.tcp://localhost:20003/SerwisTCP";
                        ServiceEndpoint endpoint2 = mojHost.AddServiceEndpoint(typeof(IBankManager), new NetTcpBinding(), baseAddress2);

                        WSHttpBinding mojBanding = new WSHttpBinding();
                        mojHost.AddServiceEndpoint(typeof(IBankManager), mojBanding, "startEndPoint1");

                        ServiceMetadataBehavior smb = new ServiceMetadataBehavior();
                        smb.HttpGetEnabled = true;
                        mojHost.Description.Behaviors.Add(smb);
            */

            Uri baseAddress = new Uri("http://localhost:10003");
            ServiceHost mojHost = new ServiceHost(typeof(BankManager), baseAddress);
            ServiceEndpoint endpoint = mojHost.AddServiceEndpoint(typeof(IBankManager), new WSDualHttpBinding(), "BankManagerSerwis");

            // Metadane: 
            ServiceMetadataBehavior smb = new ServiceMetadataBehavior();
            smb.HttpGetEnabled = true;
            mojHost.Description.Behaviors.Add(smb); 

            try {
                mojHost.Open();
                Console.WriteLine("Serwis 1 jest uruchomiony.");
                Console.WriteLine("Nacisnij <ENTER> aby zakonczyc.");
                Console.WriteLine(); Console.ReadLine();
                mojHost.Close();
            } catch (CommunicationException ce)
            {
                Console.WriteLine("Wystapil wyjatek: {0}", ce.Message);
                mojHost.Abort();
            }




            /*
            Uri baseAddress = new Uri("http://localhost:10003/Host1");
            ServiceHost mojHost = new ServiceHost(typeof(BankManager), baseAddress);
            ServiceEndpoint endpoint = mojHost.AddServiceEndpoint(typeof(IBankManager), new WSDualHttpBinding(), "startEndPoint1");

            ServiceMetadataBehavior smb = new ServiceMetadataBehavior();
            smb.HttpGetEnabled = true;
            mojHost.Description.Behaviors.Add(smb);
            */
            /*
                        Uri baseAddress = new Uri("http://localhost:10003");
                        ServiceHost mojHost = new ServiceHost(typeof(BankManager), baseAddress);
                        ServiceEndpoint endpoint = mojHost.AddServiceEndpoint(typeof(IBankManager), new WSDualHttpBinding(), "BankManagerSerwis");
                        // Metadane:

                        ServiceMetadataBehavior smb = new ServiceMetadataBehavior();
                        smb.HttpGetEnabled = true;
                        mojHost.Description.Behaviors.Add(smb); 
                        try
                        {
                            mojHost.Open();
                            Console.WriteLine("Serwis 1 jest uruchomiony.");
                            Console.WriteLine("Nacisnij <ENTER> aby zakonczyc.");
                            Console.WriteLine();
                            Console.ReadLine();
                            mojHost.Close();
                        }
                        catch (CommunicationException ce)
                        {
                            Console.WriteLine("Wystapil wyjatek: {0}", ce.Message);
                            mojHost.Abort();
                        }
                        */

            /*
            mojHost.Open();

            Console.WriteLine("Serwis jest uruchomiony.");
            Console.WriteLine("Nacisnij <ENTER> aby zakonczyc.");
            Console.WriteLine();
            Console.ReadLine();

            mojHost.Close();

    */
        }
    }
}
