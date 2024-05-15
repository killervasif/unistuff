namespace csqaralama;

partial class Program
{
    public interface IPaymentMethod
    {
        void ProcessPayment(double amount);
    }
    public class CreditCard :IPaymentMethod 
    {
        public void ProcessPayment(double amount)
        {
            Console.WriteLine($"Processed credit card payment of ${amount}");
        }
    }
}
