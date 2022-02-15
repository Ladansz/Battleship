using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Battleship
{
    public class ShipsPlacement
    {
        //public Dictionary<Ship, List<Point>> AllOccupiedPoints{ get; private set; }
        public List<Ship> Ships { get; private set; }

        public ShipsPlacement(List<Ship> ships) 
        {
            this.Ships = ships;
            PlaceShipsOnBoard();
        }

        public void PlaceShipsOnBoard()
        {
            foreach(var ship in Ships)
            {
                if(!ship.Location.Any())
                    PlaceShip(ship);
            }
        }

        private void PlaceShip(Ship ship)
        {
            List<Point> points = new List<Point>();
            do
            {
                Point head = GenerateHeadCoordinate(ship);
                points = GetShipPoints(head, ship);
            }
            while (PointsAreOccupied(points));
            ship.Location = points;
            //AllOccupiedPoints.Add(ship, ship.Location);
        }

        private Point GenerateHeadCoordinate(Ship ship)
        {
            Random rnd = new Random();
            int x, y;
            if (ship.IsVertical)
            {
                x = rnd.Next(0, 9);
                y = GenerateRandomInt(ship.Length);
            }
            else
            {
                x = GenerateRandomInt(ship.Length);
                y = rnd.Next(0, 9);
            }
            return new Point(x,y);
        }

        public bool PointsAreOccupied(List<Point> points)
        {
            //foreach(var op in AllOccupiedPoints)
            foreach (var ship in Ships)
            {
                if (ship.Location.Any(x => points.Any(y => y == x)))
                    return true;
            }
            return false;
        }

        public List<Point> GetShipPoints(Point head, Ship ship)
        {
            List<Point> shipPoints = new List<Point>();
            if (ship.IsVertical)
            {
                for (int i = head.Y; i < (head.Y + ship.Length); i++)
                {
                    shipPoints.Add(new Point(head.X, i));
                }
            }
            else
            {
                for (int i = head.X; i < (head.X + ship.Length); i++)
                {
                    shipPoints.Add(new Point(i, head.Y));
                }
            }

            return shipPoints;
        }

        public int GenerateRandomInt(int shipLength)
        {
            Random rnd = new Random();
            int i;
            do
            {
                i = rnd.Next(0, 10);
            }
            while (i + shipLength > 9);
            return i;
        }
    }
}
