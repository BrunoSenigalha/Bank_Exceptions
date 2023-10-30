using Bank_Exceptions.Entities;
using Bank_Exceptions.Entities.Exceptions;

try
{
    Console.WriteLine("Enter account data");
    Console.Write("Number: ");
    int number = Convert.ToInt32(Console.ReadLine());
    Console.Write("Holder: ");
    string holder = Console.ReadLine();
    Console.Write("Initial Balance: ");
    double initialBalance = Convert.ToDouble(Console.ReadLine());
    Console.Write("Withdraw limit: ");
    double withdrawLimit = Convert.ToDouble(Console.ReadLine());

    Account account = new Account(number, holder, initialBalance, withdrawLimit);

    Console.WriteLine();
    Console.Write("Enter amount for withdraw: ");
    double amount = Convert.ToDouble(Console.ReadLine());
    account.Withdraw(amount);
    Console.Write($"New Balance: {account.Balance.ToString("F2")}");
}
catch(DomainException e)
{
    Console.WriteLine("Withdraw error: " + e.Message);
}
catch(FormatException e)
{
    Console.WriteLine("Format error: " + e.Message);
}
catch (Exception)
{
    Console.WriteLine("Unknow error");
}
