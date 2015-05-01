using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using MI.TaskManager.Entities.Models;
using MI.TaskManager.Repository.Models;
using Repository.Pattern.Repositories;

namespace MI.TaskManager.Repository.Repositories
{

    // Exmaple: How to add custom methods to a repository.

    public static class ProjectRepository
    {
        public static int GetProjectsCount(this IRepository<Project> repository)
        {
            return repository
                .Queryable()
                .Count();

        }

        public static IEnumerable<Project> GetAll(this IRepository<Project> repository)
        {
            return repository
                .Queryable()
                .ToList();
        }
    }
    public static class CustomerRepository
    {
        public static decimal GetCustomerOrderTotalByYear(this IRepository<Project> repository, string customerId, int year)
        {
            //return repository
            //    .Queryable()
            //    .Where(c => c.CustomerID == customerId)
            //    .SelectMany(c => c.Orders.Where(o => o.OrderDate != null && o.OrderDate.Value.Year == year))
            //    .SelectMany(c => c.OrderDetails)
            //    .Select(c => c.Quantity*c.UnitPrice)
            //    .Sum();

            return 0;
        }

        public static IEnumerable<Project> CustomersByCompany(this IRepositoryAsync<Project> repository, string companyName)
        {
            //return repository
            //    .Queryable()
            //    .Where(x => x.CompanyName.Contains(companyName))
            //    .AsEnumerable();
            return null;
        }

        public static IEnumerable<CustomerOrder> GetCustomerOrder(this IRepository<Project> repository, string country)
        {
            //var customers = repository.GetRepository<Project>().Queryable();
            //var orders = repository.GetRepository<Customer>().Queryable();

            //var query = from c in customers
            //    join o in orders on new {a = c.CustomerID, b = c.Country}
            //        equals new {a = o.CustomerID, b = country}
            //    select new CustomerOrder
            //    {
            //        CustomerId = c.CustomerID,
            //        ContactName = c.ContactName,
            //        OrderId = o.OrderID,
            //        OrderDate = o.OrderDate
            //    };

            return null;// query.AsEnumerable();
        }
    }
}