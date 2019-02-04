using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Application.Models
{
    public class ConnectorDocument 
    {	
		[Key]
        public int ConnectorDocId { get; set; }
        public int ConnectorId { get; set; }
        public int DocId { get; set; }
    }
}      
