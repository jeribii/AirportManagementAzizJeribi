using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AM.Application.Core.Domain
{
    public class Passenger
    {
        public DateTime birthDate { get; set; }

        public string? emailAddress { get; set; }

        public string?  phoneNumber { get; set; }

        public string? firstname { get; set; }

        public string? lastname { get; set; }

        public int passportName { get; set; }

        public int id { get; set; }

        public ICollection<Flight> flights { get; set; }

        public override string ToString()
        {
            return "First name ° " +this.firstname+" lastname "+this.lastname+" id "+this.id;
        }

        public bool checkProfile(string lastname,string first)
        {
            return this.firstname == first && this.lastname == lastname;
        }

        public bool checkProfile(string lastname,string first,string? mail)
        {
            if (mail != null)
            {
                return this.firstname == first && this.lastname == lastname &&
                    this.emailAddress == mail;
            }
            else
            {
                return this.firstname == first && this.lastname == lastname;

            }
        }

        public virtual void PassengerType()
        {
            Console.WriteLine("I m a passenger");
        }

    }
}
