using System;

namespace FluentBuilder
{
    public class Person
    {
        public string Name;

        public string Position;

        public DateTime DateOfBirth;

        public class Builder : PersonBirthDateBuilder<Builder>
        {
            internal Builder() { }
        }

        public static Builder New => new Builder();

        public override string ToString()
        {
            return $"{nameof(Name)}: {Name}, {nameof(Position)}: {Position}";
        }
    }

    class Program
    {
        public static void Main(string[] args)
        {
        }
    }
}