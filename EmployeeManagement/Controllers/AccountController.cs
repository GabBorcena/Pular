using EmployeeManagement.Models;
using EmployeeManagement.ViewModel;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Web;
using System.Web.Mvc;

namespace EmployeeManagement.Controllers
{
    public class AccountController : Controller
    {
        // GET: Account
        [HttpGet]
        public ActionResult Login()
        {
            ViewFormViewModel viewModel = new ViewFormViewModel()
            {
                userAuthentication = new UserAuthentication() 
            };
            return View(viewModel);
        }
        // POST: Account
        [HttpPost]
        public ActionResult Login(ViewFormViewModel viewModel)
        {
            if (viewModel.userAuthentication.Username == "Admin")
            {
                if (viewModel.userAuthentication.Password == "Admin")
                {
                    Session["USER_SESSION"] = "Admin";

                    ViewBag.Status = "1";
                    ViewBag.Message = "Log in Successfull!";

                    return RedirectToAction("Index", "Home");
                }
                else
                {
                    ViewBag.Status = "0";
                    ViewBag.Message = "Incorrect username or password.";
                }
            }
            else {
                ViewBag.Status = "0";
                ViewBag.Message = "Incorrect username or password.";
            }
            return View();
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult LogOff()
        {
            Session["USER_SESSION"] = null;
            return RedirectToAction("Index", "Home");
        }

        public ActionResult AddToCart(string name, string description, string price)
        {
            Session["product_name"] = name;
            Session["product_description"] = description;
            Session["product_price"] = price;

            return this.Json(new { success = Session["product_name"] });
        }
    }
}