using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Application.Models
{
    /// <summary>
    /// Represents a ServerFiles.
    /// NOTE: This class is generated from a T4 template - you should not modify it manually.
    /// </summary>
    public class ServerFiles 
    {	
		[Key]
        public int ServerFileID { get; set; }
        public string FilePath { get; set; }
    }
}      
