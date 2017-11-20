using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Fields
{
    public class Customer
    {

        public int ID;
        public string Name;
        readonly public List<Order> Orders = new List <Order> ();


        //Or you can initialize the list in a constructor
        //public Customer()
        //{
        //    Orders = new List<Order>();
        //}

        public Customer(int id)
        {
            this.ID = id;

        }

        public Customer(int id, string name)
            :this(id)
        {
            this.Name = name;
        }


        public void Promote()
        {

            // Compile error since we have readonly
            Orders = new List<Order>();

        }

    }
}
