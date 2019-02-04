using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Application.Models
{
    public class Tool 
    {	
		[Key]
        public int ToolId { get; set; }
        public string Manufacturer { get; set; }
        public string ModelNumber { get; set; }
        public string BinNumber { get; set; }
        public string MilitarySpec { get; set; }
        public string Description { get; set; }
        public string SerialNumber { get; set; }
        public string UpdatedOn { get; set; }
        public string UpdatedBy { get; set; }
        public string Comments { get; set; }
    }
}      
