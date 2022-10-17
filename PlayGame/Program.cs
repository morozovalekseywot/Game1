using System;
using Game_with_interfaces;

namespace PlayGame
{
    internal class Program
    {
        public static void Main(string[] args)
        {
            Game game = new Game();
            game.SetManually(new Point(1.0, 1.0, 1.0), new Point(1.0, 5.0, 0.0), new Point(0.0, 0.0, 0.0));
            bool flag = false;
            while (!flag)
            {
                for (double x = -1; x <= 1.0; x += 1e-2)
                {
                    flag = game.Interact(new Point(x, 0.0, 0.0));
                    if (flag)
                    {
                        Console.WriteLine(new Point(x, 0.0, 0.0));
                        break;
                    }
                }
            }
        }
    }
}