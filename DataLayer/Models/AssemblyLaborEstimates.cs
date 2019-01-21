using System;
namespace DataLayer.Models
{
    /// <summary>
    /// Represents a AssemblyLaborEstimates.
    /// NOTE: This class is generated from a T4 template - you should not modify it manually.
    /// </summary>
    public class AssemblyLaborEstimates 
    {
        public int AssemblyLaborEstId { get; set; }
        public string AssemblyNumber { get; set; }
        public int QtyToBuild { get; set; }
        public double? EstimatedLaborHours { get; set; }
    }
}      
