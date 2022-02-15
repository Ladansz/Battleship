using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Battleship
{
    public class Shot {

        public static int Count { get; set; }
        public Point ShotPoint { get; set; }
        public ShotStatus Status { get; set; }

        public Shot(Point point)
        {
            ShotPoint = point;
            Count = 50;
        }
    }
}
