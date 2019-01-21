using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Application.Models
{
    /// <summary>
    /// Represents a test_cable_log.
    /// NOTE: This class is generated from a T4 template - you should not modify it manually.
    /// </summary>
    public class test_cable_log 
    {	
		[Key]
        public int test_cable_logId { get; set; }
        public string Item_number { get; set; }
        public string Description { get; set; }
        public string Second_Description { get; set; }
        public string Bin_no { get; set; }
        public string On_Hand { get; set; }
        public string Mate { get; set; }
        public string Print_Label { get; set; }
        public string last_update { get; set; }
        public string update_by { get; set; }
        public string auto_update { get; set; }
        public string auto_updated_by { get; set; }
    }
}      
