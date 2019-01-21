using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Application.Models
{
    /// <summary>
    /// Represents a ApprovedMfgs.
    /// NOTE: This class is generated from a T4 template - you should not modify it manually.
    /// </summary>
    public class ApprovedMfgs 
    {	
		[Key]
        public int ApprovedMfgId { get; set; }
        public string MfgKey { get; set; }
        public string MfgKey2 { get; set; }
        public string MfgParent { get; set; }
        public string MfgProduct { get; set; }
        public string MfgCustomer { get; set; }
        public string MfgMfg { get; set; }
        public string MfgPartNumber { get; set; }
        public string MfgExtra { get; set; }
        public DateTime? LastUpdate { get; set; }
    }
}      
