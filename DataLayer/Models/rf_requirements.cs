using System;
namespace DataLayer.Models
{
    /// <summary>
    /// Represents a rf_requirements.
    /// NOTE: This class is generated from a T4 template - you should not modify it manually.
    /// </summary>
    public class rf_requirements 
    {
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
