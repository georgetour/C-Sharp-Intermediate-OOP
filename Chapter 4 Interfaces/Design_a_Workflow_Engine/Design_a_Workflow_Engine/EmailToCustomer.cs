using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Design_a_Workflow_Engine
{
    public class EmailToCustomer : ICustomerActions, IOrderConfirmationSend
    {
        public void Execute(Customer customer)
        {
            Console.WriteLine("Email send to " + customer.Email);
            Send();
            
        }

        public void Send()
        {
            var order = new Order();
            Console.WriteLine("Your order contains : ");
            order.TotalProducts();
        }
    }
}
