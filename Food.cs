using System;

namespace snakegame
{
    public class Food
    {
        private Position pos;
        private static Random rnd = new Random();

        public Position Pos
        {
            get { return pos; }
        }

        public Food(int maxX, int maxY)
        {
            pos = new Position(rnd.Next(0, maxX), rnd.Next(0, maxY));
        }

        public void Respawn(int maxX, int maxY)
        {
            pos = new Position(rnd.Next(0, maxX), rnd.Next(0, maxY));
        }
    }
}