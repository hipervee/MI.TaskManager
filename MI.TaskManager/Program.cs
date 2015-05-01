using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using MI.TaskManager.Entities.Models;
using Repository.Pattern.DataContext;
using Repository.Pattern.Ef6;
using Repository.Pattern.Infrastructure;
using Repository.Pattern.UnitOfWork;

namespace MI.TaskManager
{
    class Program
    {
        static void Main(string[] args)
        {

            try
            {
                //This is a test

                //Doing a bug Fix

                //Big Fixed
                using (IDataContextAsync ctx = new TaskManagerContext())
                using (IUnitOfWork uow = new UnitOfWork(ctx))
                {
                    var count = uow.Repository<Project>().Queryable().Count();
                    var countTask = uow.Repository<Task>().Queryable().Count();
                    uow.Repository<Project>().Insert(new Project()
                    {
                        ProjectCode = "P001",
                        Description = "Test Description",
                        Name = "Test name",
                        CreatedBy = 1,
                        CreatedDate = DateTime.Now
                    });
                    uow.SaveChanges();

                    var tempProject = uow.Repository<Project>().Find(1);
                    Console.WriteLine("Done : " + count.ToString() + "-" + countTask.ToString() + "-" + tempProject.Description);
               }
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
            Console.Read();
        }
    }
}
