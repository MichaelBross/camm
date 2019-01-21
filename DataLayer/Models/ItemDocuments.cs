using System;
namespace DataLayer.Models
{
    /// <summary>
    /// Represents a ItemDocuments.
    /// NOTE: This class is generated from a T4 template - you should not modify it manually.
    /// </summary>
    public class ItemDocuments 
    {
        public int ItemDocumentId { get; set; }
        public string ItemNumber { get; set; }
        public int DocId { get; set; }
        public DateTime? UpdatedOn { get; set; }
        public string UpdatedBy { get; set; }
    }
}      
