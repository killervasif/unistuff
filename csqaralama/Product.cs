namespace csqaralama;

partial class Program
{
    public class Product
    {
        public string Name { get; set; }
        public int Count { get; set; }
        public int LowStockValue { get; set; }
        public double Price { get; set; }


        public Product(string name, int count,int low, double price)
        {
            Name = name;
            Count = count;
            LowStockValue = low;
            Price = price;            
        }

        public double Sum() {
            return Price * Count;
        }

        public string State()
        {
            return Count > LowStockValue ? "Stocked" : Count != 0 ? "Low on stock" : "Out of stock";
        }

        public override string ToString()
        {
            return $"{Name}:\t{Price}\t{Count} ({State()})\t${Sum()}";
        }
    }

    


}
