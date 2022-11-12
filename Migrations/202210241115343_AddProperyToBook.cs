namespace Experiment.EntityFramework.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class AddProperyToBook : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.Books", "AddedProperty", c => c.String());
        }
        
        public override void Down()
        {
            DropColumn("dbo.Books", "AddedProperty");
        }
    }
}
