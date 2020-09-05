using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Http;
using Manage_class.Models;

namespace Manage_class.Controllers
{
    public class ClasssController : Controller
    {
        ClassDB db;
        public ClasssController(ClassDB db)
        {
            this.db = db;
        }

        public IActionResult Index()
        {
            var list = db.Classs.ToList();
            return View(list);
        }

        [HttpGet]
        public IActionResult Create()
        {
            return View();
        }
        [HttpPost]
        [ActionName("Create")]
        public IActionResult Create(Class newClass)
        {
            try
            {
                var cls = db.Classs.SingleOrDefault(c => c.ClassId.Equals(newClass.ClassId));

                if (ModelState.IsValid && cls == null)
                {
                    db.Classs.Add(newClass);
                    db.SaveChanges();
                    return RedirectToAction("Index", "Classs");
                }
                else
                {
                    ViewBag.Msg = "Failed .......";
                }
            }
            catch (Exception e)
            {
                ViewBag.Msg = e.Message;
            }
            return View();
        }

        public IActionResult Edit(string id)
        {
            var cls = db.Classs.Find(id);
            if (cls != null)
            {
                return View(cls);
            }
            else
            {
                return View();
            }
        }
        [HttpPost]
        public IActionResult Edit(Class eClass)
        {
            try
            {
                var editClass = db.Classs.SingleOrDefault(c => c.ClassId.Equals(eClass.ClassId));
                if (ModelState.IsValid)
                {
                    if (editClass != null)
                    {
                        editClass.ClassName = eClass.ClassName;
                        db.SaveChanges();

                        return RedirectToAction("Index", "Classs");
                    }
                    else
                    {
                        ViewBag.Msg = "Failed .......";
                    }
                }
            }
            catch (Exception e)
            {
                ViewBag.Msg = e.Message;
            }
            return View();
        }
    }
}
