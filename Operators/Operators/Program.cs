using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Operators
{
    class Program
    {
        static void Main(string[] args)
        {
            Employee employee = new Employee();
            employee.FirstName = "Deondre";
            employee.LastName = "Test";
            employee.Id = 2;

            Employee employee2 = new Employee() { FirstName = "Bob", LastName = "Moto", Id = 8 };

            Console.WriteLine(employee == employee2);
            Console.ReadLine();

        }
    }
}