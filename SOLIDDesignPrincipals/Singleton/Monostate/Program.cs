using System;

namespace Singleton
{
    public class ChiefExecutiveOfficer
    {
        private static string name;
        private static int age;

        public string Name
        {
            get => name;
            set => name = value;
        }
    }

    public class Demo
    {
        static void Main(string[] args)
        {
            Console.ReadLine();
        }
    }
}