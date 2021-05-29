﻿using System;
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
        private DBMediatorSoldProduct dbMediator;

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
            dbMediator = new DBMediatorSoldProduct();
        }

        //Methods
        public void AddProduct(SoldProduct product)
        {
            foreach (SoldProduct soldProduct in basket)
            {
                if (soldProduct.Product.Barcode==product.Product.Barcode)
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
        public void RemovePiece(string barcode)
        {
            foreach (SoldProduct p in basket)
            {
                if (p.Product.Barcode == barcode)
                {
                    p.DecreaseQuanity();
                    if (p.Quantity == 0)
                    {
                        basket.Remove(p);
                    }
                    return;
                }
            }
        }
        public void RemoveProduct(string barcode)
        {
            foreach (SoldProduct p in basket)
            {
                if (p.Product.Barcode == barcode)
                {
                    basket.Remove(p);
                    return;
                }
            }
        }

        public void ClearBascet()
        {
            this.basket.Clear();
        }
        public string GetProductBarcode(string strProduct)
        {
            foreach (SoldProduct product in basket)
            {
                if (product.ToString() == strProduct)
                {
                    return product.Product.Barcode;
                }
            }
            return null;
        }
        public bool ExecuteOrder(int empID,PaymentType type)
        {
            if (basket.Count==0)
            {
                return false;
            }
            decimal test = GetTotalPrice();
            bool status= dbMediator.ExecuteOrder(empID,Basket,type, test);
            this.basket.Clear();
            return status;
        }
    }
}