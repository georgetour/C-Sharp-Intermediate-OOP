using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StopWatch
{
    public class StopWatch
    {
        private DateTime start;
        private DateTime stop;
        private TimeSpan duration;
        private string output;
        public bool haveStarted { get; private set; }

        public void Start()
        {  
            checkIfstarted();
            haveStarted = true;
            Console.WriteLine("Timer started write stop to stop it");
            start = DateTime.Now;
        }

        public void Stop()
        {
            haveStarted = false;
            stop = DateTime.Now;
        }
        


        public string Duration()
        { 
            duration = stop - start;
            output = String.Format("{0} seconds have passed",duration.Seconds);
            return output;
        }

        public void checkIfstarted()
        {
            if (haveStarted)
            {
                throw new InvalidOperationException("Timer have already been started");
            }

        }


    }
}
