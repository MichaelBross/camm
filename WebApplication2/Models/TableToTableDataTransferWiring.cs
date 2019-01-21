using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Application.Models
{
    /// <summary>
    /// Represents a TableToTableDataTransferWiring.
    /// NOTE: This class is generated from a T4 template - you should not modify it manually.
    /// </summary>
    public class TableToTableDataTransferWiring 
    {	
		[Key, Column(Order = 0)]
        public string SourceTableName { get; set; }
		[Key, Column(Order = 1)]
        public string SourceColumnName { get; set; }
        public string DestinationTableName { get; set; }
        public string DestinationColumnName { get; set; }
        public bool PrimaryKey { get; set; }
    }
}      
