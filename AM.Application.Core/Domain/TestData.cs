using AM.Application.Core.Domain;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AM.ApplicationCore.Domain
{
    public static class TestData
    {
        public static Plane BoingPlane = new Plane { planetype = PlaneType.Boing, capacity = 150, ManufactureDate = new DateTime(2015, 02, 03) };
        public static Plane Airbusplane = new Plane { planetype = PlaneType.Airbus, capacity = 250, ManufactureDate = new DateTime(2020, 11, 11) };

        // Staffs
        public static Staff captain = new Staff { firstname = "captain", lastname = "captain", emailAddress = "captain.captain@gmail.com", birthDate = new DateTime(1965, 01, 01), employmentDate = new DateTime(1999, 01, 01), salary = 99999 };
        public static Staff hostess1 = new Staff { firstname = "hostess1", lastname = "hostess1", emailAddress = "hostess1.hostess1@gmail.com", birthDate = new DateTime(1995, 01, 01), employmentDate = new DateTime(2020, 01, 01), salary = 999 };
        public static Staff hostess2 = new Staff { firstname = "hostess2", lastname = "hostess2", emailAddress = "hostess2.hostess2@gmail.com", birthDate = new DateTime(1996, 01, 01), employmentDate = new DateTime(2020, 01, 01), salary = 999 };
        // Travellers
        public static Traveller traveller1 = new Traveller { firstname = "traveller1", lastname = "traveller1", emailAddress = "traveller1.traveller1@gmail.com", birthDate = new DateTime(1980, 01, 01), healthInformation = "no troubles", nationality = "American" };
        public static Traveller traveller2 = new Traveller { firstname = "traveller2", lastname = "traveller2", emailAddress = "traveller2.traveller2@gmail.com", birthDate = new DateTime(1981, 01, 01), healthInformation = "Some troubles", nationality = "French" };
        public static Traveller traveller3 = new Traveller
        {
            firstname = "traveller3",
            lastname = "traveller3",
            emailAddress = "traveller3.traveller3@gmail.com",
            birthDate = new DateTime(1982, 01, 01),
            healthInformation = "no troubles",
            nationality = "Tunisian"
        };
        public static Traveller traveller4 = new Traveller { firstname = "traveller4", lastname = "traveller4", emailAddress = "traveller4.traveller4@gmail.com", birthDate = new DateTime(1983, 01, 01), healthInformation = "Some troubles", nationality = "American" };
        public static Traveller traveller5 = new Traveller { firstname = "traveller5", lastname = "traveller5", emailAddress = "traveller5.traveller5@gmail.com", birthDate = new DateTime(1984, 01, 01), healthInformation = "Some troubles", nationality = "Spanish" };
        // Flights
        // Affect all passengers to flight1
        public static Flight flight1 = new Flight
        {
            flightDate = new DateTime(2022, 01, 01, 15, 10, 10),
            destination = "Paris",
            effectiveArrival = new DateTime(2022, 01, 01, 17, 10, 10),
            estimateDuration = 110,
            passengers = new List<Passenger> { captain, hostess1, hostess2, traveller1, traveller2, traveller3, traveller4, traveller5 },
            plane = Airbusplane
        };
        public static Flight flight2 = new Flight { flightDate = new DateTime(2022, 02, 01, 21, 10, 10), destination = "Paris", effectiveArrival = new DateTime(2022, 02, 01, 23, 10, 10), estimateDuration = 105, plane = BoingPlane };
        public static Flight flight3 = new Flight { flightDate = new DateTime(2022, 03, 01, 5, 10, 10), destination = "Paris", effectiveArrival = new DateTime(2022, 03, 01, 6, 40, 10), estimateDuration = 100, plane = BoingPlane };
        public static Flight flight4 = new Flight { flightDate = new DateTime(2022, 04, 01, 6, 10, 10), destination = "Madrid", effectiveArrival = new DateTime(2022, 04, 01, 8, 10, 10), estimateDuration = 130, plane = BoingPlane };
        public static Flight flight5 = new Flight { flightDate = new DateTime(2022, 05, 01, 17, 10, 10), destination = "Madrid", effectiveArrival = new DateTime(2022, 05, 01, 18, 50, 10), estimateDuration = 105, plane = BoingPlane };
        public static Flight flight6 = new Flight { flightDate = new DateTime(2022, 06, 01, 20, 10, 10), destination = "Lisbonne", effectiveArrival = new DateTime(2022, 06, 01, 22, 30, 10), estimateDuration = 200, plane = Airbusplane };

        //test list
        public static List<Flight> listFlights = new List<Flight> { flight1, flight2, flight3, flight4, flight5, flight6 };
    }
}
