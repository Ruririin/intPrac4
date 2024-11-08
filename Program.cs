using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace intPrac4
{

    internal class Program
    {
        static void Main(string[] args)
        {
            var person = new Person(new DateTime(2002, 11, 30));
            Console.WriteLine(person.Age);
        }
    }
}
