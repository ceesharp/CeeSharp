namespace CeeSharp.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class Achievement : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.AspNetUsers", "Achievement", c => c.String());
            AddColumn("dbo.AspNetUsers", "Profile_Picture", c => c.String());
        }
        
        public override void Down()
        {
            DropColumn("dbo.AspNetUsers", "Profile_Picture");
            DropColumn("dbo.AspNetUsers", "Achievement");
        }
    }
}
