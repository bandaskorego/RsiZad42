using Client.ServiceReference1;
using System;
using System.Collections.Generic;
using System.Linq;
using System.ServiceModel;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using WcfContract;

namespace Client
{
    class Program
    {
        static void Main(string[] args)
        {
            InstanceContext instanceContext = new InstanceContext(new mojCallbackHandler());

            // klient:    
            BankManagerClient client = new BankManagerClient(instanceContext);

            Console.WriteLine("Połączono.");

            Worker w = new Worker("Marek Panecki", 5000.0D);

            Console.WriteLine("Dodawanie workerow");

            client.addWorker(w);
            client.addWorker(new Worker("Marek Panecki", 7000.0D));

            Worker[] workers = client.getAll();
            Console.WriteLine("Ilosc powyzej 7000");
            client.getCountOfWorkersWithSalaryGreaterThen(7000D);
            Console.WriteLine("Najmniejsza pensja");
            client.getLowestPaidWorker();

            Thread.Sleep(7000);
            //Console.WriteLine(workers[0].ToString());
            Console.WriteLine("Koniec.");

            client.Close();

        }

        public class mojCallbackHandler : ServiceReference1.IBankManagerCallback
        {
            public void lowestPaid(Worker w)
            {
                Console.WriteLine("Najgorzej oplacany pracownik to ({0}, zarabia:{1} )", w.name,w.salary);
            }

            public void Wynik(int count)
            {
                Console.WriteLine("Rezultat({0})", count);
            }

        }
    }
}
