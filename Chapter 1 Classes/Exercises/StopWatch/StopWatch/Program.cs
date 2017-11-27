using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace StopWatch
{
    class Program
    {
        static void Main(string[] args)
        {

            var stopwatch = new StopWatch();

            while (true)
            {
                var input = Console.ReadLine().ToLower();

                if (input == "start")   
                {
                    stopwatch.Start();
                }
                else if(input == "stop")
                {
                    stopwatch.Stop();
                    Console.WriteLine(stopwatch.Duration());
                }
            }



        }
    }
}
