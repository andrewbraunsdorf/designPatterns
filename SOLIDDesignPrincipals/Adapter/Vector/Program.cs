using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;

namespace Vector
{
    public class Point
    {
        public int X;
        public int Y;

        public Point(int x, int y)
        {
            this.X = x;
            this.Y = y;
        }

        public override string ToString()
        {
            return $"{nameof(X)}: {X}, {nameof(Y)}: {Y}";
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
        }
    }
}