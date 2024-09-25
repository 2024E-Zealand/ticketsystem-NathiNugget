namespace TicketClassLibrary
{
    /// <summary>
    /// This class represents a car. Nothing is static, so class has to be instantiated to be used.
    /// </summary>
    public class Car
    {

        /// <summary>
        /// Method to return price of the instance
        /// </summary>
        /// <returns>Price of the instance</returns>
        public double Price()
        {

            return 240; 
        }

        /// <summary>
        /// Method to return the type of the vehicle
        /// </summary>
        /// <returns>A string: "Car"</returns>
        public string VehicleType()
        {
            return "Car"; 
        }



        /// <summary>
        /// Property of the Licenseplate of the Car
        /// </summary>
        public string Licenseplate { get; set; }
        /// <summary>
        /// Property of the Date of the Car
        /// </summary>
        public DateTime Date { get; set; }
    }
}
