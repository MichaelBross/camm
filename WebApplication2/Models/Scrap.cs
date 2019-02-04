using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Application.Models
{
    public class Srap
    {	
		[Key]
        public int scrap_logId { get; set; }
        public string DATE { get; set; }
        public string WO_NO { get; set; }
        public int? JOB_NO { get; set; }
        public string PART_NUMBER { get; set; }
        public int? QTY { get; set; }
        public int? EMP_NO { get; set; }
        public string REASON_FOR_SCRAPING_PART { get; set; }
        public string QC_INITIALS { get; set; }
        public string QC_RECOMMENDED_DISPOSITION { get; set; }
        public string STOCK_ROOM_ACTION { get; set; }
        public string MANAGEMENT_DISPOSITION_OF_SCRAP { get; set; }
        public string FINAL_DISPOSITION_DATE { get; set; }
    }
}      
