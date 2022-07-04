using clinicSystem2102.data;
using clinicSystem2102.Models;
using clinicSystem2102.services;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Threading.Tasks;

namespace clinicSystem2102.Controllers
{
    public class patientController : Controller
    {
        Ipateint pservice;
        Icountry ecountry;
        public patientController(Ipateint _pservice, Icountry _ecountry)
        {
            pservice = _pservice;
            ecountry = _ecountry;


        }
        public IActionResult Index()
        {
           //  ClinicContext context = new ClinicContext();
            vmpatient vm = new vmpatient();
            // vm.Licountry = new List<Country>();
            //  List<Country> li = (from cint in context.countries
            //       select cint).ToList();
            //List<Country> li = context.countries.ToList();
            //vm.Licountry = li;
            vm.Licountry = ecountry.loadAll();
            return View("NewPatient", vm);
        }
        public IActionResult save(vmpatient vm)
        {
            //ClinicContext context = new ClinicContext();
            //context.patients.Add(vm.patient);
            //context.SaveChanges();
            // pateintService pservice = new pateintService();
          


            pservice.Insert(vm.patient);
            //List<Country> li = (from cint in context.countries
            //                    select cint).ToList();

            //List<Country> li = context.countries.ToList();
            //vm.Licountry = li;
            vm.Licountry = ecountry.loadAll();

            return View("NewPatient",vm);
        }
        public IActionResult Index1()
        {
            List<patient> li = new List<patient>();


            return View("patientlist",li) ;
        }
        public IActionResult search()
        {
          //  ClinicContext context = new ClinicContext();
            List<patient> li = new List<patient>();
            string name = Request.Form["txtName"];
            //li = (from p in context.patients
            //      where p.Name == name
            //      select p).ToList();
            //li = context.patients.Where(p => p.Name == name).ToList();


          li=  pservice.loadByName(name);
            return View("patientlist", li);
        }
    }
}