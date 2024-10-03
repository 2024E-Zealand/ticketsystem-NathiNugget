using TicketClassLibrary;

namespace StoreBaeltTicketLibrary
{
    public interface ITicketRepository
    {
        void AddTicket(Vehicle v, bool brobizz);
        void PrintAllTickets();
        void PrintTicketsForLicenseplate(string lplate);
    }
}