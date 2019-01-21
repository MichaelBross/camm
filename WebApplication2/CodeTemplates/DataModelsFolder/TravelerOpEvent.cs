using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Application.Models
{
    /// <summary>
    /// Represents a TravelerOpEvent.
    /// NOTE: This class is generated from a T4 template - you should not modify it manually.
    /// </summary>
    public class TravelerOpEvent 
    {	
		[Key]
        public int TravelerOpEventId { get; set; }
        public int TravelerOperationId { get; set; }
        public int TimeEntryId { get; set; }
        public int? QtyCompleted { get; set; }
        public int? QtyAccepted { get; set; }
        public int? QtyRejected { get; set; }
        public string Notes { get; set; }
    }
}      
