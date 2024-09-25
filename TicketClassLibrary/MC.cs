using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TicketClassLibrary
{
    /// <summary>
    /// MC vehicle class. Nothing is static, so class has to be instantiated to be used.
    /// </summary>
    public class MC
    {
        /// <summary>
        /// Method to return price of the instance.
        /// </summary>
        /// <returns>Price of the instance.</returns>
        public double Price()
        {
            return 125; 
        }
        /// <returns>Price of the instance</returns>/// <summary>
        /// Method to return the type of the vehicle.
        /// </summary>
        /// <returns>A string: "MC".</returns>
        public string Vehicle()
        {
            return "MC"; 
        }

        /// <summary>
        /// Property of the Licenseplate of the Car
        /// </summary>
        public string Licenseplate {  get; set; }
        /// <summary>
        /// Property of the Date of the Car
        /// </summary>
        public DateTime date { get; set; }

    }
}
