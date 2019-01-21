using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Application.Models
{
    /// <summary>
    /// Represents a AmertronDrawings.
    /// NOTE: This class is generated from a T4 template - you should not modify it manually.
    /// </summary>
    public class AmertronDrawings 
    {	
		[Key]
        public int DrawingNumber { get; set; }
        public string Description { get; set; }
        public string DateCreated { get; set; }
        public string Originator { get; set; }
        public string Class { get; set; }
    }
}      
