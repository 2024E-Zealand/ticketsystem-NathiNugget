using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StoreBaeltTicketLibrary
{
    public class TicketRepository : ITicketRepository
    {
        public static List<Ticket> Tickets { get; set; } = new List<Ticket>();

        public void Add(Ticket ticket)
        {
            Tickets.Add(ticket);
        }

        public void GetAll()
        {
            int i = 1;
            foreach (Ticket ticket in Tickets)
            {
                Console.WriteLine($"Ticket#{i}: {ticket.ToString()}");
                i++;
            }


        }

        public void TicketsForLicensePlate(string licensePlate)
        {
            foreach (Ticket ticket in Tickets.Where(x => x.Licenseplate == licensePlate))
            {
                Console.WriteLine($"Ticket#{i} for {ticket.Licenseplate}: {ticket.Price}");
            }


        }
    }
