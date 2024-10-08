

using FirstObjectConsoleApp;

BankAccount firstAccount = new BankAccount();
firstAccount.balance = 10;
firstAccount.currency = "zł";
firstAccount.owner = "Jan Kowalski";

BankAccount secondAccount = new BankAccount();
secondAccount.balance = 20;
secondAccount.currency = "zł";
secondAccount.owner = "Ewa Nowak";

showInfo(firstAccount);
showInfo(secondAccount);

depositToAccount(ref firstAccount, -5);
showInfo(firstAccount);

widthdrawalFromAccount(ref secondAccount, 25);
showInfo(secondAccount);

transferBetweenAccounts(ref firstAccount, ref secondAccount, 300);
showInfo(firstAccount);
showInfo(secondAccount);

void showInfo(BankAccount account)
{
    Console.WriteLine("Informacja o koncie bankowym");
    Console.WriteLine($"Właściciel {account.owner}");
    Console.WriteLine($"Saldo {account.balance} {account.currency}");
}

void depositToAccount(ref BankAccount account, double amount)
{
    if (amount >= 0)
        account.balance = account.balance + amount;
}

bool widthdrawalFromAccount(ref BankAccount account, double amount)
{
    if (amount >= 0
        && amount <= account.balance)
    {
        account.balance = account.balance - amount;
        return true;
    }
    return false;
}

void transferBetweenAccounts(ref BankAccount sourceAccount, ref BankAccount targetAccount, double amount)
{
    if (widthdrawalFromAccount(ref sourceAccount, amount) == true)
        depositToAccount(ref targetAccount, amount);
}