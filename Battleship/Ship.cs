using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Drawing;

namespace Battleship
{
    public class Ship
    {
        public delegate void SunkHandler(Ship ship);
        public event SunkHandler Sunk;

        public ShipType Type { get; private set; }
        public bool IsVertical { get; set; }
        public int Length { get; private set; }
        public int LifeCount { get; set; }
        public List<Point> Location { get; set; }
        public List<Point> HitPoints { get; set; }

        public Ship(ShipType type, int length)
        {
            Type = type;
            IsVertical = GenerateRandomBool();
            LifeCount = length;
            Length = length;
            Location = new List<Point>();
            HitPoints = new List<Point>();
        }
        public Ship(ShipType type, int length, bool isVertical)
        {
            Type = type;
            IsVertical = isVertical;
            LifeCount = length;
            Length = length;
            Location = new List<Point>();
            HitPoints = new List<Point>();
        }
        public Ship(ShipType type, int length, bool isVertical, List<Point> location)
        {
            Type = type;
            IsVertical = isVertical;
            LifeCount = length;
            Length = length;
            Location = location;
            HitPoints = new List<Point>();
        }
        private bool GenerateRandomBool()
        {
            Random rnd = new Random();
            return rnd.Next(2) == 0;
        }
        public void IsSinking(Ship ship)
        {
            if (ship.LifeCount == 0)
                Sunk(ship);
        }
    }
}
