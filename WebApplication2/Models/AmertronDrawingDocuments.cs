using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Application.Models
{
    /// <summary>
    /// Represents a AmertronDrawingDocuments.
    /// NOTE: This class is generated from a T4 template - you should not modify it manually.
    /// </summary>
    public class AmertronDrawingDocuments 
    {	
		[Key]
        public int AmerDwgDocId { get; set; }
        public int DrawingNumber { get; set; }
        public int DocumentId { get; set; }
    }
}      
