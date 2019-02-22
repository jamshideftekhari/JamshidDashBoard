using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Web;

namespace JamshidDashBoard.Models
{
    public class Monitor
    {
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public string MonitorID { get; set; }
        public string PersonName { get; set; }
        public string PersonalPageUrl { get; set; }

        public virtual ICollection<Record> Records { get; set; }
    }
}