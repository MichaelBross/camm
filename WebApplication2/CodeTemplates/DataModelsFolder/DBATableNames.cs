using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Application.Models
{
    /// <summary>
    /// Represents a DBATableNames.
    /// NOTE: This class is generated from a T4 template - you should not modify it manually.
    /// </summary>
    public class DBATableNames 
    {	
		[Key]
        public string TableName { get; set; }
        public string TableDescription { get; set; }
    }
}      
