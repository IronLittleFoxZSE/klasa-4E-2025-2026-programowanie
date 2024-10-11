

using FirstObjectConsoleApp;

BankAccount firstAccount = new BankAccount();
firstAccount.balance = 10;
firstAccount.currency = "zł";
firstAccount.owner = "Jan Kowalski";

BankAccount secondAccount = new BankAccount();
secondAccount.balance = 20;
secondAccount.currency = "zł";
secondAccount.owner = "Ewa Nowak";

firstAccount.ShowInfo();
//showInfo(firstAccount);
secondAccount.ShowInfo();
//showInfo(secondAccount);

firstAccount.DepositToAccount(5);
firstAccount.ShowInfo();

secondAccount.WidthdrawalFromAccount(25);
secondAccount.ShowInfo();

firstAccount.TransferBetweenAccounts(ref secondAccount, 300);
firstAccount.ShowInfo();
secondAccount.ShowInfo();

