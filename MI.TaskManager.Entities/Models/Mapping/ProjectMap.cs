using System.ComponentModel.DataAnnotations;
using System.Data.Entity.ModelConfiguration;

namespace MI.TaskManager.Entities.Models.Mapping
{
    public class ProjectMap : EntityTypeConfiguration<Project>
    {
        public ProjectMap()
        {
            // Properties
            this.Property(t => t.Name)
                .IsRequired()
                .HasMaxLength(250);
            this.Property(t => t.ProjectCode)
                .IsRequired()
                .HasMaxLength(10);
            this.Property(t => t.Description)
                .HasMaxLength(500);

            //Table & Column Mappings
            this.ToTable("Projects");
        }
    }
}
