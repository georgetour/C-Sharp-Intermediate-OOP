using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InterfacesExample
{
    interface IItem
    {
        string Name { get; set; }
        int GoldValue { get; set; }
    

        void Equip();
        void Sell();

    }

    interface IStatus
    {
        int Durability { get; set; }

        void TakeDamage(int amount);

    }

    interface IPartOfQuest
    {
        void TurnIn();
    }

    

    class Sword : IItem , IStatus ,IPartOfQuest
    {
        public string Name { get; set; }
        public int GoldValue { get; set; }

        public int Durability{ get; set; }

        public Sword(string name)
        {
            Name = name;
            GoldValue = 100;
            Durability = 12;
        }

        public void Equip()
        {
            Console.WriteLine(String.Format("{0} has been equipped",Name));
        }

        public void Sell()
        {
            Console.WriteLine(String.Format("{0} was sold for {1}",Name, GoldValue));
        }

        public void TakeDamage(int amount)
        {
            Durability -= amount;
            Console.WriteLine(String.Format("{0} damaged {1}. It has now a durability of {2}", Name ,amount, Durability));
        }

        public void TurnIn()
        {
            Console.WriteLine(String.Format("{0} was turned in.",Name));
        }

    }


    //Easily by copying the above class we can derive the Interfaces we want
    class Axe : IItem, IStatus
    {
        public string Name { get; set; }
        public int GoldValue { get; set; }

        public int Durability { get; set; }

        public Axe(string name)
        {
            Name = name;
            GoldValue = 50;
            Durability = 10;
        }

        public void Equip()
        {
            Console.WriteLine(String.Format("{0} has been equipped", Name));
        }

        public void Sell()
        {
            Console.WriteLine(String.Format("{0} was sold for {1}", Name, GoldValue));
        }

        public void TakeDamage(int amount)
        {
            Durability -= amount;
            Console.WriteLine(String.Format("{0} damaged {1}. It has now a durability of {2}", Name, amount, Durability));
        }
    }



    class Program
    {
        static void Main(string[] args)
        {

            var sword = new Sword("Bronze sword");
            sword.Equip();
            sword.TakeDamage(2);
            sword.Sell();

            Console.WriteLine();

            var axe = new Axe("Cutting axe");
            axe.Equip();
            axe.TakeDamage(1);
            axe.Sell();

            Console.WriteLine();

            //Create an inventory
            IItem[] inventory = new IItem[2];
            inventory[0] = sword;
            inventory[1] = axe;

            //Loop through and turn all quest items
            for (int i = 0; i < inventory.Length; i++)
            {
                IPartOfQuest questItem = inventory[i] as IPartOfQuest;
                if (questItem != null)
                {
                    questItem.TurnIn();
                }
            }

        }
    }




}
