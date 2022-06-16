using NUnit.Framework;
using System.Drawing;

namespace MarsRover
{
    public class Tests
    {
        [SetUp]
        public void Setup()
        {
        }

        [Test]
        public void Given_Position_N_and_Direction_then_MoveForward()
        {
            Rover rover = new Rover(new Point(0, 1), direction: new NorthDirection());
            Rover actual = rover.MoveForward();
            var result = new Rover(new Point(0, 2), new NorthDirection());
            Assert.That(actual, Is.EqualTo(result));

        }
        [Test]
        public void Given_Position_N_and_Direction_then_MoveBackward()
        {
            Rover rover = new Rover(new Point(0, 1), new NorthDirection());
            Rover actual = rover.MoveBackward();
            var result = new Rover(new Point(0, 0), rover.GetDirection());
            Assert.That(actual, Is.EqualTo(result));
        }
        [Test]
        public void Given_Position_S_and_Direction_then_MoveForward()
        {
            var rover = new Rover(new Point(0, 1), new SouthDirection());
            var actual = rover.MoveForward();
            var result = new Rover(new Point(0, 0), rover.GetDirection());
            Assert.That(actual, Is.EqualTo(result));

        }
        [Test]
        public void Given_Position_S_and_Direction_then_MoveBackward()
        {

            Rover rover = new Rover(new Point(0, 1), new SouthDirection());
            object actual = rover.MoveBackward();
            Rover result = new Rover(new Point(0, 2), new SouthDirection());
            Assert.That(actual, Is.EqualTo(result));

        }

        [Test]
        public void Given_Position_E_and_Direction_then_MoveForward()
        {

            Rover rover = new Rover(new Point(1, 0), new EastDirection());
            Rover actual = rover.MoveForward();
            Rover result = new Rover(new Point(2, 0), new EastDirection());
            Assert.That(actual, Is.EqualTo(result));

        }
        [Test]
        public void Given_Position_E_and_Direction_then_MoveBackward()
        {

            Rover rover = new Rover(new Point(1, 0), new EastDirection());
            object actual = rover.MoveBackward();
            Rover result = new Rover(new Point(0, 0), new EastDirection());
            Assert.That(actual, Is.EqualTo(result));

        }
        [Test]
        public void Given_Position_W_and_Direction_then_MoveForward()
        {

            Rover rover = new Rover(new Point(1, 0), new WestDirection());
            Rover actual = rover.MoveForward();
            Rover result = new Rover(new Point(0, 0), new WestDirection());
            Assert.That(actual, Is.EqualTo(result));

        }
        [Test]
        public void Given_Position_W_and_Direction_then_MoveBackward()
        {

            Rover rover = new Rover(new Point(1, 0), new WestDirection());
            object actual = rover.MoveBackward();
            Rover result = new Rover(new Point(2, 0), new WestDirection());
            Assert.That(actual, Is.EqualTo(result));

        }
        [Test]
        public void Given_Position_N_and_Direction_then_TurnRight()
        {
            Rover rover = new Rover(new Point(0, 1), new NorthDirection());
            Rover actual = rover.TurnRight();
            var result = new Rover(new Point(0, 1), new EastDirection());
            Assert.That(actual, Is.EqualTo(result));

        }
        public void Given_Position_N_and_Direction_then_Turnleftt()
        {
            Rover rover = new Rover(new Point(0, 1), new NorthDirection());
            Rover actual = rover.TurnLeft();
            var result = new Rover(new Point(0, 1), new WestDirection());
            Assert.That(actual, Is.EqualTo(result));

        }
        [Test]
        public void Given_Position_S_and_Direction_then_TurnRight()
        {
            Rover rover = new Rover(new Point(0, 1), new SouthDirection());
            Rover actual = rover.TurnRight();
            var result = new Rover(new Point(0, 1), new WestDirection());
            Assert.That(actual, Is.EqualTo(result));

        }
        [Test]
        public void Given_Position_S_and_Direction_then_TurnLeft()
        {
            Rover rover = new Rover(new Point(0, 1), new SouthDirection());
            Rover actual = rover.TurnLeft();
            var result = new Rover(new Point(0, 1), new EastDirection());
            Assert.That(actual, Is.EqualTo(result));

        }

        [Test]
        public void Given_Position_E_and_Direction_then_TurnRight()
        {
            Rover rover = new Rover(new Point(0, 1), new EastDirection());
            Rover actual = rover.TurnRight();
            var result = new Rover(new Point(0, 1), new SouthDirection());
            Assert.That(actual, Is.EqualTo(result));

        }
        [Test]
        public void Given_Position_E_and_Direction_then_TurnLeft()
        {
            Rover rover = new Rover(new Point(0, 1), new EastDirection());
            Rover actual = rover.TurnLeft();
            var result = new Rover(new Point(0, 1), new NorthDirection());
            Assert.That(actual, Is.EqualTo(result));

        }

        [Test]
        public void Given_Position_W_and_Direction_then_TurnRight()
        {
            Rover rover = new Rover(new Point(0, 1), new WestDirection());
            Rover actual = rover.TurnRight();
            var result = new Rover(new Point(0, 1), new NorthDirection());
            Assert.That(actual, Is.EqualTo(result));

        }
        [Test]
        public void Given_Position_W_and_Direction_then_TurnLeft()
        {
            Rover rover = new Rover(new Point(0, 1), new WestDirection());
            Rover actual = rover.TurnLeft();
            var result = new Rover(new Point(0, 1), new SouthDirection());
            Assert.That(actual, Is.EqualTo(result));

        }


    }
}
