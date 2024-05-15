using System;
namespace csqaralama;

partial class Program
{
    public class Accountant
    {
        private Guid _name;
        private double _balance;
        private string _firstname;
        private string _email;
        private long _phoneNumber;

        public Guid Name => _name;
        public double Balance { get => _balance;
            set => _balance = value;
        }
        public string Firstname => _firstname;
        public string Email
        {
            get => _email;
            set
            {
                if (!value.Contains('@'))
                    throw new ArgumentException("Invalid email format");
                _email = value;
            }
        }

        public long PhoneNumber
        {
            get { return _phoneNumber; }
            set
            {
                if (value < 0 || value < Math.Pow(10, 12) || value >= Math.Pow(10, 13))
                    throw new ArgumentException("Phone number must be a positive integer with exactly 13 digits");
                _phoneNumber = value;
            }
        }

        public Accountant(Guid name, double balance, string firstname, string email, long phoneNumber)
        {
            _name = name;
            _balance = balance;
            _firstname = firstname;
            Email = email;
            PhoneNumber = phoneNumber;
        }

        public void AddBalance(double money)
        {
            if (money <= 0)
                throw new InvalidAmoutException("Invalid amout added");

            _balance += money;
        }

        public virtual void ExtractBalance(double money)
        {
            if (money <= 0)
                throw new InvalidAmoutException("Invalid amout added");

            _balance -= money;
            if (_balance <= 0)
                Console.WriteLine("You might consider adding money");
        }

        public override string ToString()
        {
            return $"Name: {Firstname}\nEmail: {Email}\nPhone Number: +{PhoneNumber}\nBalance: {Balance}";
        }
    }



}
