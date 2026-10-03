namespace BankingSystem.Models;

public class CurrentAccount : BankAccount
{
    public decimal OverdraftLimit { get; private set; }

    public CurrentAccount(
        string accountNumber,
        string ownerName,
        decimal initialBalance,
        decimal overdraftLimit
    ) : base(accountNumber, ownerName, initialBalance)
    {
      //To store the value
        OverdraftLimit = overdraftLimit;
    }
    //polymorphism overriding the withdraw method to allow overdraft
    // POLYMORPHISM:
// CurrentAccount overrides Withdraw()
// because it has different withdrawal rules.(overdraft limit)
public override void Withdraw(decimal amount)
{
    if (amount > 0)
    {
        if (amount <= Balance + OverdraftLimit)
        {
            Balance -= amount;
        }
    }
}
}