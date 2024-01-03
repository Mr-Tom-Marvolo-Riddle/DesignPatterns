namespace ProblemSolving.MarsRover
{
    public enum Direction
    {
        N,
        E,
        W,
        S
    }

    public enum Command
    {
        L,
        R,
        M
    }

    public class Position
    {
        #region Public Properties.

        public int X { get; set; }
        public int Y { get; set; }

        #endregion Public Properties.

        #region Constructors.

        public Position()
        {
        }

        public Position(int x, int y)
        {
            X = x;
            Y = y;
        }

        #endregion Constructors.
    }

    public class Rover
    {
        #region Public Properties.

        public Position Position { get; set; }
        public Direction Direction { get; set; }

        #endregion Public Properties.

        #region Constructor.

        public Rover(Position position, Direction direction)
        {
            Position = position;
            Direction = direction;
        }

        #endregion Constructor.
    }
}