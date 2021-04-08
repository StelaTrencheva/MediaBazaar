using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MediaBazaar
{
    public class Product
    {
        private int pNumber;
        private string brand;
        private string type;
        private string model;
        private string description;
        private string category;
        private string subcategory;
        private decimal costPrice;
        private decimal salePrice;
        private int amountInStore;
        private int amountInWarehouse;

        public int PNumber { get { return this.pNumber; } }

        public string Brand { get { return this.brand; } }

        public string Type { get { return this.type; } }

        public string Model { get { return this.model; } }

        public string Description { get { return this.description; } }

        public string Category { get { return this.category; } }

        public string Subcategory { get { return this.subcategory; } }

        public decimal SalePrice { get { return this.salePrice; } }

        public decimal CostPrice { get { return this.costPrice; } }

        public decimal AmountInStore { get { return this.amountInStore; } }

        public decimal AmountInWarehouse { get { return this.amountInWarehouse; } }

        public Product(int pNumber, string brand, string type, string model, string description,
            string category, string subcategory, decimal costPrice, decimal salePrice, int amountInStore,
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
        public string GetStatistic(int quantity)
        {
            return $"Product number: {PNumber} - {Brand} {Model} - Total revenue: " +
                    $"{SalePrice * quantity} Total profit: {(SalePrice * quantity) - (CostPrice * quantity)} " +
                    $"- for {quantity} Quantity";
        }
        public override string ToString()
        {
            return $" Product number: {this.pNumber} .\t {this.brand} {this.model}.";
        }
    }
}
