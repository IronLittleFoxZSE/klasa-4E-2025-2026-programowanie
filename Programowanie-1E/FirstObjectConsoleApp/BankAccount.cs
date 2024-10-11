using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FirstObjectConsoleApp
{
    internal class BankAccount
    {
        public double balance; //saldo
        public string pin;
        public string owner; //właściciel
        public string currency; //waluta

        public void ShowInfo()
        {
            Console.WriteLine("Informacja o koncie bankowym");
            Console.WriteLine($"Właściciel {owner}");
            Console.WriteLine($"Saldo {balance} {currency}");
        }

        public void DepositToAccount(double amount)
        {
            if (amount >= 0)
                balance = balance + amount;
        }

        public bool WidthdrawalFromAccount(double amount)
        {
            if (amount >= 0
                && amount <= balance)
            {
                balance = balance - amount;
                return true;
            }
            return false;
        }

        public void TransferBetweenAccounts(ref BankAccount targetAccount, double amount)
        {
            if (WidthdrawalFromAccount(amount) == true)
                targetAccount.DepositToAccount(amount);
        }
    }
}
