using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjectClasses
{
    public class ProductManager
    {
        DBMediatorProduct dbMediator;
        List<Product> products;


        public ProductManager()
        {
            this.dbMediator = new DBMediatorProduct();
            this.products = GetAllProducts();
        }

        public void UpdateProducts()
        {
            products = this.dbMediator.GetProducts();
        }

        public List<Product> GetAllProducts()
        {
            products = this.dbMediator.GetProducts();
            return products;
        }
        public string GetNameFromToString(string productToString)
        {
            foreach (Product product in products)
            {
                if (product.ToString() == productToString)
                {
                    return product.GetName;
                }
            }
            return "";
        }

        public Product GetProductFromName(string productNames)
        {
            foreach (Product product in products)
            {
                if (product.GetName == productNames)
                {
                    return product;
                }
            }
            return null;
        }

        public decimal GetPriceFromNames(string productNames)
        {
            foreach (Product product in products)
            {
                if (product.GetName == productNames)
                {
                    return product.SalePrice;
                }
            }
            return 0;
        }

        //public List<Product> GetProductsFromCategory(string category)
        //{
        //    if (category == "All")
        //    {
        //        return products;
        //    }
        //    List<Product> prod = new List<Product>();
        //    foreach (Product product in products)
        //    {
        //        if (product.Category == category)
        //        {
        //            prod.Add(product);
        //        }
        //    }
        //    return prod;
        //}

        //public List<Product> GetProductsFromSubCategory(string category, string subCategory)
        //{
        //    if (category == "All")
        //    {
        //        return products;
        //    }
        //    List<Product> prod = new List<Product>();
        //    foreach (Product product in products)
        //    {
        //        if (product.Category == category)
        //        {
        //            prod.Add(product);
        //        }
        //    }
        //    return prod;
        //}

        public bool AddProductToDB(Product newProd)
        {

            if (dbMediator.CheckIfExists(newProd.Model, newProd.Brand))
            {
                throw new ArgumentException();
            }

            return this.dbMediator.AddProduct(newProd);
        }

        public bool DeleteAProduct(int id)
        {
            return dbMediator.DeleteProduct(id);
        }
        public List<Product> GetProductsFromDepartmentDB(int dept_id)
        {
            //this.products = dbMediator.GetProductsFromDepartment(dept_id);
            return dbMediator.GetProductsFromDepartment(dept_id);
        }
        public List<Product> GetProductsFromDepartmentCategoryDB(int dept_id, string category)
        {
            //this.products = dbMediator.GetProductsFromDepartmentCategory( dept_id,  category);
            return dbMediator.GetProductsFromDepartmentCategory(dept_id, category);
        }
        public List<Product> GetProductsFromSubcategoryDB(int dept_id, string category, string subcategory)
        {
            //this.products = dbMediator.GetProductsFromSubcategory(dept_id,  category,  subcategory);
            return dbMediator.GetProductsFromSubcategory(dept_id, category, subcategory);
        }
        public Product GetProductByBarcode(string barcode)
        {
            foreach (Product product in products)
            {
                if (product.Barcode == barcode)
                {
                    return product;
                }
            }
            return null;
        }
    }
}
