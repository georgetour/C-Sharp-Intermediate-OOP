using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Methods
{

    



    class Program
    {
        static void Main(string[] args)
        {

            

            
         }


        static void stringToNumberFail()
        {
            //var number = int.Parse("abc"); //Thorws an exception since abc can't be converted to int

            int number;
            var result = int.TryParse("abc", out number);

            if (result)
                Console.WriteLine(number);
            else
                Console.WriteLine("Conversion failed");
        }



        static void useParams()
        {
            var calculator = new Calculator();
            Console.WriteLine(calculator.Add(1, 2,3,4));
            Console.WriteLine(calculator.Add(1, 2, 3, 4,5,6,7,8));

        }


        static void UsePoints()
        {

            try
            {
                var point = new Point(10, 20);
                point.Move(null); //Comment this line so we don't have an error

                //Check what happens if we remove this.X = newLocation.X; from public void Move(Point newLocation)
                Console.WriteLine("Point is at ({0},{1})", point.X, point.Y);


                point.Move(100, 200);
                Console.WriteLine("Point is at ({0},{1})", point.X, point.Y);
            }
            catch (Exception)
            {

                Console.WriteLine("An unexpected error occured");
            }




        }
        
    }
}
