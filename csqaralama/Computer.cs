namespace csqaralama;
partial class Program
{
    public class Computer
    {
        private string _processor;
        private int _ram;
        private int _storage;
        private string _display;
        private string _keyboard;

        public string Processor { get { return _processor; } set { _processor = value; } }
        public int Ram { get { return _ram; } set { _ram = value; } }
        public int Storage { get { return _storage; } set { _storage = value; } }
        public string Display { get { return _display; } set { _display = value; } }
        public string Keyboard { get { return _keyboard; } set { _keyboard = value; } }

        public Computer(string processor, int ram, int storage, string display, string keyboard)
        {
            Processor = processor;
            Ram = ram;
            Storage = storage;
            Display = display;
            Keyboard = keyboard;
        }

        public override string ToString()
        {
            return $"{_processor}\n{_ram}GB ram\n{_storage}GB storage\n{_display}px display\n{_keyboard} keyboard";
        }

    
    }
}

