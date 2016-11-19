namespace OracleDb.Context.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class AddedCourseAndUser : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "DEVUSER.Course",
                c => new
                    {
                        Id = c.Decimal(nullable: false, precision: 10, scale: 0, identity: true),
                        CourseName = c.String(maxLength: 300),
                        UserId = c.Decimal(precision: 10, scale: 0),
                    })
                .PrimaryKey(t => t.Id)
                .ForeignKey("DEVUSER.DevUser", t => t.UserId)
                .Index(t => t.UserId);
            
            CreateTable(
                "DEVUSER.DevUser",
                c => new
                    {
                        Id = c.Decimal(nullable: false, precision: 10, scale: 0, identity: true),
                        FirstName = c.String(maxLength: 300),
                        LastName = c.String(maxLength: 300),
                    })
                .PrimaryKey(t => t.Id);
            
        }
        
        public override void Down()
        {
            DropForeignKey("DEVUSER.Course", "UserId", "DEVUSER.DevUser");
            DropIndex("DEVUSER.Course", new[] { "UserId" });
            DropTable("DEVUSER.DevUser");
            DropTable("DEVUSER.Course");
        }
    }
}
