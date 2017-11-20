using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Methods
{
    public class Point
    {

        public int X;
        public int Y;


        public Point(int x, int y)
        {
            this.X = x;
            this.Y = y;


        }


        public void Move(int x, int y)
        {
            this.X = x;
            this.Y = y;

        }

        ////This is wrong since we duplicating the concept of setting x and y
        //public void Move(Point newLocation)
        //{

        //    this.X = newLocation.X;
        //    this.Y = newLocation.Y;

        //}

        //Correct way and usign an object as parameter
        //https://www.codeguru.com/columns/dotnet/using-objects-as-parameters-in-c.htm
        public void Move(Point newLocation)
        {

            //We need to validate the argument that is passed in so we don't have an exception
            if (newLocation == null)
                throw new ArgumentNullException("newLocation");

            Move(newLocation.X, newLocation.Y);
          

        }



    }
}
