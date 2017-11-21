using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Access_Modifiers
{
    class Program
    {
        static void Main(string[] args)
        {

            var person = new Person();

            person.SetBirthDate(new DateTime(2017,10,10));

            Console.WriteLine(person.GetBirthDate());

        }
    }
}
