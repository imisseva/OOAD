using System.Collections.Generic;
using System.Linq;
using OOAD.DTO;
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

        public GroupMeeting GetGroupMeetingDetails(int appointmentId)
        {
            return db.GroupMeeting.FirstOrDefault(g => g.appointmentId == appointmentId);
        }

        // Trả về danh sách ViewModel để hiển thị ở View
        public List<GroupMeetingViewModel> GetGroupMeetingViewModels()
        {
            return db.GroupMeeting
                .Select(g => new GroupMeetingViewModel
                {
                    AppointmentId = g.appointmentId,
                    Title = g.Appointment.title,
                    Location = g.Appointment.location,
                    StartTime = g.Appointment.startTime.ToString("HH:mm"),
                    EndTime = g.Appointment.endTime.ToString("HH:mm"),
                    OwnerName = g.Appointment.User.Name,
                    Participants = string.Join(", ", g.User.Select(u => u.Name)),
                    Reminders = string.Join(", ", g.Appointment.Reminder.Select(r => $"Trước {r.timeBefore} phút"))
                })
                .ToList();
        }

        // Tạo mới một group meeting
        public void CreateGroupMeeting(int appointmentId)
        {
            var groupMeeting = new GroupMeeting
            {
                appointmentId = appointmentId
            };
            db.GroupMeeting.Add(groupMeeting);
            db.SaveChanges();
        }

        // Xoá group meeting theo appointmentId
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
