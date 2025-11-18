// See https://aka.ms/new-console-template for more information
using AM.Application.Core.Domain;
using AM.Application.Core.Services;
using AM.ApplicationCore.Domain;

//Console.WriteLine("Hello, World!");
Plane p = new Plane();
p.capacity = 200;
p.ManufactureDate = new DateTime(2025, 11, 12);
p.planetype = PlaneType.Airbus;
p.planceid = 1;
Console.WriteLine(p.ToString());


Plane plane= new Plane {
    planetype= PlaneType.Airbus,
    capacity=200,
    ManufactureDate = new DateTime(2025,11,13)
};
Console.WriteLine(plane.ToString());

Passenger passenger=new Passenger();

passenger.firstname = "aziz";
passenger.lastname = "jeribi";
Console.WriteLine(passenger.ToString());
Console.WriteLine("checking with name and first name");
Console.WriteLine(passenger.checkProfile("ahmed","mohsen"));
Passenger p2=new Passenger();
p2.firstname = "iheb";
p2.lastname = "test";
p2.emailAddress="aziz@esprit.tn";
Console.WriteLine(p2.checkProfile("test", "iheb", "aziz@esprit.tn"));

Console.WriteLine("---------------------------");


Staff staff =new Staff();
Passenger pass=new Passenger();
Traveller trav=new Traveller();

staff.PassengerType();
Console.WriteLine("---------------------------");
pass.PassengerType();
Console.WriteLine("---------------------------");
trav.PassengerType();

FlightMethods fm=new FlightMethods {flights=TestData.listFlights};

