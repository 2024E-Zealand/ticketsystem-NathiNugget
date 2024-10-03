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
    public class Car : Vehicle
    {
        public Car(string lPlate, DateTime lDate)
        {
            Licenseplate = lPlate;
            Date = lDate;
        }

        /// <inheritdoc/>

        public override string VehicleType()
        {
            return "Car"; 
        }
        /// <inheritdoc/>
        public override double Price(bool brobizz)
        {
            double price = 240;
            if (brobizz) price *= 0.95;
            return price; 
        }

        /// <inheritdoc/>
        public override string Licenseplate { get; protected set; }
        /// <inheritdoc/>
        public override DateTime Date { get; protected set; }

        /// <param name="lPlate">License plate</param>
        /// <param name="lDate">Date</param>
        
    }
}
