using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace JamshidDashBoard.Models
{
    public class MeasurementInitializer : System.Data.Entity.DropCreateDatabaseIfModelChanges<MeasurementContext>
    {
        protected override void Seed(MeasurementContext context)
        {
           
            var monitors = new List<Monitor>
            {
                new Monitor{MonitorID = "Monitor1", PersonName = "Jamshid", PersonalPageUrl = "Url1"},
                new Monitor{MonitorID = "Monitor2", PersonName = "Jamshid1", PersonalPageUrl = "Url2"}
            };
            monitors.ForEach(s=>context.Monitors.Add(s));
            context.SaveChanges();
            var records = new List<Record>
            {
                new Record{HealtId = 1, HealtResult = 75, PartikkelId = 1, PartikkelResult = 55, MonitorID = "Monitor1", RecordId = DateTime.Parse("2018/09/26 09:00:00") },
                new Record{HealtId = 2, HealtResult = 115, PartikkelId = 1, PartikkelResult = 65, MonitorID = "Monitor1", RecordId = DateTime.Parse("2018/09/26 09:00:00") },
                new Record{HealtId = 3, HealtResult = 37, PartikkelId = 1, PartikkelResult = 67, MonitorID = "Monitor1", RecordId = DateTime.Parse("2018/09/26 09:00:00") },
                new Record{HealtId = 1, HealtResult = 75, PartikkelId = 1, PartikkelResult = 45, MonitorID = "Monitor1", RecordId = DateTime.Parse("2018/09/26 09:00:00") }
            };
            records.ForEach(s=>context.Records.Add(s));
            context.SaveChanges();
        }
    }
}