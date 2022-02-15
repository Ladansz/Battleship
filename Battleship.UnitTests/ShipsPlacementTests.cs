using NUnit.Framework;
using System.Collections.Generic;
using System.Linq;
using System.Drawing;

namespace Battleship.UnitTests
{
    public class ShipsPlacementTests
    {
        private Ship _ship, _horizentalShip, _verticalShip;
        private List<Ship> _shipList;
        private ShipsPlacement _shipsPlacement;
        private Point _shipHead;
        private List<Point> _occupiedPoints;

        [SetUp]
        public void Setup()
        {
            _shipHead = new Point(2, 4);
            _horizentalShip = new Ship(ShipType.Submarine, 2, false);
            _verticalShip = new Ship(ShipType.Submarine, 2, true);
            _occupiedPoints = new List<Point> { new Point(1, 3), new Point(1, 4) };
            _ship = new Ship(ShipType.Submarine, 2, true, _occupiedPoints);
            _shipList = new List<Ship>
            {
                _ship
            };
            _shipsPlacement= new ShipsPlacement(_shipList);
        }

        [Test]
        [TestCase(5)]
        public void GenerateRandomInt_WhenCalled_GenerateValidRandom(int length)
        {
            int random = _shipsPlacement.GenerateRandomInt(length);
            Assert.That(Enumerable.Range(0, 9).Contains(random));
        }

        [Test]
        public void GetShipPoints_WhenCalled_ValidPointsForHorizentalShip()
        {
            List<Point> shipPoints = _shipsPlacement.GetShipPoints(_shipHead, _horizentalShip);
            List<Point> expectedPoints = new List<Point> { new Point(2, 4), new Point(3, 4) };
            Assert.That(shipPoints.All(expectedPoints.Contains));
        }

        [Test]
        public void PointsAreOccupied_WhenCalled_ReturnTrue()
        {
            //List<Point> points = new List<Point> { new Point(1, 3), new Point(1, 4) };
            bool b = _shipsPlacement.PointsAreOccupied(_occupiedPoints);
            Assert.That(b);
        }

        [Test]
        public void GetShipPoints_WhenCalled_ValidPointsForVerticalShip()
        {
            List<Point> shipPoints = _shipsPlacement.GetShipPoints(_shipHead, _verticalShip);
            List<Point> expectedPoints = new List<Point> { new Point(2, 4), new Point(2, 5) };
            Assert.That(shipPoints.All(expectedPoints.Contains));
        }
    }
}