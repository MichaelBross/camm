using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Application.Models
{
    /// <summary>
    /// Represents a CodeFragments.
    /// NOTE: This class is generated from a T4 template - you should not modify it manually.
    /// </summary>
    public class CodeFragments 
    {	
		[Key]
        public int FragmentId { get; set; }
        public string FragmentDescription { get; set; }
        public string Fragment { get; set; }
    }
}      
