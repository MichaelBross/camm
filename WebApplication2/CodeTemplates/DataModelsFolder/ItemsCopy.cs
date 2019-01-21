using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Application.Models
{
    /// <summary>
    /// Represents a ItemsCopy.
    /// NOTE: This class is generated from a T4 template - you should not modify it manually.
    /// </summary>
    public class ItemsCopy 
    {	
		[Key]
        public string ItemNumber { get; set; }
        public string Class { get; set; }
        public string Type { get; set; }
        public string ItemDescription { get; set; }
        public double? OnWorkOrder { get; set; }
        public double? OnAllocation { get; set; }
        public double? InWorkInProgress { get; set; }
        public double? Available { get; set; }
        public string UnitsOfMeasure { get; set; }
        public string Specs01 { get; set; }
        public string Specs02 { get; set; }
        public string Specs03 { get; set; }
        public string Specs04 { get; set; }
        public string Specs05 { get; set; }
        public string Specs06 { get; set; }
        public string Specs07 { get; set; }
        public string Specs08 { get; set; }
        public string Specs09 { get; set; }
        public string Specs10 { get; set; }
        public string Specs11 { get; set; }
        public string Specs12 { get; set; }
        public DateTime LastUpdate { get; set; }
    }
}      
