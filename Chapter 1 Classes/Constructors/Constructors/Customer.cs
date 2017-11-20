using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Constructors
{
    public class Customer
    {
        //In real world apps we don't declare fields as public
        public int Id;
        public string Name;

        //Always create an empty List as you see in the constructor else we get an unhandled exception 
        public List<Order> Orders;


        public Customer()
        {
            //Empty list created at instantiation with contructor
            Orders = new List<Order>();
        }

        public Customer(int id)
            :this()
        {

            this.Id = id;

        }

        public Customer(int id, string name)
            :this(id)
        {
            //this.Id = id; Not needed since we use the constructor
            this.Name = name;
        }




    }
}
