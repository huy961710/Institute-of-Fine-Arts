﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
//step 1
using Student_Design_Posting.Models;
using Microsoft.AspNetCore.Http;
using System.IO;
using System.Runtime.InteropServices.ComTypes;
using Microsoft.AspNetCore.Mvc.Rendering;
using System.ComponentModel;
using System.Dynamic;

namespace Student_Design_Posting.Controllers
{
    public class StudentDesignPostingController : Controller
    {
        //step 2
        StudentDB db;
        public StudentDesignPostingController(StudentDB db)
        {
            this.db = db;
        }

        //step 3
        //INDEX for Student View Design
        public IActionResult Index()
        {
            if (HttpContext.Session.GetString("studentid") == null) //check session
            {
                return RedirectToAction("Login");
            }
            else
            {
                var list = from d in db.Design
                           join s in db.Student on d.StudentId equals s.StudentId
                           where s.StudentId.Equals(HttpContext.Session.GetString("studentid")) //check student
                           select new DesignStudent
                           {
                               Design = d,
                               Student = s
                           };
               return View(list);
            }
        }

        //EDIT
        public IActionResult Edit(int id)
        {
            if (HttpContext.Session.GetString("studentid") == null) //check session
            {
                return RedirectToAction("Login");
            }
            else
            {
                var model = db.Design.Find(id);
                //check model is not null and this DesignStudentId == Session
                if (model != null && model.StudentId.Equals(HttpContext.Session.GetString("studentid")))
                {
                    return View(model); ;
                }
                else
                {
                    return RedirectToAction("Login");
                }
            } //end check session
        }
        [HttpPost]
        [ValidateAntiForgeryToken]
        public IActionResult Edit(Design design, IFormFile file)
        {
            try
            {
                var model = db.Design.SingleOrDefault(s => s.DesignId.Equals(design.DesignId));
                if (ModelState.IsValid)
                {
                    if (model != null)
                    {
                        //get DesignId for check Competition
                        var modelPosting = db.Posting.SingleOrDefault(p => p.DesignID.Equals(model.DesignId));
                        var modelCompetition = db.Competition.SingleOrDefault(c => c.CompetitionId.Equals(modelPosting.CompetitionId));

                        DateTime today = Convert.ToDateTime(DateTime.Today);
                        ////check today SubmitDate                     
                        if (today >= modelCompetition.StartDate.Date && today <= modelCompetition.EndDate.Date)
                        {
                            if (file != null && file.Length > 0 && Path.GetExtension(file.FileName).ToLower().Equals(".jpg")) //profile images must be .jpg
                            {
                                string path = Path.Combine("wwwroot/images", file.FileName);
                                var stream = new FileStream(path, FileMode.Create);
                                file.CopyToAsync(stream);
                                model.DesignName = design.DesignName;
                                design.Painting = "../images/" + file.FileName;
                                model.Painting = design.Painting;
                                model.Description = design.Description;
                                //Student cannot change DesignId and StudentId and SubmitDate >= StartDate && <= EndDate of Competition                                
                                stream.Close();
                                //add posting
                                modelPosting.PostDate = today;
                                db.SaveChanges();
                                return RedirectToAction("Index");
                            }
                            else if (file == null) //if no change painting
                            {
                                model.DesignName = design.DesignName;
                                model.Description = design.Description;
                                //add posting
                                modelPosting.PostDate = today;
                                db.SaveChanges();
                                return RedirectToAction("Index");
                            }
                            else
                            {
                                ViewBag.Msg = "Painting must be .jpg";
                            }
                        }
                        else
                        {
                            ViewBag.Msg = "Time to submit pictures for competition has expired ( Endate: " + modelCompetition.EndDate.ToString() + " )";                            
                        }// End check Design Submitdate
                    }//END check model
                    else
                    {
                        ViewBag.Msg = "Failed";
                    }
                }
                else
                {
                    ViewBag.Msg = "Update Failed";
                }
            }
            catch (Exception e)
            {
                ViewBag.Msg = e.Message;
            }
            return View();
        }

        //Student Register to Join Competition
        //1. View InCommingCompetition
        public IActionResult InCommingCompetition()
        {
            DateTime today = Convert.ToDateTime(DateTime.Today);
            var list = (from c in db.Competition
                       where today >= c.StartDate.Date && today <= c.EndDate.Date
                       select c).ToList();
            return View(list);
        }

        //2. UPDATE to join

        //UPLOAD   
        public IActionResult Upload(int id)
        {
            string stuId = HttpContext.Session.GetString("studentid");
            if (stuId == null) //check login
            {
                return RedirectToAction("Login");
            }
            else
            {
                var postList = (from p in db.Posting
                           join d in db.Design on p.DesignID equals d.DesignId
                           where p.CompetitionId == id && d.StudentId.Equals(stuId) && p.DesignID.Equals(d.DesignId)
                           select new DesignPosting
                           {
                               Design = d,
                               Posting = p
                           }).ToList();
                if (postList.Count>0) //check row
                {
                    TempData["testmsgs"] = "<script>alert('You have already registered for this competition');</script>";
                    return RedirectToAction("InCommingCompetition");
                }
                else
                {                
                    HttpContext.Session.SetInt32("registerCompetitionId", id); // competitionId
                    return View();
                }
            }
        }
        [HttpPost]
        [ValidateAntiForgeryToken]
        public IActionResult Upload(Design design, IFormFile file)
        {
            try
            {
                if (ModelState.IsValid)
                {
                    int competitionId = (int)HttpContext.Session.GetInt32("registerCompetitionId");
                    DateTime today = Convert.ToDateTime(DateTime.Today);

                    if (file != null && file.Length > 0 && Path.GetExtension(file.FileName).ToLower().Equals(".jpg")) //profile images must be .jpg
                        {
                            string path = Path.Combine("wwwroot/images", file.FileName);
                            var stream = new FileStream(path, FileMode.Create);
                            file.CopyToAsync(stream);
                            design.Painting = "../images/" + file.FileName;
                            design.StudentId = HttpContext.Session.GetString("studentid"); //login session
                            db.Design.Add(design);
                            db.SaveChanges();
                            stream.Close();
                            //add posting
                            var modelPosting = new Posting();
                            modelPosting.PostDate = today.Date;
                            modelPosting.DesignID = design.DesignId;
                            modelPosting.CompetitionId = competitionId; //session registerCompetitionId
                            db.Posting.Add(modelPosting);
                            db.SaveChanges();
                            return RedirectToAction("Index");
                        }
                        else
                        {
                            ViewBag.Msg = "Painting must be .jpg";
                            return View();
                        }
                }
                else
                {
                    ViewBag.Msg = "Model is invalid.";
                }
            }
            catch (Exception e)
            {
                ViewBag.Msg = e.Message;
            }            
            return View();
        }

        //LOGIN        
        public IActionResult Login()
        {
            return View();
        }
        [HttpPost]
        [ValidateAntiForgeryToken]
        public IActionResult Login(StudentLogin studentLogin)
        {
            try
            {
                if (ModelState.IsValid)
                {
                    var model = db.Student.Where(s => s.StudentId.Equals(studentLogin.StudentId)).FirstOrDefault();
                    if (model != null) //if found
                    {
                        var key = "b14ca5898a4e4133bbce2ea2315a1916";
                        model.Password = AesEncDesc.DecryptString(key, model.Password);
                        if (model.Password.Equals(studentLogin.Password))
                        {
                            HttpContext.Session.SetString("studentid", studentLogin.StudentId); //session
                            return RedirectToAction("Index");
                        }
                        else
                        {
                            ViewBag.Msg = "Wrong Password";
                        }
                    }
                    else
                    {
                        ViewBag.Msg = "Username not found";
                    }
                }
            }
            catch (Exception ex)
            {
                ViewBag.Msg = ex.Message;
            }
            return View();
        }

        //LOGOUT
        public IActionResult Logout()
        {
            var model = HttpContext.Session.GetString("studentid");
            if (model != null)
            {
                HttpContext.Session.Clear();
                return RedirectToAction("Login");

            }
            return View();
        }
    }//end controller
}
