#region

using MI.TaskManager.Entities.Models;
using MI.TaskManager.UnitTests.Fake;
using Repository.Pattern.Ef6;

#endregion

namespace MI.TaskManager.Test.UnitTests
{
    public class TaskManagerFakeContext : FakeDbContext
    {
        public TaskManagerFakeContext()
        {
            AddFakeDbSet<Project,  ProjectDbSet>();
            //AddFakeDbSet<Customer, CustomerDbSet>();
            //AddFakeDbSet<Employee, EmployeeDbSet>();
            //AddFakeDbSet<Order, OrderDbSet>();
            //AddFakeDbSet<OrderDetail, OrderDetailDbSet>();
            //AddFakeDbSet<Supplier, SupplierDbSet>();
            //AddFakeDbSet<Product, ProductDbSet>();
            //AddFakeDbSet<Region, RegionDbSet>();
            //AddFakeDbSet<Shipper, ShippperDbSet>();
            //AddFakeDbSet<Territory, TerritoryDbSet>();
        }
    }
}
