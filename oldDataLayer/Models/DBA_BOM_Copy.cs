using System;
namespace DataLayer.Models
{
    /// <summary>
    /// Represents a DBA_BOM_Copy.
    /// NOTE: This class is generated from a T4 template - you should not modify it manually.
    /// </summary>
    public class DBA_BOM_Copy 
    {
        public int? LineNumber { get; set; }
        public string ParentNumber { get; set; }
        public string ChildNumber { get; set; }
        public string Reference { get; set; }
        public double? QtyRequired { get; set; }
        public DateTime LastUpdate { get; set; }
    }
}      
