using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TicketClassLibrary
{
    /// <summary>
    /// This class represents a vehicle. This class is an abstract base class
    /// </summary>
    public abstract class Vehicle
    {
        /// <summary>
        /// Method to fetch vehicle type for the given implementation
        /// </summary>
        /// <returns>The type of the vehicle</returns>
        public abstract string VehicleType();
        /// <summary>
        /// Get the price of a vehicle
        /// </summary>
        /// <returns>Price of a vehicle</returns>
        public abstract double Price(bool brobizz);

        /// <summary>
        /// Licenseplate for vehicle
        /// </summary>
        public abstract string Licenseplate { get; protected set; }
        /// <summary>
        /// Date for vehicle
        /// </summary>
        public abstract DateTime Date { get; protected set; }
    }
}
