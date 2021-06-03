using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjectClasses
{
     public class RestockRequestManager
    {
        DBMediatorRestockRequest dbMediatorRestockRequest;
        DBMediatorProduct dbMediatorProduct;
        Dictionary<Product, int> requestedProducts;
        Dictionary<Product, int> supplierRequests;
        List<Product> products;

        public RestockRequestManager()
        {
            this.dbMediatorRestockRequest = new DBMediatorRestockRequest();
            this.dbMediatorProduct = new DBMediatorProduct();
            this.requestedProducts = GetAllRequestedProducts();
            this.supplierRequests = GetAllSupplierRequests();
        }

        public void CreateCreateStockRequest(int pNum, int pQuantity)
        {
            this.dbMediatorRestockRequest.CreateRestockRequest(pNum, pQuantity);
        }

        public Dictionary<Product, int> GetAllRequestedProducts()
        {
            requestedProducts = dbMediatorRestockRequest.GetListOfRequestedProducts();
            return requestedProducts;
        }
        public Dictionary<Product, int> GetAllSupplierRequests()
        {
            supplierRequests = dbMediatorRestockRequest.GetAllSupplierRequests();
            return supplierRequests;
        }

        public void SendStockToStore(int pNum, int stock, int WarehouseStock)
        {
            dbMediatorRestockRequest.SendStockToStore(pNum, stock, WarehouseStock);
        }
        public void UpdateRestockRequest(int pNum, int stockReq)
        {
            dbMediatorRestockRequest.UpdateRequestedQuantity(pNum, stockReq);
        }

        public void SendSupplierRequest(int pNum, int stock)
        {
            dbMediatorRestockRequest.SendSupplierRequest(pNum, stock);
        }

        public void DeleteRestockRequest(int pNum)
        {
            dbMediatorRestockRequest.DeleteRestockRequest(pNum);
        }

        public List<Product> GetListOfAllProducts()
        {
            products = dbMediatorProduct.GetProducts();
            return products;
        }
    }
}
