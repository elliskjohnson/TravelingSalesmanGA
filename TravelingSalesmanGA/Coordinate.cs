using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TravelingSalesmanGA
{
    public class Coordinate
    {
		public int x;
		public int y;

		public Coordinate(int x, int y)
		{
			this.x = x;
			this.y = y;
		}

		public double GetDistanceFrom(Coordinate nextCoord)
		{
			return Math.Sqrt(Math.Pow(x - nextCoord.x, 2.0) + Math.Pow(y - nextCoord.y, 2.0));
		}

        public override string ToString()
        {
            return $"({x}, {y})";
		}

    }
}
