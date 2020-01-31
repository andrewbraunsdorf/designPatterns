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
    }

    class Program
    {
        static void Main(string[] args)
        {
            Console.ReadLine();
        }
    }
}