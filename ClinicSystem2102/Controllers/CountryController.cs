using clinicSystem2102.data;
using clinicSystem2102.Models;
using clinicSystem2102.services;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace clinicSystem2102.Controllers
{
    public class CountryController : Controller
    {
        Icountry ecountry;
        public CountryController(Icountry _ecountry)
        {
            ecountry = _ecountry;
        }
        public IActionResult Index()
        {
            //ClinicContext context = new ClinicContext();
            vmcountry vm = new vmcountry();

            //List<Country> li = (from cint in context.countries
            //                    select cint).ToList();
            //List<Country> li = context.countries.ToList();
            //vm.Licountry = li;
            vm.Licountry = ecountry.loadAll();
            return View("newcountry", vm);
            
        }
        public IActionResult save(vmcountry vm)
        {
            //ClinicContext context = new ClinicContext();
            //context.countries.Add(vm.country);
            //context.SaveChanges();
            //List<Country> li = (from cint in context.countries
            //                    select cint).ToList();
            //List<Country> li = context.countries.ToList();
            vm.Licountry = ecountry.loadAll();
            //vm.Licountry = li;
            return View("newcountry",vm);
        }
        }
}
