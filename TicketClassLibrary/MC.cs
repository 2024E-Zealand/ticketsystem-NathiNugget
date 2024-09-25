using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TicketClassLibrary
{
    public class MC
    {

        public double Price()
        {
            return 125; 
        }

        public string Vehicle()
        {
            return "MC"; 
        }

        public string Licenseplate {  get; set; }
        public DateTime date { get; set; }

    }
}
