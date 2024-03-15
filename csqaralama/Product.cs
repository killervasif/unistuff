namespace csqaralama;

partial class Program
{
    public class Product
    {
        public string Name { get; set; }
        public int Count { get; set; }
        public double Price { get; set; }

        public Product(string name, int count, double price)
        {
            Name = name;
            Count = count;
            Price = price;            
        }

        public double Sum() {
            return Price * Count;
        }

        public override string ToString()
        {
            return $"{Name}:\t{Price}\t{Count}\t${Sum()}";
        }
    }
}
