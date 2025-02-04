namespace _NET_Training;

public class InterestEarningAccount : BankAccount
{
    public InterestEarningAccount(string name, decimal initialBalance) : base(name, initialBalance) { }

    public override void PerformMonthEndTransactions()
    {
        if (Balance > 500m)
        {
            decimal interest = this.Balance * 0.02m;
            MakeDeposit(interest, DateTime.Now, "Apply monthly interest");
        }
    }
}
