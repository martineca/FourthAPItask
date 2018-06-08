using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;
using NorthwindDataAccess;
using System.Data.Entity;

namespace NorhtwindAPI.Controllers
{
    public class CustomersController : ApiController
    {
        [Route("customers")]
        public IEnumerable<CustomersView> Get()
        {
            using (NorthwindEntities1 entities = new NorthwindEntities1())
            {
                return entities.CustomersViews.ToList();
            }


        }
        [Route("customer/{ID}")]
        [HttpGet]

        public CustomersView Get(String ID)
        {
            using (NorthwindEntities1 entities = new NorthwindEntities1())
            {
                return entities.CustomersViews.FirstOrDefault(e => e.CustomerID == ID);
            }
        }


        [Route("customer/{ID}/orders")]
        [HttpGet]
        public IEnumerable<CustomerOrder> orders(String ID)
        {
            using (NorthwindEntities1 entities = new NorthwindEntities1())
            {
                return entities.CustomerOrders.Where(e => e.CustomerID == ID).ToList();
            }
        }
    }
}
