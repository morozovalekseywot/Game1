using System;
using System.Diagnostics;

namespace Game_with_interfaces
{
    public class Game
    {
        private IStaticItem[] _staticItems;
        private IDynamicItem[] _dynamicsItems;
        private Stopwatch _stopwatch;

        public Game()
        {
            _staticItems = new IStaticItem[] { new Shelf(), new Lever() };
            _dynamicsItems = new IDynamicItem[] { new Target() };
            _stopwatch = new Stopwatch();
            _stopwatch.Start();
        }

        public void SetManually(Point shelf, Point lever, Point target)
        {
            _staticItems[0].SetPositionInWorld(shelf);
            _staticItems[1].SetPositionInWorld(lever);

            _dynamicsItems[0].SetBeginPoint(target);
        }

        private IInteractable CheckHit(Point p)
        {
            double currentTime = _stopwatch.ElapsedMilliseconds;
            foreach (var item in _staticItems)
                if (item.CheckPosition(p))
                    return item;

            foreach (var item in _dynamicsItems)
                if (item.CheckPosition(p, currentTime))
                    return item;

            return null;
        }

        public bool Interact(Point p)
        {
            IInteractable item = CheckHit(p);
            if (item is null)
            {
                // Console.WriteLine("Miss click");
                return false;
            }

            item.Interact();
            if (item is IContainer container)
                container.Store();

            return true;
        }
    }
}