using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Design_a_Workflow_Engine
{
    public interface ICustomerActions
    {
        void Execute(Customer customer);
    }
}
