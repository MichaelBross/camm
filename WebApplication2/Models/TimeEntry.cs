using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Application.Models
{
    public class TimeEntry
    {	
		[Key]
        public int TimeEntryID { get; set; }
        public Int16 EmployeeID { get; set; }
        public string WorkOrder { get; set; }
        public DateTime StartTime { get; set; }
        public decimal? TimeSpent { get; set; }
        public Int16 UpdatedBy { get; set; }
        public DateTime UpdatedOn { get; set; }
        public string Signature { get; set; }
        public decimal? LaborCost { get; set; }
        public string SignatureSupervisor { get; set; }
    }
}      
