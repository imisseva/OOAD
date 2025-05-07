using System.Collections.Generic;
using System.Linq;
using OOAD.DTO;
using OOAD.Model;

namespace OOAD.Controller
{
    public class ReminderController
    {
        private readonly MeetingsEntities db = new MeetingsEntities();

        // Lấy tất cả các reminder kèm thông tin cuộc hẹn
        public List<ReminderViewModel> GetAllReminders()
        {
            return db.Reminder.Select(r => new ReminderViewModel
            {
                Id = r.id,
                AppointmentId = r.appointmentId,
                AppointmentTitle = r.Appointment.title,
                TimeBefore = r.timeBefore
            }).ToList();
        }

        // Lấy reminder theo appointmentId
        public List<ReminderViewModel> GetRemindersByAppointment(int appointmentId)
        {
            return db.Reminder
                .Where(r => r.appointmentId == appointmentId)
                .Select(r => new ReminderViewModel
                {
                    Id = r.id,
                    AppointmentId = r.appointmentId,
                    AppointmentTitle = r.Appointment.title,
                    TimeBefore = r.timeBefore
                }).ToList();
        }

        // Lấy chi tiết reminder theo ID
        public Reminder GetReminder(int id)
        {
            return db.Reminder.FirstOrDefault(r => r.id == id);
        }

        // Thêm reminder mới
        public void CreateReminder(int appointmentId, int timeBefore)
        {
            var reminder = new Reminder
            {
                appointmentId = appointmentId,
                timeBefore = timeBefore
            };
            db.Reminder.Add(reminder);
            db.SaveChanges();
        }

        // Cập nhật reminder
        public void UpdateReminder(int id, int timeBefore)
        {
            var reminder = db.Reminder.Find(id);
            if (reminder != null)
            {
                reminder.timeBefore = timeBefore;
                db.SaveChanges();
            }
        }

        // Xóa reminder
        public void DeleteReminder(int id)
        {
            var reminder = db.Reminder.Find(id);
            if (reminder != null)
            {
                db.Reminder.Remove(reminder);
                db.SaveChanges();
            }
        }
    }
}
