using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Application.Models
{
    /// <summary>
    /// Represents a RoutingOperations.
    /// NOTE: This class is generated from a T4 template - you should not modify it manually.
    /// </summary>
    public class RoutingOperations 
    {	
		[Key]
        public int RoutingOperationId { get; set; }
        public int RoutingId { get; set; }
        public int SequenceNumber { get; set; }
        public int OperationId { get; set; }
    }
}      
