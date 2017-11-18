using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Introduction_To_Classes
{

    //This is the way to create a class
    public class Person

    {
        //We use public until we learn about access modifiers
        public string Name;
        public int Age;

        public void Introduce(string to)
        {

            Console.WriteLine("HI {0}, I am {1}", to , Name);

        }

        //Wrong way as you can see below
        //public Person Parse(string str)
        //{
        //    var person = new Person();
        //    person.name = str;

        //    return person;

        //}
        
        
        //Create a personal object from a string
        public static Person Parse(string str)
        {
            var person = new Person();

            //Setting the field based on str argument
            person.Name = str;

            return person;

        }





    }


    class Program
    {
        static void Main(string[] args)
        {

            //Create an object for Person class
            Person person = new Person();

            //or shorter way
            //var person = new Person();


            //Access property for that object
            person.Name = "Elizabeth";
            person.Introduce("George");
            

            
            //We don't need to create a new instance since we call directly the static method
            var person2 = Person.Parse("John");
            person2.Introduce("George");


        }
    }
}
