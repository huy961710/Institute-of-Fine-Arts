using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Manage_Staff.Models;

namespace Manage_Staff.Controllers
{
    public class StaffsController : Controller
    {
        StaffDB db;
        public StaffsController(StaffDB db)
        {
            this.db = db;
        }

        public IActionResult Index()
        {
            var list = db.Staff.ToList();
            return View(list);
        }
    }
}
