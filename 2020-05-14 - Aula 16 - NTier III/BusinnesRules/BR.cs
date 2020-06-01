using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using BusinessObjects;
using Offices;

namespace BusinnesRules
{
    public class BR
    {

        public static bool TryInsertNewOffice(Office o)
        {
            //test
            return MechanicOffices.AddOffice(o);
        }
    }
}
