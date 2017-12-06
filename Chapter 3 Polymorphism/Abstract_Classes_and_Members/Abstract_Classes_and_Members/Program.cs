using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Abstract_Classes_and_Members
{
    class Program
    {
        static void Main(string[] args)
        {
            //Won't compile since it's abstract
            //var shape = new Shape();


            var circle = new Circle();
            circle.Draw();

            var rectangle = new Rectangle();
            rectangle.Draw();



        }
    }
}
