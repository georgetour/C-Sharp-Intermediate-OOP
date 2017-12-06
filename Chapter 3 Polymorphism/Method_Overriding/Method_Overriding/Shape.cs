using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Method_Overriding
{
    public class Shape
    {
        public int Width { get; set; }
        public int Height { get; set; }
        
        //We declare a method as virtual since drawing a circle is different that drawing a rectangle
        //So we can override the method
        public virtual void Draw()
        {

        }

    }
}
