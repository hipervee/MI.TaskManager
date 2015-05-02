using MI.TaskManager.Entities.Models;
using Repository.Pattern.Repositories;
using MI.TaskManager.Repository.Repositories;
using Service.Pattern;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


//using System.Collections.Generic;
//using Northwind.Entities.Models;
//using Northwind.Repository.Models;
//using Northwind.Repository.Repositories;
//using Repository.Pattern.Repositories;
//using Service.Pattern;

namespace MI.TaskManager.Service
{
    public interface IProjectService : IService<Project>
    {
        IEnumerable<Project> GetAll();
    }

    public class ProjectService : Service<Project>, IProjectService
    {
        private readonly IRepositoryAsync<Project> _repository;
        public ProjectService(IRepositoryAsync<Project> repository)
            : base(repository)
        {
            _repository = repository;
        }

        public IEnumerable<Project> GetAll()
        {
            return _repository.GetAll();
        }
    }
}
