using System;
using System.Linq;
using System.Linq.Expressions;
using MI.TaskManager.Entities.Models;
using Repository.Pattern.Ef6;

namespace MI.TaskManager.Repository.Queries
{
    public class OrderSalesQuery : QueryObject<Task>
    {
        public decimal Amount { get; set; }
        public string Country { get; set; }
        public DateTime FromDate { get; set; }
        public DateTime ToDate { get; set; }

        public override Expression<Func<Task, bool>> Query()
        {
            //return (x =>
            //    x.OrderDetails.Sum(y => y.UnitPrice) > Amount &&
            //    x.OrderDate >= FromDate &&
            //    x.OrderDate <= ToDate &&
            //    x.ShipCountry == Country);
            return null;
        }
    }
}