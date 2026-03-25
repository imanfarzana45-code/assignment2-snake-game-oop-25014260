namespace snakegame
{
    public class Position
    {
        private int x;
        private int y;

        public int X
        {
            get { return x; }
            set { if (value >= 0) x = value; }
        }

        public int Y
        {
            get { return y; }
            set { if (value >= 0) y = value; }
        }

        public Position(int x, int y)
        {
            X = x;
            Y = y;
        }

        public void Move(int dx, int dy)
        {
            X += dx;
            Y += dy;
        }
    }
}