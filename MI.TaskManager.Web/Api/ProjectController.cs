using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Http.OData;
using System.Data.Entity.Infrastructure;
using Repository.Pattern.Infrastructure;
using Repository.Pattern.UnitOfWork;
using MI.TaskManager.Entities.Models;
using MI.TaskManager.Service;
using System.Web.Http;

namespace MI.TaskManager.Web.Api
{
    public class ProjectController  : ODataController
    {
        private readonly IProjectService _projectService;
        private readonly IUnitOfWorkAsync _unitOfWorkAsync;
        public ProjectController(IUnitOfWorkAsync unitOfWordAsync, IProjectService projectService)
        {
            _projectService = projectService;
            _unitOfWorkAsync = unitOfWordAsync;
        }

        [HttpGet]
        [Queryable]      
        public IQueryable<Project> GetProject()
        {
            return _unitOfWorkAsync.Repository<Project>().Queryable();
        }
    }
}