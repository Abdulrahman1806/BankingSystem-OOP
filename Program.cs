using BankingSystem.Models;

// Create our first BankAccount object.
/*BankAccount account = new BankAccount(
    "ACC001",
    "Ahmed",
    5000
);
account.Deposit(1000);

Console.WriteLine(account.Balance);

account.Withdraw(1500);

Console.WriteLine(account.Balance);*/

SavingsAccount savings = new SavingsAccount(
    "SAV001",
    "Seno",
    5000,
    5
);
Console.WriteLine(savings.Balance);

savings.ApplyInterest();

Console.WriteLine(savings.Balance);

//Apply polymorphism to withdraw from a CurrentAccount object
//CurrentAccount current = new CurrentAccount(
//or
BankAccount current = new CurrentAccount(
    "CUR001",
    "Omar",
    1000,
    2000
);

Console.WriteLine(current.Balance);

current.Withdraw(2500);

Console.WriteLine(current.Balance);


/*using BankingSystem.Models;

// POLYMORPHISM:
// One BankAccount list can contain different child account types.
List<BankAccount> accounts = new List<BankAccount>();

accounts.Add(
    new SavingsAccount("SAV001", "Seno", 5000, 5)
);

accounts.Add(
    new CurrentAccount("CUR001", "Omar", 1000, 2000)
);


// POLYMORPHISM:
// The same Withdraw() call behaves differently
// depending on the real object type.
foreach (BankAccount account in accounts)
{
    Console.WriteLine($"Owner: {account.OwnerName}");
    Console.WriteLine($"Before: {account.Balance}");

    account.Withdraw(2000);

    Console.WriteLine($"After: {account.Balance}");
    Console.WriteLine("-------------------");
}*/