﻿using System;
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
        public List<string> GetCategories()
        {
            List<string> categories = new List<string>();
            foreach (Product product in products)
            {
                if (!(categories.Contains(product.Category)))
                {
                    categories.Add(product.Category);
                }
            }
            return categories;
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
        public List<Product> GetProductsFromCategory(string category)
        {
            if (category == "All")
            {
                return products;
            }
            List<Product> prod = new List<Product>();
            foreach (Product product in products)
            {
                if (product.Category == category)
                {
                    prod.Add(product);
                }
            }
            return prod;
        }
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
    }
}
