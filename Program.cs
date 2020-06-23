using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Testing
{
    class Program
    {
        static void Main(string[] args)
        {
            string date1 = DateTime.Now.ToUniversalTime().ToString();
            string date2 = DateTime.UtcNow.ToString();
        }
    }
}
