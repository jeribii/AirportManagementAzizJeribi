using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AM.Application.Core.Domain
{
    public enum PlaneType { Boing , Airbus}
    public class Plane
    {
        public int capacity { get; set; }
        public DateTime ManufactureDate { get; set; }

        public int planeid { get; set; }

        public PlaneType planetype { get; set; }

        public ICollection<Flight> flights { get; set; }

        public override string ToString()
        {
            return "Plane n°: " + this.planeid + " Capacity°: " + this.capacity;
            //return base.ToString();
        }

        public Plane()
        {

        }

        public Plane(PlaneType t,int type,DateTime time)
        {
            this.planetype = t;
            this.capacity = type;
            this.ManufactureDate= time;
        }

    }
}
