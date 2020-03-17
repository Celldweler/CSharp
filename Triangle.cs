using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharp
{
    class Triangle
    {
        double sideA, sideB, sideC;
        String title;

        public Triangle()
        {
        }

        public Triangle(double sideA, double sideB, double sideC, string title = "Triangle")
        {
            this.sideA = sideA;
            this.sideB = sideB;
            this.sideC = sideC;
            this.title = title;
        }

        public double SideA { get => sideA; set => sideA = value > 0 ? value : 0; }
        public double SideB { get => sideB; set => sideB = value > 0 ? value : 0; }
        public double SideC { get => sideC; set => sideC = value > 0 ? value : 0; }
        public string Title { get => title; set => title = value; }

        public bool IsTriangle()
        {
            bool result = false;
            if (
                (this.sideA + this.sideB > this.sideC) &&
                (this.sideB + this.sideC > this.sideA) &&
                (this.sideA + this.sideC > this.sideB)
                )
                result = true;

            return result;
        }

        public double GetPerimeter()
        {
            return this.sideA + this.sideB + this.sideC;
        }

        public double GetSquare()
        {
            double p = this.GetPerimeter() / 2;
            return Math.Sqrt(p * (p - this.sideA) * (p - this.sideB) * (p - this.sideC));
        }

        public double GetAngle(double sideA, double sideB, double sideC)
        {
            return (180 / Math.PI) * Math.Acos((sideA * sideA + sideB * sideB - sideC * sideC) / (2 * sideA * sideB));
        }

        public override String ToString()
        {
            return
                this.IsTriangle()
                ?
                "Triangle: " + this.Title + " (" + this.SideA + ", " + this.SideB + ", " + this.SideC + ")" +
                "\nPerimeter: " + this.GetPerimeter() +
                "\nSquare: " + this.GetSquare() +
                "\nAngles:\n" + this.GetAngle(this.SideA, this.SideB, this.SideC) +
                "\n" + this.GetAngle(this.SideB, this.SideC, this.SideA) +
                "\n" + this.GetAngle(this.SideA, this.SideC, this.SideB)
                :
                this.Title + " (" + this.SideA + ", " + this.SideB + ", " + this.SideC + ")" + " is NOT triangle"
                ;
        }

        public void PrintInfo()
        {
            Console.WriteLine("Triangle: ({0}, {1}, {2})", this.SideA, this.SideB, this.SideC);
            Console.WriteLine(this.IsTriangle() ? "Triangle" : "NOT triangle");
            Console.WriteLine(this.GetPerimeter());
            Console.WriteLine(this.GetSquare());
            Console.WriteLine(this.GetAngle(this.SideA, this.SideB, this.SideC));
            Console.WriteLine(this.GetAngle(this.SideB, this.SideC, this.SideA));
            Console.WriteLine(this.GetAngle(this.SideA, this.SideC, this.SideB));

            Console.WriteLine(this.ToString());
        }
    }
}
