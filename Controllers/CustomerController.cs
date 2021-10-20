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
                if(_northwindContext.Customers.Any(c => c.CompanyName == customer.CompanyName))
                {
                 ModelState.AddModelError("", "Invalid data");
                }
            }
            else{
                _northwindContext.Register(customer);
                return RedirectToAction("Index", "Home");
            } 
            return View();
        }
    }

}