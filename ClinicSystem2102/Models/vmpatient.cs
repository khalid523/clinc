using clinicSystem2102.data;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace clinicSystem2102.Models
{
    public class vmpatient
    {
        public patient patient { set; get; }
        public List<Country> Licountry { set; get; }
    }
}
