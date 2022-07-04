using clinicSystem2102.data;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace clinicSystem2102.services
{
   public interface Ipateint
    {
        void Insert(patient p);
        List<patient> loadByName(string name);

    }
}
