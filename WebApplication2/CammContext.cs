using System.Data.Entity;

namespace Application.Models
{
    public class CammContext : DbContext
    {
        public DbSet<WorkOrder> WorkOrders { get; set; }
        
    }

}
