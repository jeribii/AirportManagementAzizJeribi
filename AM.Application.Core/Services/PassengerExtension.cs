using AM.Application.Core.Domain;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AM.Application.Core.Services
{
    public static class PassengerExtension
    {
        public static void UpperFullName(this Passenger p)
        {
            p.firstname = p.firstname[0].ToString().ToUpper() + p.firstname.Substring(1).ToLower();
            p.lastname = p.lastname[0].ToString().ToUpper() + p.lastname.Substring(1).ToLower();

            Console.WriteLine($"Full Name: {p.firstname} {p.lastname}");
        }
    }
}
