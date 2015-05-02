using System.ComponentModel.DataAnnotations;
using System.Data.Entity.ModelConfiguration;

namespace MI.TaskManager.Entities.Models.Mapping
{
    public class TaskTypeMap : EntityTypeConfiguration<TaskType>
    {
        // Properties
        public TaskTypeMap()
        {
            this.Property(t => t.TaskTypeName)
                .HasMaxLength(50)
                .IsRequired();

            this.ToTable("TaskTypeMap");
        }
    }
}
