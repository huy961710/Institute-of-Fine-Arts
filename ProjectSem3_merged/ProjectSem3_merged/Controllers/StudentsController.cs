using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using ProjectSem3_merged.Models;
using Microsoft.AspNetCore.Http;
using System.IO;

namespace ProjectSem3_merged.Controllers
{
    public class StudentsController : Controller
    {
        ProjectDB db;
        public StudentsController(ProjectDB db)
        {
            this.db = db;
        }

        public IActionResult Index()
        {
            var list = db.Students.ToList();
            return View(list);
        }
    }
}
