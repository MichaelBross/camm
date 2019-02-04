using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Application.Models
{
    public class BOM
    {
        [Key]
        public int BOMID { get; set; }
        public int? LineNumber { get; set; }
        public string ParentNumber { get; set; }
        public string ChildNumber { get; set; }
        public string Reference { get; set; }
        public double? QtyRequired { get; set; }
        public DateTime LastUpdate { get; set; }
    }
}
