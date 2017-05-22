using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.Text;
using System.Threading;

namespace WcfContract
{
    [ServiceBehavior(InstanceContextMode = InstanceContextMode.PerSession)]
    public class BankManager : IBankManager
    {
        Worker[] workers = new Worker[100];
        int count = 0;
        IBankManagerCallback callback = null;

        public BankManager()
        {
            callback = OperationContext.Current.GetCallbackChannel<IBankManagerCallback>();
        }

        public void addWorker(Worker w)
        {
            Console.WriteLine("Adding worker:");
            w.id = count;
            this.workers[count] = w;
            Console.WriteLine(this.workers[count]);
            count++;
            return;
        }

        public Worker[] getAll()
        {
            return this.workers;
        }

        public void getCountOfWorkersWithSalaryGreaterThen(double salary)
        {
            Console.WriteLine("Obliczam ilość studentów ze średnią wyższą niż: " + salary);
            int c = 0;
            for (int i = 0; i < this.count; i++)
            {
                if (this.workers[i].salary > salary) c++;
            }
            Thread.Sleep(3000);
            Console.WriteLine("Przekazuje wynik: " + c);
            callback.Wynik(c);
            return;
        }
    }
}
