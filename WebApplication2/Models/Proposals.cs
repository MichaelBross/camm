using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Application.Models
{
    /// <summary>
    /// Represents a Proposals.
    /// NOTE: This class is generated from a T4 template - you should not modify it manually.
    /// </summary>
    public class Proposals 
    {	
		[Key, Column(Order = 0)]
        public string ProposalNumber { get; set; }
		[Key, Column(Order = 1)]
        public int QtyToBuild { get; set; }
    }
}      
