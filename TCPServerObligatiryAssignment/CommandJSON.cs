using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TCPServerObligatiryAssignment
{
    public class CommandJSON
    {
        public CommandJSON(string method, int num1, int num2)
        {
            Method = method;
            Num1 = num1;
            Num2 = num2;
        }

        public string Method { get; set; }
        public int Num1 { get; set; }
        public int Num2 { get; set; }
    }
}
