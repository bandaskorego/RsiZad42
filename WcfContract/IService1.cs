using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.Text;

namespace WcfContract
{
    // NOTE: You can use the "Rename" command on the "Refactor" menu to change the interface name "IBankManager" in both code and config file together.
    [ServiceContract(SessionMode = SessionMode.Required, CallbackContract = typeof(IBankManagerCallback))]
    public interface IBankManager
    {
        [OperationContract]
        void addWorker(Worker w);

        [OperationContract]
        Worker[] getAll();

        [OperationContract(IsOneWay = true)]
        void getCountOfWorkersWithSalaryGreaterThen(double avg);
    }

    public interface IBankManagerCallback
    {
        [OperationContract(IsOneWay = true)]
        void Wynik(int count);

    }


    [DataContract]
    public class Worker
    {
        string opis = "Worker";

        [DataMember]
        public int id;

        [DataMember]
        public double salary;

        [DataMember]
        public String name;

        [DataMember]
        public String image;

        [DataMember]
        public string Opis
        {
            get { return opis; }
            set { opis = value; }
        }

        public Worker(String name, double avg)
        {
            this.name = name;
            this.salary = avg;
        }

        public override string ToString()
        {
            return this.id + ") " + this.name + " - " + this.salary;
        }
    }
}


