namespace StoreBaeltTicketLibrary
{
    public interface ITicketRepository
    {
        void Add(Ticket ticket);
        void GetAll();
        void TicketsForLicensePlate(string licensePlate);
    }
}