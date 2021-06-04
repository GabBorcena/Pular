using EmployeeManagement.Models;
using EmployeeManagement.ViewModel;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace EmployeeManagement.Controllers
{
    public class ShoppingCartController : Controller
    {

        private ViewFormViewModel de = new ViewFormViewModel();
        // GET: ShoppingCart
        public ActionResult Index()
        {
            return View();
        }
        /*public ActionResult Delete(int id)
        {
            int index = isExisting(id);
            List<Item> cart = (List<Item>)Session["cart"];
            cart.RemoveAt(index);
            Session["cart"] = cart;
            return View("Cart");
        }
        private int isExisting(int id)
        {
            List<Item> cart = (List<Item>)Session["cart"];
            for (int i = 0; i < cart.Count; i++)
                if (cart[i].ProductModel.ProductId == id)
                    return i;
            return -1;
        }
        public ActionResult OrderNow(int id)
        {
            if (Session["cart"] == null)
            {
                List<Item> cart = new List<Item>(); 
                    cart.Add(new Item(de.dbproductModel.Find(id), 1));
                    Session["cart"] = cart; 
            }
            else
            {
                List<Item> cart = (List<Item>)Session["cart"];
                int index = isExisting(id);
                if (index == -1)
                    cart.Add(new Item(de.dbproductModel.Find(id), 1));
                else
                    //cart[index].Quantity++;
                    Session["cart"] = cart;
            }
            return View("Cart");
        }
        public ActionResult AddQty(int id)
        {

            if (Session["cart"] == null)
            {
                List<Item> cart = new List<Item>();
                cart.Add(new Item(de.dbproductModel.Find(id), 1));
                Session["cart"] = cart;
            }
            else
            {
                List<Item> cart = (List<Item>)Session["cart"];
                int index = isExisting(id);

                cart[index].Quantity++;
                Session["cart"] = cart;
            }
            return View("Cart");
        }
        public ActionResult ReduceQty(int id)
        {

            if (Session["cart"] == null)
            {
                List<Item> cart = new List<Item>();
                cart.Add(new Item(de.dbproductModel.Find(id), 1));
                Session["cart"] = cart;
            }
            else
            {
                List<Item> cart = (List<Item>)Session["cart"];
                int index = isExisting(id);
                if (cart[index].Quantity > 0)
                {
                    cart[index].Quantity--;
                    Session["cart"] = cart;
                }

            }
            return View("Cart");
        }*/


    }
}