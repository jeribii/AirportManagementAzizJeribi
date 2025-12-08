using AM.Application.Core.Domain;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AM.Application.Core.Interfaces
{
    public interface IFlightMethods
    {
        List<DateTime> getFlightDates(string dest);
        void getFlights(string filter, string val);

        void showFlightDetails(Plane plane);

        int DurationAverage(string destination);

        List<Flight> OrderedDurationFlights();

        List<Passenger> SeniorTravellers(Flight flight);

        IEnumerable<IGrouping<string, Flight>> DestinationGroupedFlights();


    }
}
