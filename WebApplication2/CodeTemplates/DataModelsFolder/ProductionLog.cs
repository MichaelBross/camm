using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Application.Models
{
    /// <summary>
    /// Represents a ProductionLog.
    /// NOTE: This class is generated from a T4 template - you should not modify it manually.
    /// </summary>
    public class ProductionLog 
    {	
		[Key]
        public string WoNumber { get; set; }
        public string Customer { get; set; }
        public string CustomerPO { get; set; }
        public string SalesOrder { get; set; }
        public DateTime? DueDate { get; set; }
        public string AssemblyNumber { get; set; }
        public bool OnHold { get; set; }
        public int ToMake { get; set; }
        public int Parts { get; set; }
        public int ToWork { get; set; }
        public int InWork { get; set; }
        public int Complete { get; set; }
        public int ToShip { get; set; }
        public int Shipped { get; set; }
        public string Comments { get; set; }
        public bool Cancelled { get; set; }
        public DateTime? LastUpdate { get; set; }
        public string SalesOrderLineItemNo { get; set; }
    }
}      
