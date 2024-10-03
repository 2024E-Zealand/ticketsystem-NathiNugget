using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TicketClassLibrary
{
    public class MC : Vehicle
    {
        private string _licenseplate;
        private DateTime _date;

        /// <inheritdoc/>
        public override double Price()
        {
            return 125; 
        }
/// <inheritdoc/>

        public override string VehicleType()
        {
            return "MC"; 
        }
        /// <inheritdoc/>

        public override string Licenseplate { get => _licenseplate; protected set => _licenseplate = value; }
        /// <inheritdoc/>
        public override DateTime Date { get => _date; protected set => _date = value; }


    }
}
