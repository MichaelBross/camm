using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Application.Models
{
    /// <summary>
    /// Represents a Files.
    /// NOTE: This class is generated from a T4 template - you should not modify it manually.
    /// </summary>
    public class Files 
    {	
		[Key]
        public int FileId { get; set; }
        public int DocId { get; set; }
        public string Name { get; set; }
        public string Path { get; set; }
    }
}      
