using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MediaBazaar
{
    public class ProductManager
    {
        DBMediatorProduct dbMediator;
        

        public ProductManager()
        {
            this.dbMediator = new DBMediatorProduct();
        }

        public List<Product> GetAllProducts()
        {
            return this.dbMediator.GetProducts();
        }

        public bool AddProductToDB(string brand, string type, string model, string description, string category,
            string subcategory, decimal costPrice, decimal salePrice, int amountInStore, int amountInWarehouse)
        {
            Product product = new Product(0,brand, type, model, description, category, subcategory, costPrice, salePrice,
                amountInStore, amountInWarehouse);
            foreach (Product i in GetAllProducts())
            {
                if (i.Model.ToLower() == model.ToLower() && i.Brand.ToLower() == brand.ToLower())
                {
                    throw new RepeatingObjectException();
                }
            }
            return this.dbMediator.AddProduct(brand, type, model, description, category, subcategory, costPrice, salePrice,
                amountInStore, amountInWarehouse);
        }
        public bool DeleteAProduct(int id)
        {
            return dbMediator.DeleteProduct(id);
        }
    }
}
