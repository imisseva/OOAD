using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOAD.DTO
{
    public class GroupMeetingViewModel
    {
        public int AppointmentId { get; set; }
        public string Title { get; set; }
        public string Location { get; set; }
        public string StartTime { get; set; }
        public string EndTime { get; set; }
        public string OwnerName { get; set; }
        public string Participants { get; set; }
        public string Reminders { get; set; }
    }
}

