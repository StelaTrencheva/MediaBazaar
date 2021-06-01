using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjectClasses
{
     public class RestockRequestManager
    {
        DBMediatorRestockRequest dbMediator;
        Dictionary<Product, int> requestedProducts;
        Dictionary<Product, int> supplierRequests;

        public RestockRequestManager()
        {
            this.dbMediator = new DBMediatorRestockRequest();
            this.requestedProducts = GetAllRequestedProducts();
            this.supplierRequests = GetAllSupplierRequests();
        }

        public Dictionary<Product, int> GetAllRequestedProducts()
        {
            requestedProducts = dbMediator.GetListOfRequestedProducts();
            return requestedProducts;
        }
        public Dictionary<Product, int> GetAllSupplierRequests()
        {
            supplierRequests = dbMediator.GetAllSupplierRequests();
            return supplierRequests;
        }

        public void SendStockToStore(int pNum, int stock, int WarehouseStock)
        {
            dbMediator.SendStockToStore(pNum, stock, WarehouseStock);
        }
        public void UpdateRestockRequest(int pNum, int stockReq)
        {
            dbMediator.UpdateRequestedQuantity(pNum, stockReq);
        }

        public void SendSupplierRequest(int pNum, int stock)
        {
            dbMediator.SendSupplierRequest(pNum, stock);
        }

        public void DeleteRestockRequest(int pNum)
        {
            dbMediator.DeleteRestockRequest(pNum);
        }
    }
}
