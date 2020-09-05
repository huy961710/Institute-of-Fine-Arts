using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Manage_address.Models;

namespace Manage_address.Controllers
{
    public class AddresssController : Controller
    {
        AddressDB db;
        public AddresssController(AddressDB db)
        {
            this.db = db;
        }

        public IActionResult Index()
        {
            var list = db.Address.ToList();
            return View(list);
        }

        [HttpGet]
        public IActionResult Create()
        {
            return View();
        }
        [HttpPost]
        public IActionResult Create(Address address)
        {
            try
            {
                if (ModelState.IsValid)
                {
                    db.Address.Add(address);
                    db.SaveChanges();
                    return RedirectToAction("Index", "Addresss");
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

        public IActionResult Edit(int id)
        {
            var cls = db.Address.Find(id);
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
        public IActionResult Edit(Address address)
        {
            try
            {
                var editAddress = db.Address.SingleOrDefault(a => a.AddressId.Equals(address.AddressId));
                if (ModelState.IsValid)
                {
                    if (editAddress != null)
                    {
                        editAddress.StreetAddress = address.StreetAddress;
                        editAddress.Country = address.Country;
                        editAddress.PostalCode = editAddress.PostalCode;
                        editAddress.City = address.City;
                        db.SaveChanges();

                        return RedirectToAction("Index", "Addresss");
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
