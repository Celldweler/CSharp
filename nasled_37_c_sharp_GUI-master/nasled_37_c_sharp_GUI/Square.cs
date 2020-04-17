using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace nasled_37_c_sharp_GUI
{
    class Square
    {
        double side;
        string title;

        public Square()
        {
        }

        public Square(double side)
        {
            Side = side;
        }

        public Square(string title, double side)
        {
            this.title = title;
            Side = side;
        }

        public double GetDiagonal()
        {
            return side * Math.Sqrt(2);
        }

        public double GetPerimeter()
        {
            return side * 4;
        }

        public double GetSquare()
        {
            return side * side;
        }

        override public string ToString()
        {
            return this.Title + "\nside: " + this.Side + 
            "\ndiagonal: " + this.GetDiagonal() +
            "\nperimeter: " + this.GetPerimeter() + 
            "\nsquare: " + this.GetSquare() + "\n\n";
        }

        public double Side { get => side; set => side = value >= 0 ? value: 0; }
        public string Title { get => title; set => title = value; }
    }
}
