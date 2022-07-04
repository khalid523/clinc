using clinicSystem2102.data;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace clinicSystem2102.services
{
    public class pateintService:Ipateint
    {
        ClinicContext context;
        public pateintService(ClinicContext _Context)
        {
            context = _Context;
        }
        public void Insert(patient p)
        {
          //  ClinicContext context = new ClinicContext();
            context.patients.Add(p);
            context.SaveChanges();
        }
        public List<patient> loadByName(string name)
        {
           // ClinicContext context = new ClinicContext();
            List<patient> li = new List<patient>();
            li = context.patients.Where(p => p.Name == name).ToList();
            return li;
        }
        }
}
