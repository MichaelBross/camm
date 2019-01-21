using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Application.Models
{
    /// <summary>
    /// Represents a ConnectorContacts.
    /// NOTE: This class is generated from a T4 template - you should not modify it manually.
    /// </summary>
    public class ConnectorContacts 
    {	
		[Key]
        public int ConnectorContactId { get; set; }
        public int ConnectorId { get; set; }
        public int ContactId { get; set; }
    }
}      
