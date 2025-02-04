using _NET_Training;

var account = new BankAccount("Daviti", 1000);
try
{
    Console.WriteLine($"Account {account.Number} was created for {account.Owner} with {account.Balance} initial balance.");
    account.MakeDeposit(2131, DateTime.Now, "Second Transaction");
    account.MakeWithdrawal(3000, DateTime.Now, "Third Transaction");
    Console.WriteLine(account.GetAccountHistory());

    var giftCard = new GiftCardAccount("gift card", 100, 50);
    Console.WriteLine($"Account {giftCard.Number} was created for {giftCard.Owner} with {giftCard.Balance} initial balance.");
    giftCard.MakeWithdrawal(20, DateTime.Now, "get expensive coffee");
    giftCard.MakeWithdrawal(50, DateTime.Now, "buy groceries");
    giftCard.PerformMonthEndTransactions();
    giftCard.MakeDeposit(27.50m, DateTime.Now, "add some additional spending money");
    Console.WriteLine(giftCard.GetAccountHistory());

    var savings = new InterestEarningAccount("savings account", 10000);
    Console.WriteLine($"Account {savings.Number} was created for {savings.Owner} with {savings.Balance} initial balance.");
    savings.MakeDeposit(750, DateTime.Now, "save some money");
    savings.MakeDeposit(1250, DateTime.Now, "Add more savings");
    savings.MakeWithdrawal(250, DateTime.Now, "Needed to pay monthly bills");
    savings.PerformMonthEndTransactions();
    Console.WriteLine(savings.GetAccountHistory());

    var lineOfCredit = new LineOfCreditAccount("line of credit", 0, 2000);
    lineOfCredit.MakeWithdrawal(1000m, DateTime.Now, "Take out monthly advance");
    lineOfCredit.MakeDeposit(50m, DateTime.Now, "Pay back small amount");
    lineOfCredit.MakeWithdrawal(5000m, DateTime.Now, "Emergency funds for repairs");
    lineOfCredit.MakeDeposit(150m, DateTime.Now, "Partial restoration on repairs");
    lineOfCredit.PerformMonthEndTransactions();
    Console.WriteLine(lineOfCredit.GetAccountHistory());
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