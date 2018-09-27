using System;

class Program
{
    static void Main(string[] args)
    {
        var bankAccount = new BankAccount();
        bankAccount.Id = 1;
        bankAccount.Balance = 15;

        var toString = bankAccount.ToString();
        Console.WriteLine(bankAccount);
    }
}