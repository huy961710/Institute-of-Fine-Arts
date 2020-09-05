using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Manage_administrator.Models;

namespace Manage_administrator.Controllers
{
    public class AdministratorsController : Controller
    {
        AdministratorDB db;
        public AdministratorsController(AdministratorDB db)
        {
            this.db = db;
        }


        public IActionResult Index()
        {
            var list = db.Administrators.ToList();
            return View(list);
        }
    }
}
