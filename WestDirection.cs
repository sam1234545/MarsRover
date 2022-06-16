using System.Drawing;


namespace MarsRover
{
    internal class WestDirection : IDirection
    {
        public override bool Equals(object obj)
        {
            return obj != null && obj.GetType() == this.GetType();

        }
        Rover IDirection.MoveForward(Rover rover)
        {

            return new Rover(
               new Point(rover.GetPointX() - 1, rover.GetPointY()),
                new WestDirection()
                );
        }

        Rover IDirection.MoveBackward(Rover rover)
        {

            return new Rover(
              new Point(rover.GetPointX() + 1, rover.GetPointY()),
                new WestDirection()
                );
        }

        IDirection IDirection.TurnRight()
        {
            return new NorthDirection();
        }

        IDirection IDirection.TurnLeft()
        {
            return new SouthDirection();
        }



    }
}
