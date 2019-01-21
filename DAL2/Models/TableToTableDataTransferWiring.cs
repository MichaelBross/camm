using System;
namespace DataLayer.Models
{
    /// <summary>
    /// Represents a TableToTableDataTransferWiring.
    /// NOTE: This class is generated from a T4 template - you should not modify it manually.
    /// </summary>
    public class TableToTableDataTransferWiring 
    {
        public string SourceTableName { get; set; }
        public string SourceColumnName { get; set; }
        public string DestinationTableName { get; set; }
        public string DestinationColumnName { get; set; }
        public bool PrimaryKey { get; set; }
    }
}      
