using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MarsRover
{
    internal class EastDirection : IDirection
    {

        IDirection IDirection.TurnRight()
        {
            return new SouthDirection();
        }

        IDirection IDirection.TurnLeft()
        {
            return new NorthDirection();
        }

        Rover IDirection.MoveForward(Rover rover)
        {
            return new Rover(
               new Point(
                   rover.GetPointX() + 1,
                   rover.GetPointY()),
               new EastDirection()
               );
        }

        Rover IDirection.MoveBackward(Rover rover)
        {
            return new Rover(
              new Point(
                rover.GetPointX() - 1,
                rover.GetPointY()
                ),
               new EastDirection()
               );
        }
        public override bool Equals(object obj)
        {
            return obj != null && obj.GetType() == this.GetType();

        }
    }
}
