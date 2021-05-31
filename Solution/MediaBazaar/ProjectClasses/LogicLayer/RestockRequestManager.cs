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
        Dictionary<int, Product> requestedProducts;

        public RestockRequestManager()
        {
            this.dbMediator = new DBMediatorRestockRequest();
            this.requestedProducts = GetAllRequestedProducts();
        }

        public Dictionary<int, Product> GetAllRequestedProducts()
        {
            requestedProducts = dbMediator.GetListOfRequestedProducts();
            return requestedProducts;
        }
    }
}
