using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Reservations
{
    public interface IVacationPartFactory
    {
        IVacationPart CreateHotelReservation(string town, string hotelName,
                                                DateTime arrivalDate,
                                                DateTime leaveDate);

        IVacationPart CreateFlight(string companyName, string source,
                                    string destination, DateTime date);
        //rezerwacja promowa
        IVacationPart CreateFerryBooking(string lineName, bool fromMainland,
                                            DateTime date);

        IVacationPart CreateDailyTrip(string tripName, DateTime date);
        IVacationPart CreateMessage(string salon, DateTime date);
    }
}
