using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace EmployeeManagement.Models
{
    public class ProductModel
    {
        [Key]
        public string ProductId { get; set; }
        public string ProductNm { get; set; }
        public string ProductDescription { get; set; }
        public string ProductQty { get; set; }
        public string ProductPrice { get; set; }
        public string ProductImage{ get; set; }
    }
}