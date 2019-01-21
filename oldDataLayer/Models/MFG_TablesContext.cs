using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;

namespace DataLayer.Models
{
    public class MFG_TablesContext :DbContext
    {
        public DbSet<AllWorkOrders> AllWorkOrders { get; set; }
    }
}