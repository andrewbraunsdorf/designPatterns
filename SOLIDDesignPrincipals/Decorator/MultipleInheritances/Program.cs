using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MultipleInheritances
{
    public class Bird
    {
        public void Fly()
        {

        }
    }

    public class Lizard
    {
        public void Crawl()
        {

        }
    }

    public class Dragon 
    {
        private Bird bird;
        private Lizard lizard;
    }

    class Program
    {
        static void Main(string[] args)
        {
        }
    }
}
