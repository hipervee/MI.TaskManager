using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;
using MI.TaskManager.Service;
using Repository.Pattern.Infrastructure;
using Repository.Pattern.UnitOfWork;
using MI.TaskManager.Entities.Models;

namespace MI.TaskManager.Web.Controllers
{
    public class ValuesController : ApiController
    {
         private readonly IProjectService _projectService;
         private readonly IUnitOfWorkAsync _unitOfWorkAsync;

         public ValuesController(IUnitOfWorkAsync unitOfWorkAsync, IProjectService projectService)
        {
            _unitOfWorkAsync = unitOfWorkAsync;
            _projectService = projectService;
        }
        // GET api/values
        public IEnumerable<Project> Get()
        {
            var list = _projectService.GetAll();
            return list;
        }

        // GET api/values/5
        public string Get(int id)
        {
            return "value";
        }

        // POST api/values
        public void Post([FromBody]string value)
        {
        }

        // PUT api/values/5
        public void Put(int id, [FromBody]string value)
        {
        }

        // DELETE api/values/5
        public void Delete(int id)
        {
        }
    }
}