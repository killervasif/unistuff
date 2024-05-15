using System;
partial class Program {
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

    public double Salary()
    {
        return _value * _telebeCount;
    }

    public override string ToString()
    {
        return $"{Name}:\t ${Value} * {TelebeCount} = {Salary()}";
    }
    }
}
