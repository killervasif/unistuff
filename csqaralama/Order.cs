namespace csqaralama;

partial class Program
{
    public interface IOrder
    {
        void AddProduct(Product product);
        void RemoveProduct(Product product);
        double CalculateTotal();
    }
    
    public class Order: IOrder
    {
        private List<Product> products = new List<Product>();

        public Order(List<Product> products)
        {
            this.products = products;
        }

        public Order()
        {
        }

        public void AddProduct(Product product)
        {
            products.Add(product);
        }

        public void RemoveProduct(Product product)
        {
            products.Remove(product);
        }

        public double CalculateTotal()
        {
            double total = 0;
            foreach (var product in products)
            {
                total += product.Sum();
            }
            return total;
        }
    }
}
