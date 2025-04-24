namespace _025_Susi_2
{
    class Rectangle
    {
        private double width, height;

        // 생성자 : 리턴값이 없고, 이름이 클래스와 같다
        public Rectangle(double w, double h)
        {
            width = w; height = h;
        }

        public Rectangle()
        {
            width = 0; height = 0;
        }

        public double GetArea() { return width * height; }

        public double GetPerimeter() { return width * 2 + height * 2; }

        public void SetWidth(double w)
        {
            if (w > 0)
                width = w;
            else
                Console.WriteLine("0보다 큰 값을 사용하세요.");
        }

        public void SetHeight(double h)
        {
            if (h > 0)
                height = h;
            else
                Console.WriteLine("0보다 큰 값을 사용하세요.");
        }
        internal class Program
        {
            static void Main(string[] args)
            {
                Rectangle r = new Rectangle();

                double w;
                while (true)
                {
                    Console.Write("가로 : ");
                    try
                    {
                        w = double.Parse(Console.ReadLine());
                        if (w > 0)
                        {
                            r.SetWidth(w);
                            break; 
                        }
                        else
                        {
                            r.SetWidth(w); 
                            continue; 
                        }
                    }
                    catch (FormatException)
                    {
                        Console.WriteLine("숫자를 입력하세요.");
                    }
                }
                double h;
                while (true)
                {
                    Console.Write("세로 : ");
                    try
                    {
                        h = double.Parse(Console.ReadLine());
                        if (h > 0)
                        {
                            r.SetHeight(h);
                            break;
                        }
                        else
                        {
                            r.SetHeight(h);
                            continue;
                        }
                    }
                    catch (FormatException)
                    {
                        Console.WriteLine("숫자를 입력하세요.");
                    }
                }

                Console.WriteLine("넓이 : {0}", r.GetArea());
                Console.WriteLine("둘레 : {0}", r.GetPerimeter());
            }
        }
    }
}
