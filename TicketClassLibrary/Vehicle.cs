using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.AccessControl;
using System.Text;
using System.Threading.Tasks;

namespace TicketClassLibrary
{
    /// <summary>
    /// Represents the skeleton of a vehicle to be further described in lower classes
    /// </summary>
    public abstract class Vehicle
    {
        /// <summary>
        /// Method signature for the Price of a vehicle to be overwritten
        /// </summary>
        /// <returns>Price of the vehicle</returns>
        public abstract double Price();

        /// <summary>
        /// Returns the type of the vehicle
        /// </summary>
        /// <returns>Type of vehicle in string representation</returns>
        public abstract string VehicleType();

        /// <summary>
        /// Property for a Licenseplate for the vehicle
        /// </summary>






        public string Licenseplate
        {
            get { return Licenseplate; }

            set
            {
                if (value == null || value.Length > 7)
                {
                    throw new ArgumentException("License plate must not be longer than 7 characters!");
                }
                Licenseplate = value;
            }
        }

        /// <summary>
        /// Property for a Date for an instance
        /// </summary>
        public DateTime Date { get; set; }


    }
}
