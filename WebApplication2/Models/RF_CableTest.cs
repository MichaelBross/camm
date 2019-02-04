using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Application.Models
{
    public class RF_CableTest
    {	
		[Key]
        public int rf_cable_testsId { get; set; }
        public string assembly_number { get; set; }
        public string vna_state { get; set; }
        public string rf_requirements { get; set; }
        public string rev { get; set; }
        public string created_by { get; set; }
        public string created_on { get; set; }
        public string verified_by { get; set; }
        public string verified_on { get; set; }
    }
}      
