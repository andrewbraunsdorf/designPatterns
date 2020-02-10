using System;
using System.Runtime.Serialization;
using System.Text;

namespace AdapterDecorator
{
    public class MyStringBuilder
    {
        StringBuilder sb = new StringBuilder();

        public static implicit operator MyStringBuilder(string s)
        {
            var msb = new MyStringBuilder();
            msb.sb.Append(s);
            return msb;
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            MyStringBuilder s = "hello ";
            s += "world";
            Console.WriteLine(s);
            Console.ReadLine();
        }
    }
}