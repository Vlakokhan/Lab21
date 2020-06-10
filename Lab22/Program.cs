using System;

namespace Lab22
{
    public class Program
    {
        static public double Calculation(double x)
        {
           double y = 5 * x * Math.Sin(x);
            return y;
        }
        static void Main(string[] args)
        {
            Console.WriteLine("Функцiя y = f(x) на промiжку [-3.14,3.14 ] з кроком dx = 0.314.\n\tx\t\ty = f(x)");
            double x = -Math.PI;
            double y;
            while (x <= Math.PI)
            {
                y = Calculation(x);
                Console.WriteLine("\t{0}\t\t{1}", x, y);
                x += Math.PI/10 ;
            }
            

        }
    }
} 

