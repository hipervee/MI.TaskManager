using Repository.Pattern.Ef6;
using System;
using System.Collections.Generic;

namespace MI.TaskManager.Entities.Models
{
    public partial class Task : Entity
    {
        public string TaskCode { get; set; }
        public int ProjectId { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }
    }
}
