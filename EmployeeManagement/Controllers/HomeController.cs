using System;
using System.Collections.Generic;
using System.Data;
using System.Diagnostics;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using System.Web.Routing;
using EmployeeManagement.Mapper;
using EmployeeManagement.Models;
using EmployeeManagement.Repositories;
using EmployeeManagement.ViewModel;
using static EmployeeManagement.Filter;

namespace EmployeeManagement.Controllers
{ 
    [ErrorHandler]
    [Log]
    public class HomeController : Controller
    {
        [HttpGet]
        public ActionResult Index()
        { 
            return View();
        }

        /*
         public ActionResult About()
        { 
            ViewFormViewModel viewModel = new ViewFormViewModel();
            UserSettingsRepository repos = new UserSettingsRepository();
            //SESSION
            var employeeDetailsSession = (EmployeeDetails)Session["USER_SESSION"];
            ViewBag.FullNm = employeeDetailsSession.FullNm;

            //FROM STORE PROCESURE
            DataSet ds = repos.GetHomeEmployeeDetails(employeeDetailsSession.UserNm);

            if (ds.Tables.Count > 0)
            {
                if (ds.Tables[0].Rows.Count > 0)
                {
                    DataMapper<EmployeeDetails> mapper = new DataMapper<EmployeeDetails>();
                    viewModel.employeeDetails = mapper.Map(ds.Tables[0]).ToList();
                }
                else
                {
                }
            }
            return View(viewModel);
        }*/
        public ActionResult About()
        { 
            return View();
        }
        public ActionResult Contact()
        {
            ViewBag.Message = "Your contact page.";

            return View();
        }
        public ActionResult Product(ViewFormViewModel viewModel)
        { 
            if (viewModel.productModel == null)
            {
                viewModel.productModel = new List<ProductModel>();
            }
            if (viewModel.ProductItem == null)
            {
                viewModel.ProductItem = new List<ProductItem>();
            }

            return View(viewModel);
             
        }
        public ActionResult Cart(ViewFormViewModel viewModel)
        {
            if (viewModel.productModel == null)
            {
                viewModel.productModel = new List<ProductModel>();
            }
            return View();
        }
        public ActionResult Buy(string id)
        {
            ViewFormViewModel productModel = new ViewFormViewModel();
            if (Session["cart"] == null)
            {
                List<ProductItem> cart = new List<ProductItem>();
                cart.Add(new ProductItem { Product = productModel.find(id), Quantity = 1 });
                Session["cart"] = cart;
            }
            else
            {
                List<ProductItem> cart = (List<ProductItem>)Session["cart"];
                int index = isExist(id);
                if (index != -1)
                {
                    cart[index].Quantity++;
                }
                else
                {
                    cart.Add(new ProductItem { Product = productModel.find(id), Quantity = 1 });
                }
                Session["cart"] = cart;
            }
            return RedirectToAction("Cart","Home",new { @id = id });
        }

        public ActionResult Remove(string id)
        {
            List<ProductItem> cart = (List<ProductItem>)Session["cart"];
            int index = isExist(id);
            cart.RemoveAt(index);
            Session["cart"] = cart;
            return RedirectToAction("Index");
        }

        private int isExist(string id)
        {
            List<ProductItem> cart = (List<ProductItem>)Session["cart"];
            for (int i = 0; i < cart.Count; i++)
                if (cart[i].Product.ProductNm.Equals(id))
                    return i;
            return -1;
        }
    }
}