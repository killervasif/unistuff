namespace csqaralama;

partial class Program
{
    public class Customer
    {
        public int Id { get; set; }
        public double Points { get; set; }
        public string Name { get; set; }

        public Customer(int id, double points, string name)
        {
            Id = id;
            Points = points;
            Name = name;
        }

        public void AddPoints(double pts)
        {
            Points += pts;
        }
        public string Rank()
        {
            return Points > 500 ? "Diamond" : Points > 200 ? "Gold" : Points > 100 ? "Silver" : "Bronze";
        }

        public override string ToString()
        {
            return $"{Id}.{Name} {Points} pts. {Rank()} rank";
        }

    }


}
