using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Application.Models
{
    /// <summary>
    /// Represents a OperationItems.
    /// NOTE: This class is generated from a T4 template - you should not modify it manually.
    /// </summary>
    public class OperationItems 
    {	
		[Key]
        public int OperationItemId { get; set; }
        public int OperationId { get; set; }
        public string ItemNumber { get; set; }
    }
}      
