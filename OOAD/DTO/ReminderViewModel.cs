using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOAD.DTO
{
    public class ReminderViewModel
    {
        public int Id { get; set; }
        public int AppointmentId { get; set; }
        public string AppointmentTitle { get; set; }
        public int TimeBefore { get; set; } // phút
    }
}