using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Interfaces_and_Testability
{
    public class Order
    {
        public DateTime DatePlaced { get;  set; }
        public Shipment Shipment { get; set; }
        public float TotalPrice { get;  set; }

        //If Shipment is not null it s going to return true
        public bool IsShipped
        {
            get { return Shipment != null; } 
        }

    }
}
