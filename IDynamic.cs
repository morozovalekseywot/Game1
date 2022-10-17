namespace Game_with_interfaces
{
    public interface IDynamic
    {
        void SetBeginPoint(Point p);

        Point GetPosition(double time);

        bool CheckPosition(Point p, double time);
    }
}