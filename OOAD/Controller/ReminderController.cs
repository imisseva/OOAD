using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using OOAD.Model;

namespace OOAD.Controller
{
    public class ReminderController
    {
        private readonly MeetingsEntities db = new MeetingsEntities();
        public List<Reminder> GetReminders(int appointmentId)
        {
            return db.Reminder.Where(r => r.appointmentId == appointmentId).ToList();
        }
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
