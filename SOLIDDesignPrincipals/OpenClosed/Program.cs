using System;
using System.Collections.Generic;
using static System.Console;

namespace OpenClosed
{
    public enum Color
    {
        Red, Green, Blue
    }

    public enum Size
    {
        Small, Medium, Large, Huge
    }
    public class Product
    {
        public string Name;
        public Color Color;
        public Size Size;

        public Product(string name, Color color, Size size)
        {
            Name = name ?? throw new ArgumentNullException(paramName: nameof(name));
            Color = color;
            Size = size;
        }
    }

     public class ProductFilter
    {
        // let's suppose we don't want ad-hoc queries on products
        public IEnumerable<Product> FilterByColor(IEnumerable<Product> products, Color color)
        {
            foreach (var p in products)
                if (p.Color == color)
                    yield return p;
        }
    }
      public class Demo
    {
        static void Main(string[] args)
        {

        }
    }
}
