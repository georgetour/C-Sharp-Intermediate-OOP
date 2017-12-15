using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Design_a_Workflow_Engine
{
    public class Workflow : IWorkflow
    {
        //In this class we add or remove tasks from classes that talk to the interface 
        //ITask like Order, EmailToCustomer, ShipOrder
        private readonly List<ITask> _tasks;

        public Workflow()
        {
            _tasks = new List<ITask>(); 
        }

        public void Add(ITask task)
        {
            _tasks.Add(task);
        }

        public void Remove(ITask task)
        {
            _tasks.Remove(task);
        }

        //We use IEnumerable since we don't want to go directly to the List above
        //IEnumerable is purely an interface that allows to enumerate a list
        public IEnumerable<ITask> GetTasks()
        {
            return _tasks;
        }
    }
}
