using EmployeeManagement.Models;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;

namespace EmployeeManagement.ViewModel
{
    public class ViewFormViewModel
    {  
        public List<EmployeeDetails> employeeDetails { get; set; }
        public List<ProductModel> productModel { get; set; }
        public DbSet<ProductModel> dbproductModel { get; set; } //remove this one
        public List<ProductItem> ProductItem { get; set; }

        public ViewFormViewModel()
        {
            this.productModel = new List<ProductModel>() {
                new ProductModel {
                    ProductId = "0000001",
                    ProductNm = "20KV Dry Type",
                    ProductDescription = "Transformer",
                    ProductQty = "1",
                    ProductPrice = "5000",
                    ProductImage = "20KV dry type transformer and 20 (10) KV high voltage dual voltage dry type transformer.jpg"
                },
                new ProductModel {
                    ProductId = "0000002",
                    ProductNm = "S11 Series",
                    ProductDescription = "Transformer",
                    ProductQty = "1",
                    ProductPrice = "5000",
                    ProductImage = "S11, S13 series fully sealed oil-immersed distribution transformers.jpg"
                },
                new ProductModel {
                    ProductId = "0000003",
                    ProductNm = "S12 Series",
                    ProductDescription = "Transformer",
                    ProductQty = "1",
                    ProductPrice = "5000",
                    ProductImage = "S11, S13 series fully sealed oil-immersed distribution transformers.jpg"
                },
                new ProductModel { 
                    ProductId = "0000004",
                    ProductNm = "Epoxy Dry-Type",
                    ProductDescription = "Transformer",
                    ProductQty = "1",
                    ProductPrice = "5000",
                    ProductImage = "SC (B) 10, 11, 12, 13 series epoxy dry-type transformer.jpg"
                },
                new ProductModel {
                    ProductId = "0000005",
                    ProductNm = "S13 Series",
                    ProductDescription = "Transformer",
                    ProductQty = "1",
                    ProductPrice = "5000",
                    ProductImage = "S11, S13 series fully sealed oil-immersed distribution transformers.jpg"
                },
                new ProductModel {
                    ProductId = "0000006",
                    ProductNm = "Three-Phase",
                    ProductDescription = "Substation",
                    ProductQty = "1",
                    ProductPrice = "1000",
                    ProductImage = "Three-Phase -Substation.jpg"
                },
                new ProductModel {
                    ProductId = "0000007",
                    ProductNm = "Electrical-Unit",
                    ProductDescription = "Substation",
                    ProductQty = "1",
                    ProductPrice = "1000",
                    ProductImage = "Electrical-Unit-Substations.jpg"
                },
                new ProductModel {
                    ProductId = "0000008",
                    ProductNm = "YBW Prefabricated",
                    ProductDescription = "Substation",
                    ProductQty = "1",
                    ProductPrice = "1000",
                    ProductImage = "YBW prefabricated substation (European packaged substation).jpg"
                },
                new ProductModel {
                    ProductId = "0000009",
                    ProductNm = "Package-Unit",
                    ProductDescription = "Substation",
                    ProductQty = "1",
                    ProductPrice = "1000",
                    ProductImage = "Three-Phase -Substation.jpg"
                },
            };
             
        }

        public UserAuthentication userAuthentication { get; set; }
        
        public List<ProductModel> findAll()
        {
            return this.productModel;
        }

        public ProductModel find(string id)
        {
            return this.productModel.Single(p => p.ProductId.Equals(id));
        }

         
    }
}