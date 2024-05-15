

namespace csqaralama;

partial class Program
{
    public class InvalidAmoutException : Exception
    {
        public InvalidAmoutException(string message) : base(message)
        {
        }
    }

    public class CheckingAccount : Accountant {
        public double Limit {  get; set; }
        public CheckingAccount(Guid name, double balance, string firstname, string email, long phoneNumber, double limit) 
            : base(name, balance, firstname, email, phoneNumber)
        {
            Limit = limit;
        }

        public override void ExtractBalance(double money)
        {
            if (money > Limit) 
                throw new InvalidAmoutException("Invalid amout added");
            base.ExtractBalance(money);
        } 


    }



}
