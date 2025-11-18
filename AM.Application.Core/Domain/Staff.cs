using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AM.Application.Core.Domain
{
    public class Staff:Passenger
    {
        public DateTime employmentDate { get; set; }

        public string?  function {  get; set; }

        public double salary { get; set; }

        public override string ToString()
        {
            return "salary "+this.salary+ " function: "+this.function;
        }

        public override void PassengerType()
        {
            base.PassengerType();
            Console.WriteLine("M a staff member");
        }
    }
}
