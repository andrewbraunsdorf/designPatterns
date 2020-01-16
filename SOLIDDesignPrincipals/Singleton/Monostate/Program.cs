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
          var ceo = new ChiefExecutiveOfficer();
          ceo.Name = "Adam Smith";
          ceo.Age = 55;

          var ceo2 = new ChiefExecutiveOfficer();
          Console.WriteLine(ceo2);
          Console.ReadLine();
        }
    }
}