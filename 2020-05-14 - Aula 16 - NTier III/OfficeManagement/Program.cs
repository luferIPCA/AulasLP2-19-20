using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using BusinessObjects;
using BusinnesRules;

namespace OfficeManagement
{
    class Program
    {
        static void Main(string[] args)
        {
            Car c = new Car();
            c.id = 1;

            Office of1 = new Office();
            of1.idOffice = 1;
            of1.c = c;
            of1.d = DateTime.Today;

            bool aux = BR.TryInsertNewOffice(of1);

        }
    }
}
