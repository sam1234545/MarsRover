

namespace MarsRover
{
    internal interface IDirection
    {
        internal  Rover MoveForward(Rover rover );
        internal  Rover MoveBackward(Rover rover);
        internal  IDirection TurnRight();
        internal  IDirection TurnLeft();
    }
}
