using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using BusinessObjects;

namespace Offices
{
    public class MechanicOffices
    {
        static List<Office> toDo;


        static MechanicOffices()
        {
            toDo = new List<Office>();
        }

        public static bool AddOffice(Office o)
        {
            //test
            toDo.Add(o);
            return true;
        }

    }
}
