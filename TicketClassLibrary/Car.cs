namespace TicketClassLibrary
{
    /// <summary>
    /// This class represents a car. Nothing is static, so class has to be instantiated to be used.
    /// </summary>
    public class Car : Vehicle
    {

        /// <summary>
        /// Method to return price of the instance
        /// </summary>
        /// <returns>Price of the instance</returns>
        public override double Price(bool brobizz)
        {
            double _price = 240; 
            if (brobizz)
            {
                return _price * 0.95;
            }

            return _price; 
        }

        /// <summary>
        /// Method to return the type of the vehicle
        /// </summary>
        /// <returns>A string: "Car"</returns>
        public override string VehicleType()
        {
            return "Car"; 
        }

    }
}
