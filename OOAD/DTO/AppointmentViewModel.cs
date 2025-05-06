using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOAD.DTO
{
    public class AppointmentViewModel
    {
        public string Time { get; set; }
        public string Title { get; set; }
        public string Location { get; set; }
        public string Duration { get; set; }
        public string Type { get; set; }
        public string Participants { get; set; }
        public string Reminder { get; set; }
    }
}
