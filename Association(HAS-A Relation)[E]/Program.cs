using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Association_HAS_A_Relation__E_
{
    class Program
    {
        static void Main(string[] args)
        {
            //1-1 Relation
            //Address address1 = new Address(20,10,"Dhaka");
            //Account account1 = new Account(1001,"Shakib",2000,address1);
            //account1.PrintAccount();

            //Account account2 = new Account(2002, "Tamim", 3000, new Address(40, 30, "Chittagong"));
            //account2.PrintAccount();
            //Console.WriteLine(account2.Address.City);

            //1-* Relation
            Bank ourBank = new Bank("Developers Bank", 5);
            ourBank.AddAccount(new Account(1001, "Shakib", 2000, new Address(20, 10, "Dhaka")));
            ourBank.AddAccount(new Account(2002, "Tamim", 3000, new Address(40, 30, "Chittagong")));
            ourBank.AddAccount(new Account(3003, "Mushfiq", 4000, new Address(40, 30, "Chittagong")));
            //ourBank.PrintAllAccount();
            //ourBank.SearchAccount(2002);
            ourBank.DeleteAccount(2002);
        }
    }
}
