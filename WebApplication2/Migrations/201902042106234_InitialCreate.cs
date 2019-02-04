namespace WebApplication2.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class InitialCreate : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.WorkOrders",
                c => new
                    {
                        WoNumber = c.String(nullable: false, maxLength: 128),
                        Customer = c.String(),
                        CustomerPO = c.String(),
                        SalesOrder = c.String(),
                        DueDate = c.DateTime(),
                        AssemblyNumber = c.String(),
                        QuantityToBuild = c.Int(),
                        TimeStamp = c.DateTime(),
                        WoStatus = c.String(),
                        SalesOrderLineItemNo = c.String(),
                    })
                .PrimaryKey(t => t.WoNumber);
            
        }
        
        public override void Down()
        {
            DropTable("dbo.WorkOrders");
        }
    }
}
