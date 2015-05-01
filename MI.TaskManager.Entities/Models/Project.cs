using Repository.Pattern.Ef6;
using System;
using System.Collections.Generic;

namespace MI.TaskManager.Entities.Models
{
    public partial class Project : Entity
    {
        public string ProjectCode { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }
        public Nullable<DateTime> StartDate { get; set; }
        public Nullable<DateTime> EndDate { get; set; }
    }
}
