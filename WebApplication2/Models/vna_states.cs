using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Application.Models
{
    /// <summary>
    /// Represents a vna_states.
    /// NOTE: This class is generated from a T4 template - you should not modify it manually.
    /// </summary>
    public class vna_states 
    {	
		[Key]
        public int vna_statesId { get; set; }
        public string reg_name { get; set; }
        public string start_frequency_ghz { get; set; }
        public string stop_frequency_ghz { get; set; }
        public string tdr { get; set; }
        public string rf_requirements { get; set; }
        public string calibrated { get; set; }
        public string calibrated_on { get; set; }
    }
}      
