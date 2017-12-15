using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Design_a_Workflow_Engine
{
    public class WorkflowEngine
    {
        //The workflow engine should get a workflow and run it

        public void Run(IWorkflow workflow, Customer customer)
        {
            foreach (ITask task in workflow.GetTasks())
            {
                task.Execute(customer);
            }
        }
    }
}
