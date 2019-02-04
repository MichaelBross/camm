using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Application.Models
{
    public class ConnectorTool 
    {	
		[Key]
        public int ConnectorToolId { get; set; }
        public int ConnectorId { get; set; }
        public int ToolId { get; set; }
    }
}      
