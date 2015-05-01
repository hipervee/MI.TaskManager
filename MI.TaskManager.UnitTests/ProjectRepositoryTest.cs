using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using MI.TaskManager.Entities;
using Repository.Pattern.DataContext;
using Repository.Pattern.Ef6;
using Repository.Pattern.Infrastructure;
using Repository.Pattern.UnitOfWork;
using MI.TaskManager.Test.UnitTests;
using MI.TaskManager.Entities.Models;

namespace MI.TaskManager.UnitTests
{
    [TestClass]
    public class ProjectRepositoryTest
    {
        [TestMethod]
        public void Create_Project_Entity_Test()
        {
            using (IDataContextAsync fakeContext = new TaskManagerFakeContext())
            using (IUnitOfWork unitOfWork = new UnitOfWork(fakeContext))
            {
                unitOfWork.Repository<Project>().Insert(
                    new Project
                    {
                        Name = "Test Project",
                        Description = "TestDesc"
                    });
                unitOfWork.SaveChanges();

                var product = unitOfWork.Repository<Project>().Find(2);

                Assert.IsNotNull(product);
            }
        }
    }
}
