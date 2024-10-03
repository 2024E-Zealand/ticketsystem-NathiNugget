using TicketClassLibrary;

namespace Oresundbron
{
    /// <summary>
    /// This class represents a Car on the Oresund project. It inherits from Car on TicketClassLib DLL
    /// </summary>
    public class OresundCar : Car
    {
        /// <summary>
        /// Constructor passing arguments to base
        /// </summary>
        /// <param name="lPlate">Licenseplate</param>
        /// <param name="lDate">Date</param>
        public OresundCar(string lPlate, DateTime lDate) : base(lPlate, lDate)
        {
        }
/// <inheritdoc/>

        
        public override double Price(bool brobizz)
        {
            double price = 410;
            if (brobizz)
            {
                price = 210;
            }
            return price;
        }
/// <inheritdoc/>

        public override string VehicleType()
        {
            return "Oresund car";
        }
    }
}
