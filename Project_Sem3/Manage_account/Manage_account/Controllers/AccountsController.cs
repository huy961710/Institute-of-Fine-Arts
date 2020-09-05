using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Manage_account.Models;
using Microsoft.AspNetCore.Http;

namespace Manage_account.Controllers
{
    public class AccountsController : Controller
    {
        AccountDB db;
        public AccountsController(AccountDB db)
        {
            this.db = db;
        }

        public IActionResult Index()
        {
            if (HttpContext.Session.GetString("ename") == null)
            {
                return RedirectToAction("Login");
            }
            else
            {
                var list = db.Accounts.ToList();
                return View(list);
            }
        }

        [HttpGet]
        public IActionResult Create()
        {
            return View();
        }
        [HttpPost]
        [ActionName("Create")]
        public IActionResult Create(Account account)
        {
            try
            {
                var acc = db.Accounts.SingleOrDefault(a => a.AccId.Equals(account.AccId));

                if (ModelState.IsValid && acc == null)
                {
                    var key = "b14ca5898a4e4133bbce2ea2315a1916";
                    account.AccPass = AesEncDesc.EncryptString(key, account.AccPass); //encrypt password
                    db.Accounts.Add(account);
                    db.SaveChanges();
                    return RedirectToAction("Index", "Accounts");
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
            var account = db.Accounts.Find(id);
            if (account != null)
            {
                return View(account);
            }
            else
            {
                return View();
            }
        }
        [HttpPost]
        public IActionResult Edit(Account account)
        {
            try
            {
                var editAccount = db.Accounts.SingleOrDefault(a => a.AccId.Equals(account.AccId));
                if (ModelState.IsValid)
                {
                    if (editAccount != null)
                    {
                            editAccount.Active = account.Active;
                            db.SaveChanges();

                            return RedirectToAction("Index", "Accounts");
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

        public IActionResult Delete(string id)
        {
            try
            {
                var account = db.Accounts.SingleOrDefault(a => a.AccId.Equals(id));
                if (account != null)
                {
                    db.Accounts.Remove(account);
                    db.SaveChanges();
                    return RedirectToAction("Index");
                }
                else
                {
                    return View();
                }
            }
            catch (Exception)
            {
                throw;
            }
        }

        [HttpGet]
        public IActionResult Login()
        {
            return View();
        }
        [HttpPost]
        public IActionResult Login(string accName, string accPass)
        {
            try
            {
                var account = db.Accounts.SingleOrDefault(a => a.AccId.Equals(accName));
                if (account != null)
                {
                    HttpContext.Session.SetString("ename", accName);
                    var key = "b14ca5898a4e4133bbce2ea2315a1916";
                    account.AccPass = AesEncDesc.DecryptString(key, account.AccPass); //Decrypt password
                    if (account.AccPass.Equals(accPass))
                    {
                        if(account.Active == true)
                        {
                            if (account.AccRole == 0)
                            {
                                return RedirectToAction("Index");
                            }
                            else
                            {
                                return RedirectToAction("Info", account);
                            }
                        }
                        else
                        {
                            ViewBag.Msg = "Your account is deactived. Contact admin for more information";
                        }
                    }
                    else
                    {
                        ViewBag.Msg = "Invalid Pasword....";
                    }
                }
                else
                {
                    ViewBag.Msg = "Invalid Username....";
                }
            }
            catch (Exception e)
            {
                ViewBag.Msg = e.Message;
            }
            return View();
        }

        public IActionResult Info(Account account)
        {
            if (account != null)
            {
                return View(account);
            }
            return View();
        }

        public IActionResult Logout()
        {
            var model = HttpContext.Session.GetString("ename");
            if (model != null)
            {
                HttpContext.Session.Clear();
                return RedirectToAction("Login");

            }
            return RedirectToAction("Index");
        }
    }
 }

