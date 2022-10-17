using System;
using System.Collections.Generic;
using System.Text;

namespace Game_with_interfaces
{
    public class Shelf : IContainer, IStaticItem
    {
        Point _point;

        public bool CheckPosition(Point p)
        {
            return _point == p;
        }
        
        public void SetPositionInWorld(Point p)
        {
            _point = p;
        }

        public void Interact()
        {
            /*Проиграть анимацию открытия*/
            Console.WriteLine("Playing shelf animation");
        }

        public void Store()
        {
            Console.WriteLine("Store Items");
        }
    }
}