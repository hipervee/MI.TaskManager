namespace MI.TaskManager.Entities.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class TablesAdded : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.Tasks", "TaskTypeId", c => c.Int(nullable: false));
            AddColumn("dbo.Tasks", "EstimatedStartDate", c => c.DateTime());
            AddColumn("dbo.Tasks", "EstimatedEndDate", c => c.DateTime());
            AddColumn("dbo.Tasks", "StartDate", c => c.DateTime());
            AddColumn("dbo.Tasks", "EndDate", c => c.DateTime());
            DropColumn("dbo.Tasks", "ProjectId");
        }
        
        public override void Down()
        {
            AddColumn("dbo.Tasks", "ProjectId", c => c.Int(nullable: false));
            DropColumn("dbo.Tasks", "EndDate");
            DropColumn("dbo.Tasks", "StartDate");
            DropColumn("dbo.Tasks", "EstimatedEndDate");
            DropColumn("dbo.Tasks", "EstimatedStartDate");
            DropColumn("dbo.Tasks", "TaskTypeId");
        }
    }
}
