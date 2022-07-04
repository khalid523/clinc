using clinicSystem2102.data;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace clinicSystem2102.services
{
   public interface Icountry
    {
        void Insert(Country c);
        List<Country> loadAll();

    }
}
