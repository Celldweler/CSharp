using System;
using System.IO;
using System.Threading.Tasks;
using System.Globalization;
//
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace CSharp
{
    class Program
    {

        static async Task Main(string[] args)
        {

            
            string path = @"C:\Users\King of maining\source\repos\CSharp\УсловиеЗадания.txt";

            using (StreamReader sr = new StreamReader(path, System.Text.Encoding.Default))
            {
                string line;
                while ((line = sr.ReadLine()) != null)
                {
                    Console.WriteLine(line);
                }
            }
            // асинхронное чтение
            using (StreamReader sr = new StreamReader(path, System.Text.Encoding.Default))
            {
                string line;
                while ((line = await sr.ReadLineAsync()) != null)
                {
                    Console.WriteLine(line);
                }
            }
            /*
           Triangle t1 = new Triangle();

           t1.SideA = 3;
           t1.SideB = 4;
           t1.SideC = 5;
           Console.WriteLine(t1.ToString());
           t1.PrintInfo();

           Triangle t2 = new Triangle(2, 6, 5, "T1");
           t2.PrintInfo();
           */

            int k = 3;
            Triangle[] triangles = new Triangle[k];
            Random r = new Random();
            double square = 0;
            int realTriangles = 0;

            for (int i = 0; i < k; i++)
            {
                triangles[i] = new Triangle(r.NextDouble() * 10, r.NextDouble() * 10, r.NextDouble() * 10, "T" + (i + 1).ToString());
                Console.WriteLine(triangles[i].ToString());
                if (triangles[i].IsTriangle())
                {
                    square += triangles[i].GetSquare();
                    realTriangles++;
                }
            }

            Console.WriteLine("Average square of " + realTriangles + " triangles is: " + square / realTriangles);
        }
    }
}

