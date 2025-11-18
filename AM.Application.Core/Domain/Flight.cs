using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AM.Application.Core.Domain
{
    public class Flight
    {
        public string departure { get; set; }

        public string destination { get; set; }

        public DateTime effectiveArrival { get; set; }

        public int estimateDuration { get; set; }

        public DateTime flightDate {  get; set; }

        public int flightId { get; set; }

        public Plane plane { get; set; }

        public override string ToString()
        {
            return "flight n° :" + this.flightId + " duree estimee " + this.estimateDuration;
        }

        public ICollection<Passenger> passengers { get; set; }
    }
}
