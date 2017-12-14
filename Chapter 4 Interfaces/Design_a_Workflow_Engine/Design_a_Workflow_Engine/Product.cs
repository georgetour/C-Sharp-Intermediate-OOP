using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Design_a_Workflow_Engine
{
    public class Product
    {
        public int ID { get; private set; }
        public string Name { get; private set; }
        public int Price { get;private set; }
        public string Description { get; private set; }


        public Product(int id, string name, int price)
        {
            ID = id;
            Name = name;
            Price = price;
        }

    }
}
