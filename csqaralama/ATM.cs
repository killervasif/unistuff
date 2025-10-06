using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static csqaralama.Program;

namespace csqaralama
{
    internal class ATM
    {
        private Accountant _account;

        public ATM(Accountant account)
        {
            _account = account;
        }

        public void Deposit(double amount)
        {
            try
            {
                _account.AddBalance(amount);
                Console.WriteLine($"Deposited ${amount}. New balance: {_account.Balance}");
            }
            catch (InvalidAmoutException ex)
            {
                Console.WriteLine($"Error: {ex.Message}");
            }
        }

        public void Withdraw(double amount)
        {
            try
            {
                _account.ExtractBalance(amount);
                Console.WriteLine($"Withdrew ${amount}. New balance: {_account.Balance}");
            }
            catch (InvalidAmoutException ex)
            {
                Console.WriteLine($"Error: {ex.Message}");
            }
        }

        public void ShowInfo()
        {
            Console.WriteLine(_account.ToString());
        }

        public void ApplyInterestIfSavings()
        {
            if (_account is SavingAccount saving)
            {
                saving.InterestIncrease();
                Console.WriteLine($"Interest applied. New balance: {saving.Balance}");
            }
            else
            {
                Console.WriteLine("This account does not support interest.");
            }
        }
    }
}
