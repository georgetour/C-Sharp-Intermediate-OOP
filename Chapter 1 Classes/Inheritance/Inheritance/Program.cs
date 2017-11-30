using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Inheritance
{
    class Program
    {
        static void Main(string[] args)
        {
            //As you see hero object has inherited everything from Character class but RealId is unique to hero
            //class. Of course we would protect our hero's real ID but that's an example 
            var hero = new Hero();
            hero.Name = "Superman";
            hero.AttackDescription = "Punches";

            hero.Attack();

            Console.WriteLine(hero.RealId("Klark Kent"));
            

        }
    }
}
