using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Application.Models
{
    /// <summary>
    /// Represents a ConnectorDocuments.
    /// NOTE: This class is generated from a T4 template - you should not modify it manually.
    /// </summary>
    public class ConnectorDocuments 
    {	
		[Key]
        public int ConnectorDocId { get; set; }
        public int ConnectorId { get; set; }
        public int DocId { get; set; }
    }
}      
