using clinicSystem2102.data;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace clinicSystem2102.services
{
    public class countryService:Icountry
    {
        ClinicContext context;
        public countryService(ClinicContext _context)
        {
            context = _context;
        }
        public void Insert(Country c)
        {
          //  ClinicContext context = new ClinicContext();
            context.countries.Add(c);
            context.SaveChanges();
        }
       public List<Country> loadAll() {
            //ClinicContext context = new ClinicContext();
            List<Country> li = context.countries.ToList();
            return li;
        }
        }
}
