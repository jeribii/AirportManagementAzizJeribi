// See https://aka.ms/new-console-template for more information
using AM.Application.Core.Domain;
using AM.Application.Core.Services;
using AM.ApplicationCore.Domain;
using AM.infrastructure;


AMContext context = new AMContext();
//context.planes.Add(TestData.Airbusplane);
//context.flights.Add(TestData.flight2);
//context.SaveChanges();
context.flights.Add(TestData.flight3);
context.SaveChanges();

////Console.WriteLine("Hello, World!");
//Plane p = new Plane();
//p.capacity = 200;
//p.ManufactureDate = new DateTime(2025, 11, 12);
//p.planetype = PlaneType.Airbus;
//p.planeid = 1;
//Console.WriteLine(p.ToString());


//Plane plane= new Plane {
//    planetype= PlaneType.Airbus,
//    capacity=200,
//    ManufactureDate = new DateTime(2025,11,13)
//};
//Console.WriteLine(plane.ToString());

//Passenger passenger=new Passenger();

//passenger.firstname = "aziz";
//passenger.lastname = "jeribi";
//Console.WriteLine(passenger.ToString());
//Console.WriteLine("checking with name and first name");
//Console.WriteLine(passenger.checkProfile("ahmed","mohsen"));
//Passenger p2=new Passenger();
//p2.firstname = "iheb";
//p2.lastname = "test";
//p2.emailAddress="aziz@esprit.tn";
//Console.WriteLine(p2.checkProfile("test", "iheb", "aziz@esprit.tn"));

//Console.WriteLine("---------------------------");


//Staff staff =new Staff();
//Passenger pass=new Passenger();
//Traveller trav=new Traveller();

//staff.PassengerType();
//Console.WriteLine("---------------------------");
//pass.PassengerType();
//Console.WriteLine("---------------------------");
//trav.PassengerType();

//FlightMethods fm=new FlightMethods {flights=TestData.listFlights};
//foreach (var iteam in fm.getFlightDates("Paris"))
//{
//        Console.WriteLine(iteam);
//}
//fm.getFlights("destination", "Paris");
//Console.WriteLine("La moyenne est "+fm.DurationAverage("Paris"));

//foreach(var item in fm.SeniorTravellers(TestData.flight1))
//{
//    Console.WriteLine(item.ToString()+" AGE "+ (DateTime.Now.Year-item.birthDate.Year));
//}
//var groupedFlights = fm.DestinationGroupedFlights();

//foreach (var group in groupedFlights)
//{
//    Console.WriteLine($"Destination : {group.Key}");
//    foreach (var flight in group)
//    {
//        // Afficher la date de décollage
//        Console.WriteLine($"Décollage : {flight.flightDate:dd/MM/yyyy HH:mm:ss}");
//    }
//    Console.WriteLine(); // Ligne vide entre les destinations
//}
//p2.UpperFullName();

