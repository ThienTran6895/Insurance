using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Insurance.Models
{
    public class Customer
    {
        public Customer()
        {
            AvailableField = new List<SelectListItem>();
        }


        public Guid CustomerID { get; set; }
        public string Name { get; set; }
        public string Dob { get; set; } 
        public int Age { get; set; }
        public string Job { get; set; }
        public int Money { get; set; }
        public int Duration { get; set; }
        public string PayDuration { get; set; }
        public int TaxPerYear { get; set; }
        public Guid ProductID { get; set; }
        public string BasicIns_quy { get; set; }
        public string BasicIns_nuanam { get; set; }
        public string BasicIns_nam { get; set; }
        public string AddItemIns_quy { get; set; }
        public string AddItemIns_nuanam { get; set; }
        public string AddItemIns_nam { get; set; }
        public string PayAdd_quy { get; set; }
        public string PayAdd_nuanam { get; set; }
        public string PayAdd_nam { get; set; }

        public List<SelectListItem> AvailableField { get; set; }
    }
}