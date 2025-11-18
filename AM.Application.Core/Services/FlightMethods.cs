using AM.Application.Core.Domain;
using AM.Application.Core.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AM.Application.Core.Services
{
    public class FlightMethods:IFlightMethods
    {
        public List<Flight> flights { get; set; } = new List<Flight> { };

        public List<DateTime> getFlightDates(string dest)
        {
            List<DateTime> dates = new List<DateTime>();
             for(int i = 0; i < flights.Count; i++)
            {
                if (flights[i].destination== dest)
                {
                    dates.Add(flights[i].flightDate);
                }
            }
            return dates;
        }
    }
}
