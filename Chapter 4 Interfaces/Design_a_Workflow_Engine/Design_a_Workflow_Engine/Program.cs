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
            var workflow = new Workflow();
            workflow.Add(new Order());
            workflow.Add(new EmailToCustomer());
            workflow.Add(new ShipOrder());

            var workFlowEngine = new WorkflowEngine();
            workFlowEngine.Run(workflow, customer);


        }
    }
}
