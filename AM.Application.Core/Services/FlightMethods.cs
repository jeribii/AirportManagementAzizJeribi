using AM.Application.Core.Domain;
using AM.Application.Core.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection.Metadata.Ecma335;
using System.Text;
using System.Threading.Tasks;

namespace AM.Application.Core.Services
{
    public class FlightMethods : IFlightMethods
    {
        public List<Flight> flights { get; set; } = new List<Flight> { };

        public List<DateTime> getFlightDates(string dest)
        {
            /*List<DateTime> dates = new List<DateTime>();
             for(int i = 0; i < flights.Count; i++)
            {
                if (flights[i].destination== dest)
                {
                    dates.Add(flights[i].flightDate);
                }
            }
            return dates;*/

            var req = from flight in flights
                      where flight.destination == dest
                      select flight.flightDate;
            return req.ToList();

        }

        public void getFlights(string filter, string val)
        {
            switch (filter)
            {
                case "destination":
                    foreach (var flight in flights)
                    {
                        if (flight.destination == val)
                        {
                            Console.WriteLine(flight.ToString());
                        }
                    }
                    break;

                case "departure":
                    foreach (var a in flights)
                    {
                        if (a.departure == val)
                        {
                            Console.WriteLine(a.ToString());
                        }
                    }
                    break;
                case "flightDate":
                    foreach (var f in flights)
                    {
                        if (f.flightDate == DateTime.Parse(val))
                        {
                            Console.WriteLine(f.ToString());
                        }
                    }

                    break;

                case "estimateDuration":
                    foreach (var a in flights)
                    {
                        if (a.estimateDuration == int.Parse(val))
                        {
                            Console.WriteLine(a.ToString());
                        }
                    }

                    break;
            }
        }

        public void showFlightDetails(Plane plane)
        {
            var req = from flight in flights
                      where flight.plane == plane
                      select flight;
            foreach (var flight in req)
            {
                Console.WriteLine("la date est : " + flight.departure.ToString() + " la destination est: " + flight.destination);
            }
        }

        public int DurationAverage(string destination)
        {
            int a = 0;
            var req = from flight in flights
                      where flight.destination == destination
                      select flight.estimateDuration;
            foreach (var flight in req)
            {
                a = a + flight;
            }
            int count = req.Count();
            return a / count;
        }
        public List<Flight> OrderedDurationFlights()
        {
            var req = from flight in flights
                      orderby flight.estimateDuration descending
                      select flight;

            foreach (var flight in req)
            {
                Console.WriteLine(flight.ToString());

            }
            return req.ToList();
        }
        public List<Passenger> SeniorTravellers(Flight flight)
        {
            var req = from passenger in flight.passengers
                      where passenger is Traveller
                      orderby passenger.birthDate ascending
                      select passenger;

            return req.Take(3).ToList();
        }

        public IEnumerable<IGrouping<string, Flight>> DestinationGroupedFlights()
        {
            var req = from f in flights
                      group f by f.destination;
            return req.ToList();
        }

        public Action<Plane> FlightDetailsDel;
        public Func<string, double> DurationAverageDel;

        public FlightMethods()
        {
            //FlightDetailsDel =ShowFlightDetails;

            FlightDetailsDel = p =>
            {
                var req = from flight in flights
                          where flight.plane == p
                          select flight;
                foreach (var flight in req)
                {
                    Console.WriteLine("la destination:" + flight.destination + "la date:" + flight.flightDate);
                }

            };
            //DurationAverageDel = DurationAverage;
            DurationAverageDel = d =>
            {
                var req = from f in flights
                          where f.destination == d
                          select f.estimateDuration;
                return req.Average();
            };
        }
    }
    
}
  
