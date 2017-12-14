using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Design_a_Workflow_Engine
{
    public class ShipOrder : ICustomerActions
    {

        private Order _order = new Order();

        public void Execute(Customer customer)
        {
            Console.WriteLine("Shipping products to " + customer.Address);
            var product = new Product(12, "bee", 200);
            _order.TotalProducts();

        }



    }
}
