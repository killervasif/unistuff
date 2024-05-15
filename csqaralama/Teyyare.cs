partial class Program {
    public class Teyyare {
     
        public string Name { get; set; }
        public TimeOnly LeftOff { get; set; }
        public TimeOnly ArrivalTime { get; set;}
        public TimeOnly Arrival {  get; set;}

        public Teyyare(string name, TimeOnly leftOff, TimeOnly arrivalTime, TimeOnly arrival)
        {
            Name = name;
            LeftOff = leftOff;
            ArrivalTime = arrivalTime;
            Arrival = arrival;
        }

        public bool isLate() => Arrival > ArrivalTime ? true : false;

        public override string ToString()
        {
            return $"{Name}: {LeftOff}-{Arrival} {(isLate()?"Late":"Not late")}";
        }
    }
}
