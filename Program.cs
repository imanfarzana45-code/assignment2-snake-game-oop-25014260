using System;

namespace snakegame
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Snake Game Demo");

            // Create objects
            Position start = new Position(5, 5);
            Snake snake = new Snake(start);
            Food food = new Food(10, 10);

            // Show initial state
            Console.WriteLine("Initial Snake Position:");
            foreach (var p in snake.Body)
            {
                Console.WriteLine($"({p.X}, {p.Y})");
            }

            Console.WriteLine($"Food at: ({food.Pos.X}, {food.Pos.Y})");

            // Move snake
            snake.Move(1, 0);

            Console.WriteLine("After moving:");
            foreach (var p in snake.Body)
            {
                Console.WriteLine($"({p.X}, {p.Y})");
            }

            // Interaction: eat food
            if (snake.Body[0].X == food.Pos.X && snake.Body[0].Y == food.Pos.Y)
            {
                snake.Grow();
                food.Respawn(10, 10);
                Console.WriteLine("Snake ate food!");
            }

            Console.WriteLine("End of program");
        }
    }
}