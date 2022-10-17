using System;
using System.Collections.Generic;
using System.Text;

namespace Game_with_interfaces
{
    public  interface IPositionable
    {
        void SetPositionInWorld(Point p);
        bool CheckPosition(Point p);
    }
}
