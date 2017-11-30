using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Inheritance
{
    class Character
    {

        public string Name { get; set; }
        public string Appearance { get; set; }
        public string AttackDescription { get; set; }


        public void ShowName()
        {
            Console.WriteLine("Character's name " + this.Name);
        }

        public void Attack()
        {
            Console.WriteLine("{0} uses {1}" , this.Name , this.AttackDescription);
        }


    }
}
