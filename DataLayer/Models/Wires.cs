using System;
namespace DataLayer.Models
{
    /// <summary>
    /// Represents a Wires.
    /// NOTE: This class is generated from a T4 template - you should not modify it manually.
    /// </summary>
    public class Wires 
    {
        public int WireId { get; set; }
        public int ConfigurationId { get; set; }
        public string From_ { get; set; }
        public string To_ { get; set; }
    }
}      
