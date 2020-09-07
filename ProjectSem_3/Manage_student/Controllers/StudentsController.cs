using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
//step 1
using Manage_student.Models;
using Microsoft.AspNetCore.Http;
using System.IO;

namespace Manage_student.Controllers
{
    public class StudentsController : Controller
    {
        //step 2
        StudentDB db;
        public StudentsController(StudentDB db)
        {
            this.db = db;
        }

        //step 3
        public IActionResult Index()
        {
            IEnumerable<Student> list = db.Student.ToList();
            return View(list);
        }

        //Login
        public IActionResult Login()
        {
            return View();
        }
        [HttpPost]
        [ValidateAntiForgeryToken]
        public IActionResult Login(StudentLogin studentUser)
        {
            try
            {
                if (ModelState.IsValid)
                {
                    var model = db.Student.Where(s => s.StudentId.Equals(studentUser.StudentId)).FirstOrDefault();
                    if (model != null) //if found
                    {
                        var key = "b14ca5898a4e4133bbce2ea2315a1916";
                        model.Password = AesEncDesc.DecryptString(key, model.Password);
                        if (model.Password.Equals(studentUser.Password))
                        {
                            return RedirectToAction("Index");
                        }
                        else
                        {
                            ViewBag.Msg = "wrong password";
                        }
                    }
                    else
                    {
                        ViewBag.Msg = "username not found";
                    }
                }
            }
            catch(Exception ex)
            {
                ViewBag.Msg = ex.Message;
            }
            return View();
        }

        //Create
        public IActionResult Create()
        {
            return View();
        }
        [HttpPost]
        [ValidateAntiForgeryToken]
        public IActionResult Create(Student student, IFormFile file)
        {
            try
            {
                if (ModelState.IsValid)
                {
                    //if(file.Length > 0)
                    //{
                    //    string path = Path.Combine("wwwroot/images", file.FileName);
                    //    var stream = new FileStream(path, FileMode.Create);
                    //    file.CopyToAsync(stream);
                    //    student.ProfileImage = "images/" + file.FileName;

                    var key = "b14ca5898a4e4133bbce2ea2315a1916";
                    student.Password = AesEncDesc.EncryptString(key, student.Password);
                        db.Student.Add(student);
                        db.SaveChanges();
                        return RedirectToAction("Index", "Students");
                    //}
                    //else
                    //{
                    //    ViewBag.Msg = "Failed";
                    //}
                }
                {
                    ViewBag.Msg = "Missing some thing";
                }
            }catch(Exception ex)
            {
                ViewBag.Msg = ex.Message;
            }
            return View();
        }

        public IActionResult Info(Student student)
        {
            if (student != null)
            {
                return View(student);
            }
            return View();
        }

        public IActionResult Delete(string id)
        {
            try
            {
                var model = db.Student.SingleOrDefault(s => s.StudentId.Equals(id));

                if (model != null)
                {
                    db.Student.Remove(model);
                    db.SaveChanges();
                    return RedirectToAction("Index");
                }
            }
            catch (Exception)
            {
                throw;
            }
            return View();
        }

        public IActionResult Edit(string id)
        {
            var stu = db.Student.Find(id);
            if (stu != null)
            {
                return View(stu);
            }
            else
            {
                return View();
            }
        }
        [HttpPost]
        public IActionResult Edit(Student student, IFormFile file)
        {
            try
            {
                var model = db.Student.SingleOrDefault(s => s.StudentId.Equals(student.StudentId));
                if (ModelState.IsValid)
                {
                    if (model != null)
                    {
                        model.ProfileImage = student.ProfileImage;

                        //if (file.Length > 0)
                        //{
                        //    string path = Path.Combine("wwwroot/images", file.FileName);
                        //    var stream = new FileStream(path, FileMode.Create);
                        //    file.CopyToAsync(stream);
                            //model.ProfileImage = "images/" + file.FileName;

                            model.Password = student.Password;
                            model.FirstName = student.FirstName;
                            model.LastName = student.LastName;
                            model.DateOfBirth = student.DateOfBirth;
                            model.Gender = student.Gender;
                            model.Phone = student.Phone;
                            model.Email = student.Email;
                            //model.JoinDate = student.JoinDate;
                            model.Address = student.Address;
                            model.CompetitionId = student.CompetitionId;
                            db.SaveChanges();
                            return RedirectToAction("Index", "Students");
                        //}
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
