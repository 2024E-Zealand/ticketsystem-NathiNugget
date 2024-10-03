using TicketClassLibrary;

namespace StoreBaeltTicketLibrary
{
    /// <summary>
    /// This class inherits from Car using the DLL and has extra savings on Saturdays and Sundays
    /// </summary>
    public class StoreBaeltsCar : Car
    {

        /// <summary>
        /// This constructor calls to Car
        /// </summary>
        /// <param name="lPlate">License plate</param>
        /// <param name="lDate">Date</param>
        public StoreBaeltsCar(string lPlate, DateTime lDate) : base(lPlate, lDate)
        {
        }

        /// <summary>
        /// Get price of a ticket and ask if the vehicle has the Brobizz
        /// </summary>
        /// <param name="brobizz">If the user has brobizz</param>
        /// <returns>The price</returns>
        public override double Price(bool brobizz)
        {
            double price = 240; 
            if (Date.DayOfWeek == DayOfWeek.Sunday || Date.DayOfWeek == DayOfWeek.Saturday)
            {
                price *= 0.8; 
            }
            if (brobizz)
            {
                price *= 0.95; 
            }
            return price;
        }
/// <inheritdoc/>

       
        public override string VehicleType()
        {
            return "StoreBaeltsCar"; 
        }
    }
}
