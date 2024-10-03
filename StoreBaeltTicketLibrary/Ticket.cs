using System.ComponentModel;
using TicketClassLibrary;

namespace StoreBaeltTicketLibrary
{
    /// <summary>
    /// Ticket class containing info about which vehicle bought a ticket as well as price for the ticket.
    /// </summary>
    public class Ticket
    {
        /// <summary>
        /// Constructor for Ticket-class
        /// </summary>
        /// <param name="v">Vehicle for the ticket</param>
        /// <param name="brobizz">Does the vehicle use a BroBizz?</param>
        public Ticket(Vehicle v, bool brobizz)
        {
            VehicleInstance = v;
            Price = v.Price(brobizz); 
        }
        /// <summary>
        /// Vehicle this Ticket is credited to
        /// </summary>
        public Vehicle VehicleInstance {  get; set; }
        /// <summary>
        /// Property for price of the Ticket-instance
        /// </summary>
        public double Price { get; set; }
/// <inheritdoc/>

        
        public override string ToString()
        {
            return $"Vehicle Licenselate: {VehicleInstance.Licenseplate}, Date: {VehicleInstance.Date}, Price: {Price}";
        }
    }
}