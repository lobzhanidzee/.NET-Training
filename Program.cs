using Classes;

var account = new BankAccount("Daviti", 1000);
try
{
    Console.WriteLine($"Account {account.Number} was created for {account.Owner} with {account.Balance} initial balance.");
    account.MakeDeposit(2131, DateTime.Now, "Second Transaction");
    Console.WriteLine($"Account {account.Number} was created for {account.Owner} with {account.Balance} initial balance.");
    account.MakeWithdrawal(3000, DateTime.Now, "Third Transaction");
    Console.WriteLine($"Account {account.Number} was created for {account.Owner} with {account.Balance} initial balance.");
    Console.WriteLine(account.GetAccountHistory());
}
catch (ArgumentOutOfRangeException e)
{
    Console.WriteLine("Exception caught creating account with negative balance");
    Console.WriteLine(e.ToString());
    return;
}
catch (InvalidOperationException e)
{
    Console.WriteLine("Exception caught trying to overdraw");
    Console.WriteLine(e.ToString());
}