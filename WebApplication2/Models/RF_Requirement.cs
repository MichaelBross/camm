using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Application.Models
{
    public class RF_Requirement
    {	
		[Key]
        public int rf_requirementsId { get; set; }
        public string start_frequency_ghz { get; set; }
        public string stop_frequency_ghz { get; set; }
        public string insertion_loss_db { get; set; }
        public string vswr { get; set; }
        public string created_by { get; set; }
        public string created_on { get; set; }
        public string verified_by { get; set; }
        public string verified_on { get; set; }
    }
}      
