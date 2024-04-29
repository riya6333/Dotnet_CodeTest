using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;


namespace Assessment1.Controllers
{
    public class CodeController : Controller
        
    {
        private NorthwindEntities db = new NorthwindEntities();
        // GET: Code
        public ActionResult Index()
        {
            return View();
        }

       
        public ActionResult GermanyCustomers()
        {
            var germanCustomers = db.Customers.Where(c => c.Country == "Germany").ToList();
            return View(germanCustomers);
        }

       
        public ActionResult OrderDetails()
        {
            var orderDetails = db.Orders.FirstOrDefault(o => o.OrderID == 10248)?.Customer;
            return View(orderDetails);
        }
    }
}