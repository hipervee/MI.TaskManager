using Repository.Pattern.Ef6;
using System;
using System.Collections.Generic;

namespace MI.TaskManager.Entities.Models
{

    public partial class ProjectToTask : Entity
    {
        public int ProjectId { get; set; }
        public int TaskId { get; set; }
    }

}
