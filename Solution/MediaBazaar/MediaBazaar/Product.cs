using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MediaBazaar
{
    class Product
    {
        private int pNumber;
        private string brand;
        private string type;
        private string model;
        private string description;
        private string category;
        private string subcategory;
        private int costPrice;
        private int salePrice;
        private int amountInStore;
        private int amountInWarehouse;

        public Product(int pNumber, string brand, string type, string model, string description,
            string category, string subcategory, int costPrice, int salePrice, int amountInStore,
            int amountInWarehouse)
        {
            this.pNumber = pNumber;
            this.brand = brand;
            this.type = type;
            this.model = model;
            this.description = description;
            this.category = category;
            this.subcategory = subcategory;
            this.costPrice = costPrice;
            this.salePrice = salePrice;
            this.amountInStore = amountInStore;
            this.amountInWarehouse = amountInWarehouse;
        }
    }
}
