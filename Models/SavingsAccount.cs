namespace BankingSystem.Models;
// INHERITANCE:
// SavingsAccount inherits the common properties
// and behaviors from BankAccount.
public class SavingsAccount : BankAccount
{
    public decimal InterestRate { get; private set; }
    // Parameterized constructor
     public SavingsAccount(
    string accountNumber,
    string ownerName,
    decimal initialBalance,
    decimal interestRate
) : base(accountNumber, ownerName, initialBalance)
{
    InterestRate = interestRate;
}
public void ApplyInterest()
{
    decimal interest = Balance * InterestRate / 100;

    Balance += interest;
}
// ABSTRACTION + POLYMORPHISM:
// SavingsAccount must implement Withdraw()
// because Withdraw is abstract in BankAccount.
// A savings account cannot withdraw more than its current balance.
public override void Withdraw(decimal amount)
{
    if (amount > 0)
    {
        if (Balance >= amount)
        {
            Balance -= amount;
        }
    }
}

}