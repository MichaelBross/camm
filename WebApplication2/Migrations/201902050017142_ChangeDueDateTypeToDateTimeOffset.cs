namespace WebApplication2.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class ChangeDueDateTypeToDateTimeOffset : DbMigration
    {
        public override void Up()
        {
            AlterColumn("dbo.WorkOrders", "DueDate", c => c.DateTimeOffset(precision: 7));
        }
        
        public override void Down()
        {
            AlterColumn("dbo.WorkOrders", "DueDate", c => c.DateTime());
        }
    }
}
