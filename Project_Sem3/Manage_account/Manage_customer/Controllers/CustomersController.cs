using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Manage_customer.Models;

namespace Manage_customer.Controllers
{
    public class CustomersController : Controller
    {
        CustomerDB db;
        public CustomersController(CustomerDB db)
        {
            this.db = db;
        }

        public IActionResult Index()
        {
            var list = db.Customers.ToList();
            return View(list);
        }
    }
}
