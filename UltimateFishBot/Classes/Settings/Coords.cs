using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UltimateFishBot.Classes.Settings
{
    internal class Coords
    {
        public Coords(int x, int y)
        {
            this.X = x;
            this.Y = y;
        }

        public Coords()
        {
        }

        public int X { get; set; }
        public int Y { get; set; }

        public static implicit operator Point(Coords c)
        {
            return new Point(c.X, c.Y);
        }

        public static implicit operator Coords(Point p)
        {
            return new Coords(p.X, p.Y);
        }

        public override string ToString()
        {
            return $"{{{X} - {Y}}}";
        }
    }
}
