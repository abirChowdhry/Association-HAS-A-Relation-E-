using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Association_HAS_A_Relation__E_
{
    class Bank
    {
        private Account[] accounts;
        private string name;
        public Bank(string name,int size)
        {
            this.name = name;
            this.accounts = new Account[size];
        }

        public string Name
        {
            set { this.name = value; }
            get { return this.name; }
        }

        public Account[] Accounts
        {
            get { return this.accounts; }
        }

        public void AddAccount(Account account)
        {
            for(int i=0;i<accounts.Length;i++)
            {
                if (accounts[i] == null)
                {
                    accounts[i] = account;
                    break;
                }
            }
        }

        public void PrintAllAccount()
        {
            for (int i = 0; i < accounts.Length; i++)
            {
                if (accounts[i] == null)
                {
                    continue;
                }
                accounts[i].PrintAccount();
            }
        }

        public void SearchAccount(int accountNumber)
        {
            int flag = 0;
            for (int i = 0; i < accounts.Length; i++)
            {
                if (accounts[i] == null)
                {
                    continue;
                }
                else if (accounts[i].AccountNumber == accountNumber)
                {
                    accounts[i].PrintAccount();
                    flag = 0;
                    break;
                }
                else
                {
                    flag = 1;
                }
                
            }
            if(flag==1)
                Console.WriteLine("Account not found");
        }

        public void DeleteAccount(int accountNumber)
        {
            int flag = 0;
            for (int i = 0; i < accounts.Length; i++)
            {
                if (accounts[i] == null)
                {
                    continue;
                }
                else if (accounts[i].AccountNumber == accountNumber)
                {
                    accounts[i]= accounts[i+1];

                    flag = 0;
                    break;
                }
                else
                {
                    flag = 1;
                }

            }
            if (flag == 1)
                Console.WriteLine("Account not found");

            if (flag == 0)
                Console.WriteLine("Account Deleted");
        }
    }
}
