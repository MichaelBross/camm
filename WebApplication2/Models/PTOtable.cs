using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Application.Models
{
    /// <summary>
    /// Represents a PTOtable.
    /// NOTE: This class is generated from a T4 template - you should not modify it manually.
    /// </summary>
    public class PTOtable 
    {	
		[Key]
        public Int64 ptoID { get; set; }
        public int EmployeeID { get; set; }
        public DateTime PTOdate { get; set; }
        public int HoursRequested { get; set; }
        public int? HoursApproved { get; set; }
        public int? HoursGranted { get; set; }
    }
}      
