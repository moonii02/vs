namespace _031_Property
{
    class Rect 
    {
        public int Width { get; set; }
        private int height;

        public int Height
        {
            get { return height; }
            set { if (value >= 0) height = value; }
        }

    }
    class Rectangle
    {
        private int width; int height;
        public void SetWidth(int w) { width = w; }
        public int GetWidth() { return width; }
        public void SetHeight(int h) { height = h; }
        public int GetHeight() { return height; }
    }
    internal class Program
    {
        static void Main(string[] args)
        {
            Rectangle r = new Rectangle();
            Rect r1 = new Rect():
            r1.
        }
    }
}
