using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Method_Overriding
{
    public class Canvas
    {

        //The parameter of this method is a List of shapes so every element of this list 
        //going to be a shape object or an object whose type derives from the shape class.
        public void DrawShapes(List<Shape> shapes)
        {
            foreach (var shape in shapes)
            {
                shape.Draw();
            }
        }


    }
}
