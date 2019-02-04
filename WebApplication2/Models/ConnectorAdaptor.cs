using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Application.Models
{
    public class ConnectorAdaptor 
    {	
		[Key]
        public int ConnectorAdaptorId { get; set; }
        public int ConnectorId { get; set; }
        public int AdaptorId { get; set; }
    }
}      
