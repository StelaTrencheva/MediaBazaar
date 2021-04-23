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
        

        public ProductManager()
        {
            this.dbMediator = new DBMediatorProduct();
        }

        public List<Product> GetAllProducts()
        {
            return this.dbMediator.GetProducts();
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
