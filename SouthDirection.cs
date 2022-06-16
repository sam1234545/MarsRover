using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MarsRover
{
    internal class SouthDirection : IDirection
    {
        public override bool Equals(object obj)
        {
            return obj != null && obj.GetType() == this.GetType();

        }
        Rover IDirection.MoveForward(Rover rover)
        {

            return new Rover(
               new Point(
                 rover.GetPointX(),
                 rover.GetPointY() - 1
                 ),
                new SouthDirection()
                );
        }

          Rover IDirection.MoveBackward(Rover rover)
        {

            return new Rover(
               new Point(
                 rover.GetPointX(),
                 rover.GetPointY() + 1
                 ),
                new SouthDirection()
                );
        }

          IDirection IDirection.TurnRight()
        {
            return new WestDirection();
        }

          IDirection IDirection.TurnLeft()
        {
            return new EastDirection();
        }
    }
}
