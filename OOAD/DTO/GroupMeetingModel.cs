using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOAD.DTO
{
    public class GroupMeetingModel
    {
        public int Id { get; set; }
        public int AppointmentId { get; set; }
        public List<int> UserIds { get; set; } = new List<int>();
       

    }
}
