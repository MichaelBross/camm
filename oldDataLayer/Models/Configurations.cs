using System;
namespace DataLayer.Models
{
    /// <summary>
    /// Represents a Configurations.
    /// NOTE: This class is generated from a T4 template - you should not modify it manually.
    /// </summary>
    public class Configurations 
    {
        public int ConfigurationId { get; set; }
        public string AssemblyNumber { get; set; }
        public string Rev { get; set; }
        public string WiredConnector { get; set; }
        public string ConnectorToWire { get; set; }
        public string AdaptorCable { get; set; }
    }
}      
