using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Method_Overriding
{
    public class Circle : Shape
    {
        public override void Draw()
        {
            //Any code specific to the circle itself
            Console.WriteLine("Draw a circle");
        }


    }
}
