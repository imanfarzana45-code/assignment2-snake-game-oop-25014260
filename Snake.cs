using System.Collections.Generic;

namespace snakegame
{
    public class Snake
    {
        private List<Position> body;

        public List<Position> Body
        {
            get { return body; }
        }

        public Snake(Position startPos)
        {
            body = new List<Position>();
            body.Add(startPos);
        }

        public void Move(int dx, int dy)
        {
            Position head = body[0];
            Position newHead = new Position(head.X + dx, head.Y + dy);

            body.Insert(0, newHead);
            body.RemoveAt(body.Count - 1);
        }

        public void Grow()
        {
            Position tail = body[body.Count - 1];
            body.Add(new Position(tail.X, tail.Y));
        }
    }
}