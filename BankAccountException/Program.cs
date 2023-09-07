using BankAccountException.Entities;
using BankAccountException.Entities.Exception;
using System;
using System.Data;
using System.Security.Principal;

namespace BankAccountException
{
    class Program
    {
        static void Main(string[] args)
        {
            Account account = ReceberDados();
            UpdateBalance(account);
            //View(account);
        }

        static Account ReceberDados()
        {
            Account account;
            try
            {
                Console.Write("Account details\nAccount number: ");
                var number = int.Parse(Console.ReadLine());

                Console.Write("Holder: ");
                var holder = Console.ReadLine();

                Console.Write("Initial balance: ");
                var balance = double.Parse(Console.ReadLine());

                Console.Write("Withdraw limit: ");
                var withdraw = double.Parse(Console.ReadLine());

                account = new Account(number, holder, balance, withdraw);
                return account;
            }
            catch (DomainException a)
            {
                Console.WriteLine("Error: ");
            }
            return null;
        }

        static void UpdateBalance(Account x)
        {
            try
            {
                Console.Write("\nHow much do you want to withdraw (): ");
                var withdraw = double.Parse(Console.ReadLine());

                x.Withdraw(withdraw);
                Console.WriteLine(x);
            }
            catch(DomainException a)
            {
                Console.WriteLine("Withdraw error: " + a.Message);
            }            
        }

        static void View(Account a)
        {
            Console.WriteLine(a);
        }
    }
}