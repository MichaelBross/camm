using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Application.Models
{
    /// <summary>
    /// Represents a AssemblyLaborEstimates.
    /// NOTE: This class is generated from a T4 template - you should not modify it manually.
    /// </summary>
    public class AssemblyLaborEstimates 
    {	
		[Key]
        public int AssemblyLaborEstId { get; set; }
        public string AssemblyNumber { get; set; }
        public int QtyToBuild { get; set; }
        public double? EstimatedLaborHours { get; set; }
    }
}      
