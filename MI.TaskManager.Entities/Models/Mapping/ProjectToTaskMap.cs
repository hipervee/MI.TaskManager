using System.ComponentModel.DataAnnotations;
using System.Data.Entity.ModelConfiguration;

namespace MI.TaskManager.Entities.Models.Mapping
{
    public class ProjectToTaskMap : EntityTypeConfiguration<ProjectToTask>
    {
        public ProjectToTaskMap()
        {
            this.Property(t => t.TaskId)
                .IsRequired();
            this.Property(t => t.ProjectId)
                .IsRequired();

            this.ToTable("ProjectToTaskMap");
        }
    }
}
