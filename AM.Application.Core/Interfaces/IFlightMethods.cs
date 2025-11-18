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
    }
}
