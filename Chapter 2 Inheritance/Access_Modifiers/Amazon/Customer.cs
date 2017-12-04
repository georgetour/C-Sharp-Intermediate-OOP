using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Amazon
{
    public class Customer
    {

        public int Id { get; set; }
        public string Name { get; set; }

        public void Promote()
        {
            //This is not good practice since we create dependency 
            var calculator = new Rate_Calculator();
            var rating = calculator.Calculate(this);

            Console.WriteLine("Promote logic changed");


        }

      


    }
}
