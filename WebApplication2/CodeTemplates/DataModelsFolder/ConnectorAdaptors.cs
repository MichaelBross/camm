using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Application.Models
{
    /// <summary>
    /// Represents a ConnectorAdaptors.
    /// NOTE: This class is generated from a T4 template - you should not modify it manually.
    /// </summary>
    public class ConnectorAdaptors 
    {	
		[Key]
        public int ConnectorAdaptorId { get; set; }
        public int ConnectorId { get; set; }
        public int AdaptorId { get; set; }
    }
}      
