using System;
namespace DataLayer.Models
{
    /// <summary>
    /// Represents a TravelerOperation.
    /// NOTE: This class is generated from a T4 template - you should not modify it manually.
    /// </summary>
    public class TravelerOperation 
    {
        public int TravelerOperationId { get; set; }
        public int TravelerId { get; set; }
        public int OperationId { get; set; }
        public string Description { get; set; }
        public int SequenceNumber { get; set; }
        public int? QtyOpsPerTraveler { get; set; }
        public string Notes { get; set; }
    }
}      
