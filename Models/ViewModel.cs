using System.Collections.Generic;
using SalesOrder.Models;

namespace SalesOrder.ViewModels
{
    public class SalesOrderViewModel
    {
        public List<ProductEntity> Product { get; set; }
        public List<CustomerEntity> Customer { get; set; }

        


    }
}
