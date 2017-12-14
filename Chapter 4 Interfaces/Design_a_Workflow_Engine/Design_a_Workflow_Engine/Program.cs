using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Design_a_Workflow_Engine
{
    class Program
    {
        static void Main(string[] args)
        {
            var customer = new Customer("George", "Greece", "george@besmartbesimple.com");
            var order = new Order();
            var mailTo = new EmailToCustomer();
            var shipOrder = new ShipOrder();


            order.Execute(customer);
            mailTo.Execute(customer);
            shipOrder.Execute(customer);


        }
    }
}
