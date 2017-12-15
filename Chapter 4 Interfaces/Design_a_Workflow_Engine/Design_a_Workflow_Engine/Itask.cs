using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Design_a_Workflow_Engine
{
    public interface ITask
    {
        void Execute(Customer customer);
    }
}
