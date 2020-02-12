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

        public StringBuilder Append(char value, int repeatCount)
        {
            return sb.Append(value, repeatCount);
        }

        public StringBuilder Append(char[] value, int startIndex, int charCount)
        {
            return sb.Append(value, startIndex, charCount);
        }

        public StringBuilder Append(string value)
        {
        return sb.Append(value);
        }

        public StringBuilder Append(string value, int startIndex, int count)
        {
        return sb.Append(value, startIndex, count);
        }

        public StringBuilder AppendLine()
        {
        return sb.AppendLine();
        }

        public StringBuilder AppendLine(string value)
        {
        return sb.AppendLine(value);
        }

        public void CopyTo(int sourceIndex, char[] destination, int destinationIndex, int count)
        {
        sb.CopyTo(sourceIndex, destination, destinationIndex, count);
        }

        public StringBuilder Insert(int index, string value, int count)
        {
        return sb.Insert(index, value, count);
        }

        public StringBuilder Remove(int startIndex, int length)
        {
        return sb.Remove(startIndex, length);
        }

        public StringBuilder Append(bool value)
        {
        return sb.Append(value);
        }

        public StringBuilder Append(sbyte value)
        {
        return sb.Append(value);
        }

        public StringBuilder Append(byte value)
        {
        return sb.Append(value);
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