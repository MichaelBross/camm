using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Application.Models
{
    /// <summary>
    /// Represents a AssemblyTypes.
    /// NOTE: This class is generated from a T4 template - you should not modify it manually.
    /// </summary>
    public class AssemblyTypes 
    {	
		[Key]
        public string AssemblyType { get; set; }
        public string AssyTypeDescription { get; set; }
    }
}      
