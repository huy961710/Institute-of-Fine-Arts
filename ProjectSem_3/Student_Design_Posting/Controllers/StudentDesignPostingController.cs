using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
//step 1
using Student_Design_Posting.Models;
using Microsoft.AspNetCore.Http;
using System.IO;
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
            if (HttpContext.Session.GetString("studentname") == null) //check session
            {
                return RedirectToAction("Login");
            }
            else
            {
                var list = from d in db.Design
                           join s in db.Student on d.StudentId equals s.StudentId
                           where s.StudentId.Equals(HttpContext.Session.GetString("studentname"))
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
            if (HttpContext.Session.GetString("studentname") == null) //check session
            {
                return RedirectToAction("Login");
            }
            else
            {
                var model = db.Design.Find(id);
                //check model is not null and this DesignStudentId == Session
                if (model != null && model.StudentId.Equals(HttpContext.Session.GetString("studentname")))
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
                        //get StudentId for check CompetitionId
                        var modelStudent = db.Student.SingleOrDefault(s => s.StudentId.Equals(model.StudentId));
                        var modelCompetition = db.Competition.SingleOrDefault(c=>c.CompetitionId.Equals(modelStudent.CompetitionId));
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
                                db.SaveChanges();
                                stream.Close();
                                return RedirectToAction("Index");
                            }
                            else if (file == null) //if no change painting
                            {
                                model.DesignName = design.DesignName;
                                model.Description = design.Description;
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
                            ViewBag.Msg = "Time to submit pictures for competition has expired ( Endate: " + modelCompetition.EndDate.ToString() + " )";
                            return View();
                        }// End check Design Submitdate
                    }//END check model
                    else
                    {                        
                        ViewBag.Msg = "Failed";
                        return View();
                    }
                }
            }
            catch (Exception e)
            {
                ViewBag.Msg = e.Message;
            }
            ViewBag.Msg = "Update Failed";
            return View();
        }

        //Student Register to Join Competition
        //SUA LAI SAU
        public IActionResult ViewCompetitionPage()
        {
            //DateTime today = Convert.ToDateTime(DateTime.Today);
            var list = db.Competition.ToList();
            return View(list);
        }
        //[HttpPost]
        //[ValidateAntiForgeryToken]
        //public IActionResult ViewCompetitionPage(Student student)
        //{
        //    return View();
        //}

        //UPLOAD painting join competition
        public IActionResult Upload()
        {
            if (HttpContext.Session.GetString("studentname") == null) //check login
            {
                return RedirectToAction("Login");
            }
            else
            {
                return View();
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
                    //get StudentId for check CompetitionId
                    var modelStudent = db.Student.SingleOrDefault(s => s.StudentId.Equals(design.StudentId));
                    var modelCompetition = db.Competition.SingleOrDefault(c => c.CompetitionId.Equals(modelStudent.CompetitionId)); //get date of competititon
                    DateTime today = Convert.ToDateTime(DateTime.Today);
                    //check today SubmitDate
                    /*Over-registration is allowed but Mark will be disqualified*/
                    if (file != null && file.Length > 0 && Path.GetExtension(file.FileName).ToLower().Equals(".jpg")) //profile images must be .jpg
                        {
                            string path = Path.Combine("wwwroot/images", file.FileName);
                            var stream = new FileStream(path, FileMode.Create);
                            file.CopyToAsync(stream);
                            design.Painting = "../images/" + file.FileName;
                            db.Design.Add(design);
                            db.SaveChanges();
                            stream.Close();
                            return RedirectToAction("Index");
                        }
                        else
                        {
                            ViewBag.Msg = "Painting must be .jpg";
                            return View();
                        }
                }
            }
            catch (Exception e)
            {
                ViewBag.Msg = e.Message;
            }
            ViewBag.Msg = "Model is invalid.";
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
                            HttpContext.Session.SetString("studentname", studentLogin.StudentId); //session
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
            var model = HttpContext.Session.GetString("studentname");
            if (model != null)
            {
                HttpContext.Session.Clear();
                return RedirectToAction("Login");

            }
            return View();
        }
    }//test
}
