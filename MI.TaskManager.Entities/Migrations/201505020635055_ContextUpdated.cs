namespace MI.TaskManager.Entities.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class ContextUpdated : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.ProjectToTaskMap",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        ProjectId = c.Int(nullable: false),
                        TaskId = c.Int(nullable: false),
                        CreatedBy = c.Int(nullable: false),
                        UpdatedBy = c.Int(),
                        InActivatedBy = c.Int(),
                        CreatedDate = c.DateTime(nullable: false),
                        UpdatedDate = c.DateTime(),
                        InActivatedDate = c.DateTime(),
                        IsInActive = c.Boolean(),
                    })
                .PrimaryKey(t => t.Id);
            
            CreateTable(
                "dbo.TaskTypeMap",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        TaskTypeName = c.String(nullable: false, maxLength: 50),
                        CreatedBy = c.Int(nullable: false),
                        UpdatedBy = c.Int(),
                        InActivatedBy = c.Int(),
                        CreatedDate = c.DateTime(nullable: false),
                        UpdatedDate = c.DateTime(),
                        InActivatedDate = c.DateTime(),
                        IsInActive = c.Boolean(),
                    })
                .PrimaryKey(t => t.Id);
            
        }
        
        public override void Down()
        {
            DropTable("dbo.TaskTypeMap");
            DropTable("dbo.ProjectToTaskMap");
        }
    }
}
