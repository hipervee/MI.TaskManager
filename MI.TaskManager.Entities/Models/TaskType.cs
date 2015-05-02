using Repository.Pattern.Ef6;
using System;
using System.Collections.Generic;

namespace MI.TaskManager.Entities.Models
{
    public class TaskType : Entity
    {
        public string TaskTypeName { get; set; }
    }
}
