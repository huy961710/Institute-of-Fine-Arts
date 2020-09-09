using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
//step 1
using Manage_design.Models;
using Microsoft.AspNetCore.Http;
using System.IO;
namespace Manage_design.Controllers
{
    public class DesignsController : Controller
    {
        //step 2
        DesignDB db;
        public DesignsController(DesignDB db)
        {
            this.db = db;
        } 
        //step 3 
        //INDEX
        public IActionResult Index()
        {
            //if (HttpContext.Session.GetString("staffname") == null) //check session
            //{
            //    return RedirectToAction("Login");
            //}
            //else
            //{
                //IEnumerable<Student> list = db.Student.ToList();
                var list = from d in db.Design
                           join s in db.Student on d.StudentId equals s.StudentId                           
                           select new DesignStudent //missing Posting (mark)
                           {
                               Design = d,
                               Student = s                               
                           };
                return View(list);
            //}
        }       
    }
}
