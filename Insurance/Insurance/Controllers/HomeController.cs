using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Web;
using System.Web.Mvc;
using Insurance.Interface;
using Insurance.Models;
using Insurance.Repository;

namespace Insurance.Controllers
{
    public class HomeController : Controller
    {        
        //[Dependency]
        //public ICustomerRepository customerRepository { get; set; }

        [HttpPost]
        public ActionResult AddCustomer(Customer customer)
        {
            //var customer = new List<Customer>();
            //customer.Add(new Customer() {
            //    Name = Name
            //});       
            //var result = customerRepository.GetByUserLogin(customer);          
            
            return View(customer);
        }

        

        public ActionResult Index()
        {
            return View();
        }

        
    }
}