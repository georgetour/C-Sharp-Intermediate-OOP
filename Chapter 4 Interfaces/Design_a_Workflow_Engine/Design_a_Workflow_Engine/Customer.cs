using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Design_a_Workflow_Engine
{
    public class Customer
    {
        public string Name { get; private set; }
        public string Address { get; private set; }
        public string Email { get; private set; }

        public Customer(string name, string address,string email)
        {
            Name = name;
            Address = address;
            Email = email;
        }



    }
}
