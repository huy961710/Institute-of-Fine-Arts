using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Manage_manager.Models;

namespace Manage_manager.Controllers
{
    public class ManagersController : Controller
    {
        ManagerDB db;
        public ManagersController(ManagerDB db)
        {
            this.db = db;
        }

        public IActionResult Index()
        {
            var list = db.Managers.ToList();
            return View(list);
        }
    }
}
