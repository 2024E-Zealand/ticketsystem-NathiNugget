using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TicketClassLibrary;

namespace Oresundbron
{
    /// <summary>
    /// This class represents an MC on Oresund using the Storebaelt DLL
    /// </summary>
    public class OresundMC : MC
    {
        /// <summary>
        /// Constructor passign arguments to the base-constructor
        /// </summary>
        /// <param name="licenseplate">Licenseplate</param>
        /// <param name="date">Date</param>
        public OresundMC(string licenseplate, DateTime date) : base(licenseplate, date)
        {
        }

        public override double Price(bool brobizz)
        {
            double price = 161;
            if (brobizz) price = 73;
            return price;
        }

        /// <inheritdoc/>

        public override string VehicleType()
        {
            return "Oresund MC";
        }


    }
}
