namespace CSharpCohortFinalProject.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class Addstudentemailandphone : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.Students", "Email", c => c.String());
            AddColumn("dbo.Students", "Cellphone", c => c.String());
        }
        
        public override void Down()
        {
            DropColumn("dbo.Students", "Cellphone");
            DropColumn("dbo.Students", "Email");
        }
    }
}
