using System;

namespace Game_with_interfaces
{
    public class Target : IDynamicItem
    {
        private Point _beginPoint;

        public void SetBeginPoint(Point p)
        {
            _beginPoint = p;
        }

        // время предполагается в миллисекундах
        public Point GetPosition(double time)
        {
            return _beginPoint + new Point(1.0, 0.0, 0.0) * Math.Sin(2 * Math.PI / 1e4 * time);
        }

        public bool CheckPosition(Point p, double time)
        {
            return p == GetPosition(time);
        }

        public void Interact()
        {
            Console.WriteLine("Congratulations, you hit the target!!!");
        }
    }
}