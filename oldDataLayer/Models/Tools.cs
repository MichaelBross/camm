using System;
namespace DataLayer.Models
{
    /// <summary>
    /// Represents a Tools.
    /// NOTE: This class is generated from a T4 template - you should not modify it manually.
    /// </summary>
    public class Tools 
    {
        public int ToolId { get; set; }
        public string Manufacturer { get; set; }
        public string ModelNumber { get; set; }
        public string BinNumber { get; set; }
        public string MilitarySpec { get; set; }
        public string Description { get; set; }
        public string SerialNumber { get; set; }
        public string UpdatedOn { get; set; }
        public string UpdatedBy { get; set; }
        public string Comments { get; set; }
    }
}      
