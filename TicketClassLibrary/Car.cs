using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TicketClassLibrary
{
    /// <summary>
    /// This class represents a car
    /// </summary>
    /// <param name="lPlate">License plate</param>
    /// <param name="lDate">Date</param>
    public class Car(string lPlate, DateTime lDate) : Vehicle
    {
        /// <inheritdoc/>
        
        public override string VehicleType()
        {
            return "Car"; 
        }
        /// <inheritdoc/>
        public override double Price()
        {
            return 240; 
        }

        /// <inheritdoc/>
        public override string Licenseplate { get; protected set; } = lPlate;
        /// <inheritdoc/>
        public override DateTime Date { get; protected set; } = lDate;

    }
}
