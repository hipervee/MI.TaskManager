using System.Linq;
using MI.TaskManager.Entities.Models;
using Repository.Pattern.Ef6;

namespace MI.TaskManager.Repository.Queries
{
    public class CustomerSalesQuery : QueryObject<Project>
    {
        public CustomerSalesQuery WithPurchasesMoreThan(decimal amount)
        {
            //And(x => x.Orders
            //    .SelectMany(y => y.OrderDetails)
            //    .Sum(z => z.UnitPrice * z.Quantity) > amount);

            return null;
        }

        public CustomerSalesQuery WithQuantitiesMoreThan(decimal quantity)
        {
            //And(x => x.Orders
            //    .SelectMany(y => y.OrderDetails)
            //    .Sum(z => z.Quantity) > quantity);

            return null;
        }
    }
}