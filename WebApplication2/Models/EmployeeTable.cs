using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Application.Models
{
    /// <summary>
    /// Represents a EmployeeTable.
    /// NOTE: This class is generated from a T4 template - you should not modify it manually.
    /// </summary>
    public class EmployeeTable 
    {	
		[Key]
        public int EmployeeID { get; set; }
        public string Name { get; set; }
        public decimal Rate { get; set; }
        public string PassWord { get; set; }
        public string Title { get; set; }
        public bool? CurrentEmployee { get; set; }
    }
}      
