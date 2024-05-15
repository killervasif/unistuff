namespace csqaralama;

partial class Program
{
    public class ECommercePlatform 
    { 
        List<Product> products=new List<Product>();
        List<Order> orders=new List<Order>();

        public void AddProduct(Product product)
        {
            products.Add(product);
        }

        public void DisplayProducts()
        {
            foreach (var product in products)
            {
                Console.WriteLine(product);
            }
        }

        public void CreateOrder(Order order)
        {
            orders.Add(order);
        }

        public void CancelOrder(Order order)
        {
            orders.Remove(order);
        }

        public void ProcessPayment(Order order, IPaymentMethod paymentMethod)
        {
            double total = order.CalculateTotal();
            paymentMethod.ProcessPayment(total);
        }

        public void DisplayOrders()
        {
            foreach (var order in orders)
            {
                Console.WriteLine($"Order Total: {order.CalculateTotal()}");
            }
        }
    }
}
