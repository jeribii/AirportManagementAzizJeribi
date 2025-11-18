using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AM.Application.Core.Domain
{
    public class Traveller:Passenger
    {
        public string healthInformation { get; set; }

        public string nationality {  get; set; }

        public override string ToString()
        {
            return "id " + this.id + " nationality is " + this.nationality;
        }
        public override void PassengerType()
        {
            base.PassengerType();
            Console.WriteLine("Im a Traveller");
        }
    }
}
