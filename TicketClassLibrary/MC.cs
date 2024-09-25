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
    public class MC : Vehicle
    {
        

        
        /// <returns>Price of the instance</returns>/// <summary>
        /// Method to return the type of the vehicle.
        /// </summary>
        /// <returns>A string: "MC".</returns>
        public override string VehicleType()
        {
            return "MC"; 
        }

/// <inheritdoc/>

        public override double Price(bool brobizz)
        {
            double _price = 125;
            if (brobizz)
            {
                return _price * 0.95;
            }
            return _price;
        }

        

        

    }
}
