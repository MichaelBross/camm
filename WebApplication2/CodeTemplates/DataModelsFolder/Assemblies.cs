using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Application.Models
{
    /// <summary>
    /// Represents a Assemblies.
    /// NOTE: This class is generated from a T4 template - you should not modify it manually.
    /// </summary>
    public class Assemblies 
    {	
		[Key]
        public int AssemblyId { get; set; }
        public string AssemblyNumber { get; set; }
        public string AssemblyRev { get; set; }
        public string AssemblyType { get; set; }
        public string AssemblyRootNumber { get; set; }
    }
}      
