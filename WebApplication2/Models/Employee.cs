using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Application.Models
{
    public class Employee 
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
