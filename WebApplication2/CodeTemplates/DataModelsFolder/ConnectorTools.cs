using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Application.Models
{
    /// <summary>
    /// Represents a ConnectorTools.
    /// NOTE: This class is generated from a T4 template - you should not modify it manually.
    /// </summary>
    public class ConnectorTools 
    {	
		[Key]
        public int ConnectorToolId { get; set; }
        public int ConnectorId { get; set; }
        public int ToolId { get; set; }
    }
}      
