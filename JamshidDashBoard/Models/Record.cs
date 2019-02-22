using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Web;

namespace JamshidDashBoard.Models
{
    public class Record
    {
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public DateTime RecordId { get; set; }
        public string MonitorID { get; set; }
        
        public int PartikkelId { get; set; }
        public double PartikkelResult { get; set; }

        public int HealtId { get; set; }
        public double HealtResult { get; set; }

        public virtual Monitor Monitor { get; set; }
    }
}