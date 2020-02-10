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

        public static MyStringBuilder operator +(MyStringBuilder msb, string s)
        {
            msb.Append(s);
            return msb;
        }

        public override string ToString()
        {
            return sb.ToString();
        }

        public void GetObjectData(SerializationInfo info, StreamingContext context)
        {
            ((ISerializable)sb).GetObjectData(info, context);
        }

        public int EnsureCapacity(int capacity)
        {
            return sb.EnsureCapacity(capacity);
        }

        public string ToString(int startIndex, int length)
        {
            return sb.ToString(startIndex, length);
        }

        public StringBuilder Clear()
        {
            return sb.Clear();
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