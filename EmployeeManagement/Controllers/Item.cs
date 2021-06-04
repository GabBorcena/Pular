using EmployeeManagement.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace EmployeeManagement.Controllers
{
    public class Item
    {
        private ProductModel cm = new ProductModel();

        public ProductModel ProductModel
        {
            get { return cm; }
            set { cm = value; }
        }
        private int quantity;

        public int Quantity
        {
            get { return quantity; }
            set { quantity = value; }
        }

        public Item()
        { }

        public Item(ProductModel cm, int quantity)
        {
            this.cm = cm;
            this.quantity = quantity;
        }


    }
}