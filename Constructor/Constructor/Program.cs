using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Constructor
{
    class Program
    {
        static void Main(string[] args)
        {
            const string greet = "Hello"; //creating constant

            var name = "Deondre"; //assigning implicit variable           



            Console.WriteLine(greet + " " + name); //concatenating together

            Console.Read();

            myClass test = new myClass("Deondre");
        }
        public class myClass
        {
            string name = "Drew";
            public myClass() : this("Deondre")
            {
            }
            public myClass(string name)
            {
                this.name = name;
            }

        }

    }
}