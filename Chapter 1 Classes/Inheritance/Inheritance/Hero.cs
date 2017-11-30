using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Inheritance
{
    class  Hero : Character
    {
        
        private string ID { get;  set; }

        public string RealId(string Id)
        {
            this.ID = Id;
            return ("Hero's real id is " + Id);
        }


    }
}
