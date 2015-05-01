using System.ComponentModel.DataAnnotations;
using System.Data.Entity.ModelConfiguration;

namespace MI.TaskManager.Entities.Models.Mapping
{
    public class TaskMap : EntityTypeConfiguration<Task>
    {
        public TaskMap()
        {         
            // Properties
            this.Property(t => t.Name)
                .IsRequired()
                .HasMaxLength(250);
            this.Property(t => t.Description)
                .HasMaxLength(250);

            // Table & Column Mappings
            this.ToTable("Tasks");
        }
    }
}
