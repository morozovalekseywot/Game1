using System;
using System.Collections.Generic;
using System.Text;

namespace Game_with_interfaces
{
    public class Lever : IStaticItem
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
            /*проиграть анимацию поворота*/
            Console.WriteLine("Playing lever animation");
        }
    }
}