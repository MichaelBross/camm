using System;
namespace DataLayer.Models
{
    /// <summary>
    /// Represents a Files.
    /// NOTE: This class is generated from a T4 template - you should not modify it manually.
    /// </summary>
    public class Files 
    {
        public int FileId { get; set; }
        public int DocId { get; set; }
        public string Name { get; set; }
        public string Path { get; set; }
    }
}      
