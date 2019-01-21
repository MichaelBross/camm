using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Application.Models
{
    /// <summary>
    /// Represents a DocumentTypes.
    /// NOTE: This class is generated from a T4 template - you should not modify it manually.
    /// </summary>
    public class DocumentTypes 
    {	
		[Key]
        public string DocType { get; set; }
        public string DocTypeDescription { get; set; }
    }
}      
