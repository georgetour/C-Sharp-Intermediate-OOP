using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Design_a_Stack
{
    public class Stack
    {
        private List<object> stack = new List<object>();
        
        

        public void Push(object obj)
        {
            if (obj == null)
            {
                throw new InvalidOperationException("Push can't be null");
            }

            stack.Add(obj);
        }

        public object Pop()
        {
            if (stack.Count == 0 )
            {
                throw new InvalidOperationException("The list is empty");
            }


            //Find the last index value
            var obj = stack[stack.Count - 1];

            //Everytime you pop you remove the last element
            stack.RemoveAt(stack.Count - 1);
            return obj;
            
        }

        public void Clear()
        {
            stack.Clear();
        }


    }
}
