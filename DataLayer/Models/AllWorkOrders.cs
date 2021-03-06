using System;
namespace DataLayer.Models
{
    /// <summary>
    /// Represents a AllWorkOrders.
    /// NOTE: This class is generated from a T4 template - you should not modify it manually.
    /// </summary>
    public class AllWorkOrders 
    {
        public string WoNumber { get; set; }
        public string Customer { get; set; }
        public string CustomerPO { get; set; }
        public string SalesOrder { get; set; }
        public DateTime? DueDate { get; set; }
        public string AssemblyNumber { get; set; }
        public int? QuantityToBuild { get; set; }
        public DateTime? TimeStamp { get; set; }
        public string WoStatus { get; set; }
        public string SalesOrderLineItemNo { get; set; }
    }
}      
