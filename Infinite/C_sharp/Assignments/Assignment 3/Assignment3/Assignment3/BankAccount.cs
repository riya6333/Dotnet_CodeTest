using System;
using System.Collections.Generic;


public class Accounts
{
    private int accountNo;
    private string customerName;
    private string accountType;
    private char transactionType;
    private double amount;
    private double balance;

    public Accounts(int accountNo, string customerName, string accountType)
    {
        this.accountNo = accountNo;
        this.customerName = customerName;
        this.accountType = accountType;
        this.balance = 0.0;
    }

    public void Credit(double amount)
    {
        balance += amount;
    }
    public void Debit(double amount)
    {
        if (amount <= balance)
        {
            balance -= amount;
        }
        else
        {
            throw new InvalidOperationException("Insufficient funds!");
        }
    }

    public void UpdateBalance(char transactionType, double amount)
    {
        this.transactionType = transactionType;
        this.amount = amount;

        if (transactionType == 'D')
        {
            Credit(amount);
        }
        else if (transactionType == 'W')
        {
            try
            {
                Debit(amount);
            }
            catch (InvalidOperationException ex)
            {
                Console.WriteLine(ex.Message);
            }
        }
        else
        {
            throw new ArgumentException("Invalid transaction type!");
        }
    }

    public void ShowData()
    {
        Console.WriteLine("Account Number: " + accountNo);
        Console.WriteLine("Customer Name: " + customerName);
        Console.WriteLine("Account Type: " + accountType);
        Console.WriteLine("Transaction Type: " + transactionType);
        Console.WriteLine("Amount: " + amount);
        Console.WriteLine("Balance: " + balance);
        Console.ReadLine();
    }
}
