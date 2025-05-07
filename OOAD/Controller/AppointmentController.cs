    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Text;
    using System.Threading.Tasks;
    using OOAD.DTO;
    using OOAD.Model;
    namespace OOAD.Controller
    {
        public class AppointmentController
        {
            private readonly MeetingsEntities  db = new MeetingsEntities();

            public List<AppointmentViewModel> GetAppointmentsForDate(System.DateTime date)
            {
                var appointments = db.Appointment
                    .Where(a => a.startTime.Year == date.Year
                             && a.startTime.Month == date.Month
                             && a.startTime.Day == date.Day)
                    .ToList();

                var result = appointments.Select(a => new AppointmentViewModel
                {
                    Time = a.startTime.ToString("HH:mm"),
                    Title = a.title,
                    Location = a.location,
                    Duration = (a.endTime - a.startTime).TotalMinutes + " phút",
                    Type = a.GroupMeeting != null ? "Nhóm" : "Cá nhân",
                    Participants = a.GroupMeeting != null
                        ? string.Join(", ", a.GroupMeeting.User.Select(u => u.Name))
                        : a.User?.Name,
                    Reminder = string.Join(", ", a.Reminder.Select(r => $"Trước {r.timeBefore} phút"))
                }).ToList();
                return result;
            }

            public Appointment GetAppointmentDetails (int id)
            {
                return db.Appointment.FirstOrDefault(a => a.id == id);
            }

            public void CreateAppointment(string title, string location, DateTime startTime, DateTime endTime, int ownerId)
            {
                var appointment = new Appointment
                {
                    title = title,
                    location = location,
                    startTime = startTime,
                    endTime = endTime,
                    ownerId = ownerId
                };
                db.Appointment.Add(appointment);
                db.SaveChanges();
            }

            public void EditAppointment (int id, string title, string location, DateTime startTime, DateTime endTime)
            {
                var appointment = db.Appointment.FirstOrDefault(a => a.id == id);
                if (appointment != null)
                {
                    appointment.title = title;
                    appointment.location = location;
                    appointment.startTime = startTime;
                    appointment.endTime = endTime;
                    db.SaveChanges();
                }
            }

            public void DeleteAppointment(int id)
            {
                var appointment = db.Appointment.Find(id);
                if (appointment != null)
                {
                    db.Appointment.Remove(appointment);
                    db.SaveChanges();
                }
            }

        
        }
    }
