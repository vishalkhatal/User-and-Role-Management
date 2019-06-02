namespace TestIdentity.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class InitialCreate1 : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.Organizations",
                c => new
                    {
                        OrganizationId = c.Int(nullable: false, identity: true),
                        Name = c.String(nullable: false),
                        User_Id = c.String(maxLength: 128),
                    })
                .PrimaryKey(t => t.OrganizationId)
                .ForeignKey("dbo.AspNetUsers", t => t.User_Id)
                .Index(t => t.User_Id);
            
            AlterColumn("dbo.AspNetUsers", "UserName", c => c.String(nullable: false));
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.Organizations", "User_Id", "dbo.AspNetUsers");
            DropIndex("dbo.Organizations", new[] { "User_Id" });
            AlterColumn("dbo.AspNetUsers", "UserName", c => c.String());
            DropTable("dbo.Organizations");
        }
    }
}
