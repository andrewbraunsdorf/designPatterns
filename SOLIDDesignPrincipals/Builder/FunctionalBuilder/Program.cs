using System;
using System.Collections.Generic;

namespace FunctionalBuilder
{
    public class Person
    {
        public string Name, Position;
    }

    public class PersonBuilder
    {
        public readonly List<Action<Person>> Actions = new List<Action<Person>>();

        public PersonBuilder Called(string name)
        {
            Actions.Add(p => { p.Name = name; });
            return this;
        }

        public Person Build()
        {
            var p = new Person();
            Actions.ForEach(a => a(p));
            return p;
        }
    }


    class Program
    {
        public static void Main(string[] args)
        {
        }
    }
}