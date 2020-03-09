using System;
using System.Globalization;



namespace CSharp
{
    class Program
    {
        IFormatProvider formatter = new NumberFormatInfo { NumberDecimalSeparator = "." };

        static void SumDecimalDigit(double f_d, double s_d)
        {
            Console.WriteLine($"Sum digits {f_d}, {s_d} -> " + (double)((double)f_d + (double)s_d));

        }
        static void Main(string[] args)
        {
            Console.Write("First number");
            double f_d = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine();
            Console.Write("Second number");
            double s_d = Convert.ToDouble(Console.ReadLine());
            SumDecimalDigit(f_d, s_d);
            Console.ReadKey();
        }
        
    }
}

