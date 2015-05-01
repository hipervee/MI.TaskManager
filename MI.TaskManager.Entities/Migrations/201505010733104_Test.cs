namespace MI.TaskManager.Entities.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class Test : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.Projects",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        ProjectCode = c.String(nullable: false, maxLength: 10),
                        Name = c.String(nullable: false, maxLength: 250),
                        Description = c.String(maxLength: 500),
                        StartDate = c.DateTime(),
                        EndDate = c.DateTime(),
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
                "dbo.Tasks",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        TaskCode = c.String(),
                        ProjectId = c.Int(nullable: false),
                        Name = c.String(nullable: false, maxLength: 250),
                        Description = c.String(maxLength: 250),
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
            DropTable("dbo.Tasks");
            DropTable("dbo.Projects");
        }
    }
}
