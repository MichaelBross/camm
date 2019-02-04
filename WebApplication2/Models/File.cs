using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Application.Models
{  
    public class File 
    {	
		[Key]
        public int FileId { get; set; }
        public int DocId { get; set; }
        public string Name { get; set; }
        public string Path { get; set; }
    }
}      
