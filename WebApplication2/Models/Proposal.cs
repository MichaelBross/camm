using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Application.Models
{
    public class Proposal 
    {	
		[Key, Column(Order = 0)]
        public string ProposalNumber { get; set; }
		[Key, Column(Order = 1)]
        public int QtyToBuild { get; set; }
    }
}      
