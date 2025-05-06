using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using OOAD.Model;

namespace OOAD.Controller
{
    public class GroupMeetingController
    {
        private readonly MeetingsEntities db = new MeetingsEntities();

        public List<GroupMeeting> GetGroupMeetings()
        {
            return db.GroupMeeting.ToList();
        }
        public GroupMeeting GetGroupMeetingDetails(int id)
        {
            return db.GroupMeeting.FirstOrDefault(g => g.appointmentId == id);
        }
        public void CreateGroupMeeting(int appointmentId)
        {
            var groupMeeting = new GroupMeeting
            {
                appointmentId = appointmentId
            };
            db.GroupMeeting.Add(groupMeeting);
            db.SaveChanges();
        }

        public void DeleteGroupMeeting(int appointmentId)
        {
            var groupMeeting = db.GroupMeeting.FirstOrDefault(g => g.appointmentId == appointmentId);
            if (groupMeeting != null)
            {
                db.GroupMeeting.Remove(groupMeeting);
                db.SaveChanges();
            }
        }
    }
}
