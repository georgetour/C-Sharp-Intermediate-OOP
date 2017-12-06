using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Abstract_Classes_and_Members
{
    public abstract class Shape
    {
        public int Width { get; set; }
        public int Height { get; set; }

        //With abstract we protect our app so the derived classes 
        //implement this method and not be empty
        public abstract void Draw();
        
        public void Copy()
        {
            Console.WriteLine("Copy shape in clipboard.");
        }

        public void Select()
        {
            Console.WriteLine("Select the shape");
        }


    }
}
