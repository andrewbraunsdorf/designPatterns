using System;
using static System.Console;

namespace DotNetDesignPatternDemos.SOLID.LiskovSubstitutionPrinciple
{
    // using a classic example
    public class Rectangle
    {
        //public int Width { get; set; }
        //public int Height { get; set; }

        public virtual int Width { get; set; }
        public virtual int Height { get; set; }

        public Rectangle()
        {

        }

        public Rectangle(int width, int height)
        {
            Width = width;
            Height = height;
        }

        public override string ToString()
        {
            return $"{nameof(Width)}: {Width}, {nameof(Height)}: {Height}";
        }
    }

        public class Square : Rectangle
    {
        public override int Width // nasty side effects
        {
            set { base.Width = base.Height = value; }
        }

        public override int Height
        {
            set { base.Width = base.Height = value; }
        }
    }

    public class Program
    {
        static public int Area(Rectangle r) => r.Width * r.Height;

        static void Main(string[] args)
        {
            Rectangle rc = new Rectangle(2, 3);
            WriteLine($"{rc} has area {Area(rc)}");
            Console.ReadLine();
        }
    }
}