using System;
using System.Collections;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Upcasting_Downcasting
{
    class Program
    {
        static void Main(string[] args)
        {

            Text text = new Text();

            ////************Upcasting***************

            //text and shape are both references to the same object in memory but
            //they have different views
            Shape shape = text;

            text.Width = 200;
            shape.Width = 100;

            //The result will be 100 since both are referenced to same object in memory
            Console.WriteLine(text.Width);

            //We can pass any object that derives from the Stream class like FileStream or MemoryStream
            //StreamReader reader = new StreamReader(new MemoryStream());

            //In real world apps we should not use ArrayList since we can store in it different kind of object
            //in every element
            var list = new ArrayList();
            list.Add(1);
            list.Add("George");
            list.Add(new Text());

            //A safer way is to use a generic list
            var anotherList = new List<Shape>();




            //************Downcasting***************

            Shape shape2 = new Text();
            Text text2 = (Text)shape;

            


            




        }
    }
}
