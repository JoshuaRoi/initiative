namespace initiative.sso.db.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class InitailMigration : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.tblCompany",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        Name = c.String(),
                    })
                .PrimaryKey(t => t.Id);
            
            CreateTable(
                "dbo.tblRoles",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        Name = c.String(),
                    })
                .PrimaryKey(t => t.Id);
            
            CreateTable(
                "dbo.tblUserRoles",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        Roles_Id = c.Int(),
                        Users_Id = c.Int(),
                    })
                .PrimaryKey(t => t.Id)
                .ForeignKey("dbo.tblRoles", t => t.Roles_Id)
                .ForeignKey("dbo.tblUsers", t => t.Users_Id)
                .Index(t => t.Roles_Id)
                .Index(t => t.Users_Id);
            
            CreateTable(
                "dbo.tblUsers",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        FirstName = c.String(),
                        LastName = c.String(),
                        UserName = c.String(),
                        UserEmail = c.String(),
                    })
                .PrimaryKey(t => t.Id);
            
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.tblUserRoles", "Users_Id", "dbo.tblUsers");
            DropForeignKey("dbo.tblUserRoles", "Roles_Id", "dbo.tblRoles");
            DropIndex("dbo.tblUserRoles", new[] { "Users_Id" });
            DropIndex("dbo.tblUserRoles", new[] { "Roles_Id" });
            DropTable("dbo.tblUsers");
            DropTable("dbo.tblUserRoles");
            DropTable("dbo.tblRoles");
            DropTable("dbo.tblCompany");
        }
    }
}
