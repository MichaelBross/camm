using System.Data.Entity;

namespace Application.Models
{
    public class MFG_TablesContext : DbContext
    {
        public DbSet<WorkOrder> WorkOrders { get; set; }
        
    }

}
