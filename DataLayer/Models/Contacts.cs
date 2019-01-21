using System;
namespace DataLayer.Models
{
    /// <summary>
    /// Represents a Contacts.
    /// NOTE: This class is generated from a T4 template - you should not modify it manually.
    /// </summary>
    public class Contacts 
    {
        public int ContactId { get; set; }
        public string ContactNumber { get; set; }
        public string Size { get; set; }
        public string WireGageRange { get; set; }
        public string Family { get; set; }
        public string ContactNotes { get; set; }
    }
}      
