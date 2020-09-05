using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Manage_subject.Models;

namespace Manage_subject.Controllers
{
    public class SubjectsController : Controller
    {
        SubjectDB db;
        public SubjectsController(SubjectDB db)
        {
            this.db = db;
        }

        public IActionResult Index()
        {
            var list = db.Subjects.ToList();
            return View(list);
        }
    }
}
