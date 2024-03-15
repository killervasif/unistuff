namespace csqaralama;

partial class Program
{
    public class Worker
    {
        public int Id { get; set; }
        public int Age { get; set; }
        public int Salary { get; set; }

        public Worker(int id, int age, int salary)
        {
            Id = id;
            Age = age;
            Salary = salary;
        }
    }
}
