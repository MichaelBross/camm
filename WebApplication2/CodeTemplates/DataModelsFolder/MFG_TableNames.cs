using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Application.Models
{
    /// <summary>
    /// Represents a MFG_TableNames.
    /// NOTE: This class is generated from a T4 template - you should not modify it manually.
    /// </summary>
    public class MFG_TableNames 
    {	
		[Key]
        public string MFG_TableName { get; set; }
        public string MFG_TableDescription { get; set; }
    }
}      
