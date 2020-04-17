using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace nasled_37_c_sharp_GUI
{
    class SquarePrizm : Square
    {
        double height;

        public SquarePrizm()
        {

        }

        public SquarePrizm(string title, double side, double height)
        {
            base.Side = side;
            base.Title = title;
            Height = height;
        }

        public double GetVolume()
        {
            return this.height * base.GetSquare();
        }

        new public string ToString()
        {
            return this.Title + "\nside: " + this.Side +
            "\nheight: " + this.height +
            "\nsquare: " + this.GetSquare() +
            "\nvolume: " + this.GetVolume();
        }

        new public double GetSquare()
        {
            return base.GetSquare() * 6;
        }

        public double Height { get => height; set => height = value >= 0 ? value : 0; }
    }
}
