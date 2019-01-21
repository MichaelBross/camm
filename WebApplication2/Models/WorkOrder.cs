using System;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using WebApplication2.Code;

namespace Application.Models
{
    /// <summary>
    /// Represents a WorkOrder.
    /// NOTE: This class is generated from a T4 template - you should not modify it manually.
    /// </summary>
    public class WorkOrder 
    {	
		[Key]
        [DisplayName("WO Number")]        
        public string WoNumber { get; set; }        
        public string Customer { get; set; }
        public string CustomerPO { get; set; }
        public string SalesOrder { get; set; }
        public DateTime? DueDate { get; set; }
        public string AssemblyNumber { get; set; }
        public int? QuantityToBuild { get; set; }
        [HideInListView]
        public DateTime? TimeStamp { get; set; }
        public string WoStatus { get; set; }
        [DisplayName("SO Item#")]
        public string SalesOrderLineItemNo { get; set; }
    }

    public class WorkOrderSearch
    {
        public string Search { get; set; }
    }
}      
