using System.Globalization;
using System.Runtime.InteropServices;

namespace csqaralama;

partial class Program
{

    public class Teacher
    {
        private string _name;
        private double _value;
        private short _telebeCount;

        public string Name
        {
            get { return _name; }
            set { _name = value; }
        }

        public double Value
        {
            get { return _value; }
            set { _value = value; }
        }

        public short TelebeCount
        {
            get { return _telebeCount; }
            set { _telebeCount = value; }
        }

        public Teacher(string name, double value, short telebeCount)
        {
            Name = name;
            Value = value;
            TelebeCount = telebeCount;
        }

        public double Salary() {
            return _value * _telebeCount;
        }

        public override string ToString()
        {
            return $"{Name}:\t ${Value} * {TelebeCount} = {Salary()}";
        }
    }

    static int FindSameName(string name, Teacher[] teachers)
    {
        int x = 0;
        foreach (Teacher t in teachers) {if (t.Name == name) x++;}
        return x;
    }

    static void Main()
    {
        Teacher[] teachers = {new("Vasif", 2.32, 12), new("Vasif", 2.32, 32), new("Revan", 32.3, 68), new("Cavad", 343.23, 55)};
        double x = 0;
        foreach (var teacher in teachers) { x += teacher.Salary(); }
        foreach (var teacher in teachers) { Console.WriteLine(teacher); }
        Console.WriteLine($"Total salary {x}");

        Console.WriteLine(FindSameName("Vasif", teachers));

    }


}
