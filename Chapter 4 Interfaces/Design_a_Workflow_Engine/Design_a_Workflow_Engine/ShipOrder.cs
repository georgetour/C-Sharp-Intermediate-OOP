using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Design_a_Workflow_Engine
{
    public class ShipOrder : ITask
    {

        private Order _order = new Order();

        public void Execute(Customer customer)
        {
            Console.WriteLine("Shipping products to " + customer.Address);
            _order.TotalProducts();

        }



    }
}
