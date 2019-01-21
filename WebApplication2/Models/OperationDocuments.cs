using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Application.Models
{
    /// <summary>
    /// Represents a OperationDocuments.
    /// NOTE: This class is generated from a T4 template - you should not modify it manually.
    /// </summary>
    public class OperationDocuments 
    {	
		[Key]
        public int OperationDocumentId { get; set; }
        public int OperationId { get; set; }
        public int DocumentId { get; set; }
    }
}      
