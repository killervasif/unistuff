namespace csqaralama;

partial class Program
{
    public class Accountant
    {
        private Guid _name;
        public Guid Name
        {
            get { return _name; }
            set { _name = value; }
        }

        private double _balance;
        public double Balance
        {
            get { return _balance; }
            set { _balance = value; }
        }

        public Accountant(Guid name, double balance)
        {
            Name = name;
            Balance = balance;
        }

        public override string ToString()
        {
            return $"{_name}: {_balance}";
        }
    }


}
