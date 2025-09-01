using Ej02;

var Account = new BankAccount(100);
Account.Deposit(50);
bool Ok = Account.WithDraw(30);

Console.WriteLine(Account.GetBalance());