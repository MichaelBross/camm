using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Application.Models
{
    /// <summary>
    /// Represents a Connectors.
    /// NOTE: This class is generated from a T4 template - you should not modify it manually.
    /// </summary>
    public class Connectors 
    {	
		[Key]
        public int ConnectorId { get; set; }
        public string ConnectorNumber { get; set; }
        public string Description { get; set; }
        public string Family { get; set; }
        public string ConnectorNotes { get; set; }
    }
}      
