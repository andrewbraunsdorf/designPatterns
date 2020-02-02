using System;
using System.Runtime.Serialization;
using System.Text;

namespace CustomStringBuilder
{
    public class CodeBuilder
    {
        private StringBuilder builder = new StringBuilder();

        public override string ToString()
        {
            return builder.ToString();
        }

        public void GetObjectData(SerializationInfo info, StreamingContext context)
        {
            ((ISerializable)builder).GetObjectData(info, context);
        }

        public int EnsureCapacity(int capacity)
        {
            return builder.EnsureCapacity(capacity);
        }

        public string ToString(int startIndex, int length)
        {
            return builder.ToString(startIndex, length);
        }

        public CodeBuilder Clear()
        {
            builder.Clear();
            return this;
        }

        public CodeBuilder Append(char value, int repeatCount)
        {
            builder.Append(value, repeatCount);
            return this;
        }

        public CodeBuilder Append(char[] value, int startIndex, int charCount)
        {
            builder.Append(value, startIndex, charCount);
            return this;
        }

        public CodeBuilder Append(string value)
        {
            builder.Append(value);
            return this;
        }

        public CodeBuilder Append(string value, int startIndex, int count)
        {
            builder.Append(value, startIndex, count);
            return this;
        }

        public CodeBuilder AppendLine()
        {
            builder.AppendLine();
            return this;
        }

        public CodeBuilder AppendLine(string value)
        {
            builder.AppendLine(value);
            return this;
        }

        public void CopyTo(int sourceIndex, char[] destination, int destinationIndex, int count)
        {
            builder.CopyTo(sourceIndex, destination, destinationIndex, count);
        }

        public CodeBuilder Insert(int index, string value, int count)
        {
            builder.Insert(index, value, count);
            return this;
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            Console.ReadLine();
        }
    }
}