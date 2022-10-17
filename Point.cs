using System;
using System.Collections.Generic;

namespace Game_with_interfaces
{
    public struct Point
    {
        private double _x, _y, _z;
        private const double _eps = 1e-8;
        
        public Point(double x, double y, double z)
        {
            _x = x;
            _y = y;
            _z = z;
        }


        public double Len()
        {
            return Math.Sqrt(_x * _x + _y * _y + _z * _z);
        }

        public bool Equals(Point other)
        {
            return Math.Abs(_x - other._x) + Math.Abs(_y - other._y) + Math.Abs(_z - other._z) < _eps;
        }

        public override bool Equals(object obj)
        {
            return obj is Point other && Equals(other);
        }

        public override int GetHashCode()
        {
            unchecked
            {
                var hashCode = _x.GetHashCode();
                hashCode = (hashCode * 397) ^ _y.GetHashCode();
                hashCode = (hashCode * 397) ^ _z.GetHashCode();
                return hashCode;
            }
        }

        public static bool operator ==(Point left, Point right)
        {
            return left.Equals(right);
        }

        public static bool operator !=(Point left, Point right)
        {
            return !left.Equals(right);
        }

        public double Scalar(Point a)
        {
            return _x * a._x + _y * a._y + _z * a._z;
        }

        public static Point operator +(Point a, Point b)
        {
            return new Point(a._x + b._x, a._y + b._y, a._z + b._z);
        }

        public static Point operator -(Point a, Point b)
        {
            return new Point(a._x - b._x, a._y - b._y, a._z - b._z);
        }

        public static Point operator *(Point a, Point b)
        {
            return new Point(a._y * b._z - a._z * b._y, -a._x * b._z + a._z * b._x, a._x * b._y - a._y * b._x);
        }

        public static Point operator *(Point a, double c)
        {
            return new Point(a._x * c, a._y * c, a._z * c);
        }

        public override string ToString()
        {
            return "{" + _x.ToString() + ", " + _y.ToString() + ", " + _z.ToString() + "}";
        }
    }
}