using System.Globalization;
using System.Runtime.InteropServices;
using System;
using System.Numerics;
using static Program;
using static csqaralama.Program;

namespace csqaralama;


partial class Program
{
    static List<Accountant> accounts = new List<Accountant>();

    static void Main(string[] args)
    {
        Console.WriteLine("=== Welcome to Simple Bank & ATM ===");

        bool running = true;
        while (running)
        {
            Console.WriteLine("\n===== Main Menu =====");
            Console.WriteLine("1. Create New Account");
            Console.WriteLine("2. Log Into Existing Account");
            Console.WriteLine("0. Exit");
            Console.Write("Choose an option: ");
            string input = Console.ReadLine();

            switch (input)
            {
                case "1":
                    CreateAccount();
                    break;
                case "2":
                    LoginAccount();
                    break;
                case "0":
                    Console.WriteLine("Goodbye!");
                    running = false;
                    break;
                default:
                    Console.WriteLine("Invalid choice. Try again.");
                    break;
            }
        }
    }

    static void CreateAccount()
    {
        Console.WriteLine("\nSelect Account Type:");
        Console.WriteLine("1. Checking Account");
        Console.WriteLine("2. Saving Account");
        Console.Write("Enter choice: ");
        int type = int.Parse(Console.ReadLine());

        Console.Write("Enter first name: ");
        string firstname = Console.ReadLine();

        Console.Write("Enter email: ");
        string email = Console.ReadLine();

        Console.Write("Enter phone number (13 digits): ");
        long phone = long.Parse(Console.ReadLine());

        Console.Write("Enter starting balance: ");
        double balance = double.Parse(Console.ReadLine());

        Accountant account;
        if (type == 1)
        {
            Console.Write("Enter withdrawal limit: ");
            double limit = double.Parse(Console.ReadLine());
            account = new CheckingAccount(Guid.NewGuid(), balance, firstname, email, phone, limit);
        }
        else
        {
            Console.Write("Enter interest rate (%): ");
            int interest = int.Parse(Console.ReadLine());
            account = new SavingAccount(Guid.NewGuid(), balance, firstname, email, phone, interest);
        }

        accounts.Add(account);
        Console.WriteLine($"\nAccount created successfully! Your Account ID: {account.Name}");
    }

    static void LoginAccount()
    {
        if (accounts.Count == 0)
        {
            Console.WriteLine("No accounts available. Please create one first.");
            return;
        }

        while (true)
        {
            Console.WriteLine("\nAvailable Accounts:");
            for (int i = 0; i < accounts.Count; i++)
            {
                Console.WriteLine($"{i + 1}. {accounts[i].Firstname} (GUID: {accounts[i].Name})");
            }

            Console.Write("Select account number (or 0 to cancel): ");
            int accIndex = int.Parse(Console.ReadLine()) - 1;

            if (accIndex == -1)
            {
                Console.WriteLine("Returning to main menu.");
                return;
            }

            if (accIndex < 0 || accIndex >= accounts.Count)
            {
                Console.WriteLine("Invalid account selection. Try again.");
            }
            else
            {
                ATM atm = new ATM(accounts[accIndex]);
                RunATM(atm, accounts[accIndex]);
                break;
            }
        }
    }


    static void RunATM(ATM atm, Accountant account)
    {
        bool loggedIn = true;
        while (loggedIn)
        {
            Console.WriteLine("\n===== ATM Menu =====");
            Console.WriteLine("1. Show Account Info");
            Console.WriteLine("2. Deposit Money");
            Console.WriteLine("3. Withdraw Money");
            if (account is SavingAccount) Console.WriteLine("4. Apply Interest");
            Console.WriteLine("0. Logout");
            Console.Write("Choose an option: ");
            string input = Console.ReadLine();

            switch (input)
            {
                case "1":
                    atm.ShowInfo();
                    break;
                case "2":
                    Console.Write("Enter deposit amount: ");
                    double deposit = double.Parse(Console.ReadLine());
                    atm.Deposit(deposit);
                    break;
                case "3":
                    Console.Write("Enter withdrawal amount: ");
                    double withdraw = double.Parse(Console.ReadLine());
                    atm.Withdraw(withdraw);
                    break;
                case "4":
                    if (account is SavingAccount)
                        atm.ApplyInterestIfSavings();
                    else
                        Console.WriteLine("Interest option only available for Saving Accounts.");
                    break;
                case "0":
                    Console.WriteLine("Logged out.");
                    loggedIn = false;
                    break;
                default:
                    Console.WriteLine("Invalid option. Try again.");
                    break;
            }
        }
    }
}
