namespace initiative.sso.db.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class AddDescOnCompany : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.tblCompany", "Desc", c => c.String());
        }
        
        public override void Down()
        {
            DropColumn("dbo.tblCompany", "Desc");
        }
    }
}
