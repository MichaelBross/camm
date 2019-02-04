using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Application.Models
{
    public class Connector 
    {	
		[Key, ScaffoldColumn(false)]
        public int ConnectorId { get; set; }
        [Display(Name ="Number")]
        public string ConnectorNumber { get; set; }
        public string Description { get; set; }
        public string Family { get; set; }
        [Display(Name ="Notes")]
        public string ConnectorNotes { get; set; }
    }
}      
