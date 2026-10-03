namespace BankingSystem.Models;
//public class BankAccount (you can here write BankAccount account = new BankAccount(...); but it's wrong with abstract we should use (BankAccount account = new CurrentAccount(...);) )
public abstract class BankAccount
{
    public int Id { get; set; }

    public string AccountNumber { get; set; }

    public string OwnerName { get; set; }

    public decimal Balance { get; protected set; }

// Constructor
// Runs automatically when a new BankAccount object is created.
public BankAccount(string accountNumber, string ownerName, decimal initialBalance)
{
    // Do not allow an account to start with a negative balance.
    if (initialBalance < 0)
    {
        throw new ArgumentException("Initial balance cannot be negative.");
    }

    AccountNumber = accountNumber;
    OwnerName = ownerName;
    Balance = initialBalance;
}

    // Deposit money into the account
    public void Deposit(decimal amount)
    {
        if (amount > 0)
        {
            Balance += amount;
        }
    }

    // Withdraw money only if the amount is valid
// and the account has enough balance.

  // WITHDRAW:
    // We will change this to an abstract method.
    // Every account type will define its own withdrawal rules.
/*public virtual void Withdraw(decimal amount)//"Virtual" means this is the base `Withdraw` method, but the child class is allowed to override it and change its behavior.
{
    if (amount > 0)
    {
        if (Balance >= amount)
        {
            Balance -= amount;
        }
    }
}*/

    public abstract void Withdraw(decimal amount);
}