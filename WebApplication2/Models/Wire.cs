using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Application.Models
{
    /// <summary>
    /// Represents a Wire in a cable assembly.    
    /// </summary>
    public class Wire 
    {	
		[Key]
        public int WireId { get; set; }
        public int ConfigurationId { get; set; }
        public string From_ { get; set; }
        public string To_ { get; set; }
    }
}      
