using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Battleship
{
    public class Board
    {
        public int[] Rows { get; private set; }
        public int[] Columns { get; private set; }
        public List<Ship> Ships { get; private set; }
        public List<Ship> SunkShips { get; set; }

        public Board()
        {
            Rows = new int[] { 0, 1, 2, 3, 4, 5, 6, 7, 8, 9 };
            Columns = new int[] { 0, 1, 2, 3, 4, 5, 6, 7, 8, 9 };
            Ships = new List<Ship>()
            {
                new Ship(ShipType.Destroyer, 1),
                new Ship(ShipType.Carrier,5),
                new Ship(ShipType.Battleship, 4),
                new Ship(ShipType.Crusier, 3),
                new Ship(ShipType.Submarine, 2)
            };
            SunkShips = new List<Ship>();
            ShipsPlacement placement = new ShipsPlacement(Ships);
        }
    }
}
