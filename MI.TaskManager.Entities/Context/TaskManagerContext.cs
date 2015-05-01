using System.Data.Entity;
using System.Data.Entity.Infrastructure;
using MI.TaskManager.Entities.Models.Mapping;
using Repository.Pattern.Ef6;

namespace MI.TaskManager.Entities.Models
{
    public partial class TaskManagerContext : DataContext
    {
        static TaskManagerContext()
        {
            Database.SetInitializer<TaskManagerContext>(null);
        }

        public TaskManagerContext()
            : base("Name=TaskManagerContext")
        {
        }

        public DbSet<Project> Projects { get; set; }
        public DbSet<Task> Tasks { get; set; }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            modelBuilder.Configurations.Add(new ProjectMap());
            modelBuilder.Configurations.Add(new TaskMap());
        }
    }
}
