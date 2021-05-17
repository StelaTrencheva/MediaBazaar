using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjectClasses
{
    public class BasketManager
    {
        //Istance variables
        private List<SoldProduct> basket;

        //Properties
        public List<SoldProduct> Basket
        {
            get { return basket; }
            set { basket = value; }
        }

        //Constructor
        public BasketManager()
        {
            this.basket = new List<SoldProduct>();
        }

        //Methods
        public void AddProduct(SoldProduct product)
        {
            foreach (SoldProduct soldProduct in basket)
            {
                if (soldProduct.Product==product.Product)
                {
                    soldProduct.IncreseQuanity(product.Quantity);
                    return;
                }
            }
            basket.Add(product);
        }
        public decimal GetTotalPrice()
        {
            decimal price = 0;
            foreach (SoldProduct product in basket)
            {
                price += product.Price;
            }
            return price;
        }
    }
}
