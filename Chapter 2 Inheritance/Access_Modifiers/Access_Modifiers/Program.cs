using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Amazon;

namespace Access_Modifiers
{
    class Program
    {
        static void Main(string[] args)
        {
            var customer = new Customer();

            //Can't access since its internal
            Amazon.Rate_Calculator calculator = new Rate_Calculator();
           


        }
    }
}
