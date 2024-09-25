using TicketClassLibrary;

namespace StoreBaeltTicketLibrary
{
    public class Ticket
    {
        public Ticket(Vehicle vehicle, bool brobizz)
        {
            Licenseplate = vehicle.Licenseplate;
            Price = vehicle.Price(brobizz);  
        }

        /// <summary>
        /// Property for Licenseplate
        /// </summary>
        public string Licenseplate { get; set; }

        /// <summary>
        /// Property for Price
        /// </summary>
        public double Price { get; set; }

        public override string ToString()
        {
            return $"{{{nameof(Licenseplate)}={Licenseplate}, {nameof(Price)}={Price.ToString()}}}";
        }
    }
}