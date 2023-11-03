using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Project3
{
    internal class Schedule
    {
        public Truck truck { get; set; }
        public int interval { get; set; }

        public Schedule(Truck truck, int interval)
        {
            this.truck = truck;
            this.interval = interval;
        }

        public Truck GetTruck()
        {
            return this.truck;
        }
    }
}
