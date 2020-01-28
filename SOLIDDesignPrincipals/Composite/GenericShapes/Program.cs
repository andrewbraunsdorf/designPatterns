using System;
using System.Collections.Generic;
using System.Text;

namespace GeometricShapes
{
    public class GraphicObject
    {
        public virtual string Name { get; set; } = "Group";
        public string Color;
        private Lazy<List<GraphicObject>> children = new Lazy<List<GraphicObject>>();
        public List<GraphicObject> Children => children.Value;
    }

     class Program
    {
        static void Main(string[] args)
        {
            Console.ReadLine();
        }
    }
}