using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Design_a_Stack
{
    class Program
    {
        static void Main(string[] args)
        {
            var stack = new Stack();

            stack.Push(10);
            stack.Push("hello");
            stack.Push(30);
            stack.Push(40);
            


            Console.WriteLine(stack.Pop());
            Console.WriteLine(stack.Pop());
            Console.WriteLine(stack.Pop());
            Console.WriteLine(stack.Pop());


        }
    }
}
