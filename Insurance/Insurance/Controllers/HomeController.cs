using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using Insurance.Models;

namespace Insurance.Controllers
{
    public class HomeController : Controller
    {        
        [HttpPost]
        public ActionResult AddCustomer(Customer customer)
        {
            //var customer = new List<Customer>();
            //customer.Add(new Customer() {
            //    Name = Name
            //});       
            
            return View(customer);
        }

        

        public ActionResult Index()
        {
            return View();
        }

        
    }
}