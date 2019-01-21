using System;
namespace DataLayer.Models
{
    /// <summary>
    /// Represents a Connectors.
    /// NOTE: This class is generated from a T4 template - you should not modify it manually.
    /// </summary>
    public class Connectors 
    {
        public int ConnectorId { get; set; }
        public string ConnectorNumber { get; set; }
        public string Description { get; set; }
        public string Family { get; set; }
        public string ConnectorNotes { get; set; }
    }
}      
