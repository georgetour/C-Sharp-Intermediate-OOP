using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Method_Overriding
{
    class Triangle : Shape
    {

        public override void Draw()
        {
            Console.WriteLine("Draw a triangle");
        }


    }
}
