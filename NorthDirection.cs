using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MarsRover
{
    internal class NorthDirection : IDirection
    {

         Rover IDirection.MoveForward(Rover rover)
        {
           
            return  new Rover(
               new Point(
                 rover.GetPointX(),
                 rover.GetPointY() + 1
                 ),
                new NorthDirection()
                );
        }

          Rover IDirection.MoveBackward(Rover rover)
        {

            return new Rover(
               new Point(
                   rover.GetPointX(),
                 rover.GetPointY() -1
                 ),
                new NorthDirection()
                );
        }

          IDirection IDirection.TurnRight()
        {
           return new EastDirection();
        }

          IDirection IDirection.TurnLeft()
        {
            return new WestDirection();
        }

        public override bool Equals(object obj)
        {
           return  obj != null && obj.GetType() == this.GetType();
        
        }

        public override int GetHashCode()
        {
            return base.GetHashCode();
        }
    }
}
