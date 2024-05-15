
namespace csqaralama;

partial class Program
{
    public class SavingAccount : Accountant
    {
        public int Interest {  get; set; }
        public SavingAccount(Guid name, double balance, string firstname, string email, long phoneNumber ,int interest) 
            : base(name, balance, firstname, email, phoneNumber)
        {
            Interest = interest;
        }

        public void InterestIncrease()
        {
            double interestFraction = Interest / 100.0;
            Balance += Balance * interestFraction;
        }

        
    }



}
