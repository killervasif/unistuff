namespace csqaralama;

partial class Program
{
    public class Box {

        public int Length { get; set; }
        public int Width { get; set; }
        public int Height { get; set; }

        public Box(int len, int wid, int height)
        {
            Length = len;
            Width = wid;
            Height = height;
        }

        
        public int Hecm()
        {
            return Length * Width * Height;
        }

    }
}
