using System;
namespace DataLayer.Models
{
    /// <summary>
    /// Represents a rf_cable_tests.
    /// NOTE: This class is generated from a T4 template - you should not modify it manually.
    /// </summary>
    public class rf_cable_tests 
    {
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
