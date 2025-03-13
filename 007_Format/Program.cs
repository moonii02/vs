﻿namespace _007_Format
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("안녕하세요!! C#입니다.");
            Console.WriteLine("10이하의 소수 : {0}, {1}, {2}, {3}",
                2, 3, 5, 7);

            string s 
                = string.Format("10이하의 소수 : {0}, {1}, {2}, {3}", 2, 3, 5, 7);

            Console.WriteLine(s);

            int v1 = 100;
            double v2 = 1.234;

            //Console.WriteLine(v1, v2);
            Console.WriteLine("v1 = " + v1 + ", v2 = " + v2);
            Console.WriteLine("v1 = {0}, v2 = {1}" , v1, v2);
            Console.WriteLine($"v1 = {v1}, v2 = {v2}");

            double x = 1234.5678;
            Console.WriteLine("{0:C}", x);
            Console.WriteLine("{0:E}", x);
            Console.WriteLine("{0:F2}", x); // 실수
            Console.WriteLine("{0:N2}", x); // 3자리마다 끊어서 ,를 넣어서 숫자 구분
            Console.WriteLine("{0:#,#.##}", x); 
        }
    }
}
