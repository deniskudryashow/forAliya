using System;

namespace Square_Calc
{
    class SquareCalc // Calculate Square of Geometrical shapes

    {
        public float r, a, b, c, p;
        static public void Main(string[] args)
        {
            SquareCalc a = new SquareCalc();
            a.Circle();
            a.Triangle();
            Console.ReadKey();
        }
        public void Circle()
        {
            Console.WriteLine("Enter the Radius of the Circle");
            r = float.Parse(Console.ReadLine());
            Console.WriteLine("Area of Circle is:{0}", 3.14*r*r);
        }

        public void Triangle()
        {
            Console.WriteLine("Side A for Triangle ");
            a = float.Parse(Console.ReadLine());
            Console.WriteLine("Side B for Triangle ");
            b = float.Parse(Console.ReadLine());
            Console.WriteLine("Side C for Triangle ");
            c = float.Parse(Console.ReadLine());
            p = (a + b + c) / 2;
            Console.WriteLine("Area of Triangle is:{0}", (Math.Sqrt(p*(p-a)*(p-b)*(p-c))));

        }

    }
}
