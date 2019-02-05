using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using WebApplication2.Code;

namespace Application.ViewModels
{
    public class WorkOrderVM
    {
        public WorkOrderSearch WorkOrderSearch { get; set; }
        public WorkOrderList WorkOrderList { get; set; }
        public WorkOrderDetail WorkOrderDetail { get; set; }
    }

    public class WorkOrderSearch
    {
        public string SearchString { get; set; }
        public string WoNumber { get; set; }
        public string Customer { get; set; }
        public string CustomerPO { get; set; }
        public string SalesOrder { get; set; }
        public DateTime? DueDate { get; set; }
        public string AssemblyNumber { get; set; }
        public int? QuantityToBuild { get; set; }
        public string WoStatus { get; set; }
        [DisplayName("SO Item#")]
        public string SalesOrderLineItemNo { get; set; }
    }

    public class WorkOrderList
    {
        [DisplayName("WO Number")]
        public string WoNumber { get; set; }
        public string Customer { get; set; }
        public string CustomerPO { get; set; }
        public string SalesOrder { get; set; }
        public DateTime? DueDate { get; set; }
        public string AssemblyNumber { get; set; }
        public int? QuantityToBuild { get; set; }
        public string WoStatus { get; set; }
        [DisplayName("SO Item#")]
        public string SalesOrderLineItemNo { get; set; }
    }

    public class WorkOrderDetail
    {
        [DisplayName("WO Number")]
        [Required(ErrorMessage = "WO Number is required.")]        
        public string WoNumber { get; set; }
                
        [Required(ErrorMessage = "Customer is required.")]
        public string Customer { get; set; }
                
        [DisplayName("Customer PO")]
        public string CustomerPO { get; set; }

        [DisplayName("Sales Order #")]
        public string SalesOrder { get; set; }

        [DisplayName("Due Date")]
        public DateTimeOffset? DueDate { get; set; }

        [Required(ErrorMessage = "Assembly Number is required.")]
        [DisplayName("Assembly #")]
        public string AssemblyNumber { get; set; }

        [DisplayName("Qty to Build")]
        public int? QuantityToBuild { get; set; }

        [HideInListView]
        public DateTime? TimeStamp { get; set; }

        [DisplayName("WO Status")]
        public string WoStatus { get; set; }

        [DisplayName("SO Item#")]
        public string SalesOrderLineItemNo { get; set; }
    }

}      
