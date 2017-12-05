using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Boxing_Unboxing
{
    class Program
    {
        static void Main(string[] args)
        {

            //With ArrayList we lose safety typing
            //We are losing type safety since in some values boxing happens and in others it doesn't
            var list = new ArrayList();
            list.Add(1);
            list.Add("Mosh");
            list.Add(DateTime.Now);

            var number = (int)list[1];

            //So to be safe and have type safety we crete a list which lets only same value types 
            //and no boxing will happen
            var anotherList = new List<int>();
            anotherList.Add(3);
            anotherList.Add(5);


        }
    }
}
