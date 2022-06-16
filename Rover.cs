using System;
using System.Collections.Generic;
using System.Drawing;

namespace MarsRover
{
    internal class Rover : IEquatable<Rover>
    {
        private Point point;
        //  private char direction;

        private IDirection direction;


        public Rover(Point point, IDirection direction)
        {
            this.point = point;
            this.direction = direction;

        }


        internal int GetPointX()
        {
            return this.point.X;
        }
        internal int GetPointY()
        {
            return this.point.Y;
        }

        internal IDirection GetDirection()
        {
            return this.direction;
        }


        internal Rover MoveForward()
        {
            if (this.direction is not null)
            {
                return this.direction.MoveForward(new Rover(this.point, this.direction));
            }
            else throw new NotImplementedException();
        }


        internal Rover MoveBackward()
        {
            if (this.direction is not null)
            {

                return this.direction.MoveBackward(new Rover(this.point, this.direction));
            }
            else throw new NotImplementedException();
        }

        internal Rover TurnRight()
        {
            this.direction = this.direction.TurnRight();
            return new Rover(this.point, this.direction);
        }

        internal Rover TurnLeft()
        {
            this.direction = this.direction.TurnLeft();
            return new Rover(this.point, this.direction);
        }


        public bool Equals(Rover other)
        {
            var t = other != null &&
                    point.Equals(other.point) &&
                   EqualityComparer<IDirection>.Default.Equals(direction, other.direction);
            return t;
        }

        public override int GetHashCode()
        {
            return HashCode.Combine(point, direction);
        }

    }
}