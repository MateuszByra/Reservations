using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Reservations
{
    public class Application
    {
        private readonly IVacationPartFactory partFactory;

        public Application(IVacationPartFactory partFactory)
        {
            this.partFactory = partFactory;
        }

        public void Run()
        {
            VacationSpecificationBuilder builder =
                new VacationSpecificationBuilder(
                    this.partFactory,
                    new DateTime(2017, 06, 30), 14,
                    "Katowice",
                    "Rijeka");
            builder.SelectHotel("Small one");
            builder.SelectAirplane("Noisy one");

            VacationSpecification spec = builder.BuildVacation();
        }
    }
}
