using System;
using System.Linq;
using Microsoft.AspNetCore.Mvc;
using Northwind.Models;

namespace Norwithwind.Controllers
{
    public class CustomerController : Controller
    {
        private NorthwindContext _northwindContext;

        public CustomerController(NorthwindContext db) => _northwindContext = db;

        public IActionResult Register() => View();


        [HttpPost]
        public IActionResult Register (Customer customer){
            if(!ModelState.IsValid){
                 ModelState.AddModelError("", "Invalid data");
            }
            else{
                _northwindContext.Register(customer);
                return RedirectToAction("Index", "Customer");
            } 
            return View();
        }
    }

}