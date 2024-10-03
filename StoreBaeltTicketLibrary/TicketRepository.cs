using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TicketClassLibrary;

namespace StoreBaeltTicketLibrary
{
    /// <summary>
    /// Class to contain tickets for vehicles crossing the Storebaelt-bridge
    /// </summary>
    public class TicketRepository : ITicketRepository
    {
        /// <summary>
        /// Constructor in order to use instance-methods
        /// </summary>
        public TicketRepository()
        {

        }

        /// <summary>
        /// TicketList static property
        /// </summary>
        public static List<Ticket> TicketList { get; set; } = new List<Ticket>();

        /// <summary>
        /// Method to buy a ticket
        /// </summary>
        /// <param name="t">Ticket instance to add</param>
        /// <param name="brobizz">Does the vehicle use brobizz for this instance</param>
        public void AddTicket(Vehicle v, bool brobizz) => TicketList.Add(new Ticket(v, brobizz));

        /// <summary>
        /// Print all Tickets in the List
        /// </summary>
        public void PrintAllTickets()
        {
            int i = 1;
            foreach (var item in TicketList)
            {
                Console.WriteLine($"Ticket #{i}: {item.ToString()}");
                i++;
            }
        }

        /// <summary>
        /// Prints all Tickets related to a given Licenseplate
        /// </summary>
        /// <param name="lplate"></param>
        public void PrintTicketsForLicenseplate(string lplate)
        {
            int i = 1;
            foreach (var item in TicketList.Where(x => x.VehicleInstance.Licenseplate == lplate))
            {
                
                Console.WriteLine($"Ticket #{i}: {item.ToString}");
                i++;
            }
        }

    }
}
