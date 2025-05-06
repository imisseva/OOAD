using OOAD.Model;
using OOAD.Controller;
using OOAD.DTO;
using System;
using System.Collections.Generic;
using System.Windows.Forms;

namespace OOAD.View
{
    public partial class MainView : Form
    {
        private DateTime currentdate = DateTime.Today;
        private readonly AppointmentController controller = new AppointmentController();

        public MainView()
        {
            InitializeComponent();
            InitializeGrid();
            LoadAppointments();
        }

        private void InitializeGrid()
        {
            dgv1.Columns.Clear();
            dgv1.Columns.Add("Time", "Time");
            dgv1.Columns.Add("Title", "Title");
            dgv1.Columns.Add("Location", "Location");
            dgv1.Columns.Add("Duration", "Duration");
            dgv1.Columns.Add("Type", "Type");
            dgv1.Columns.Add("Participants", "Participants");
            dgv1.Columns.Add("Reminder", "Reminder");
        }

        private void LoadAppointments()
        {
            lbDate.Text = currentdate.ToString("dd/MM/yyyy");
            dgv1.Rows.Clear();

            List<AppointmentViewModel> appointments = controller.GetAppointmentsForDate(currentdate);
            foreach (var a in appointments)
            {
                dgv1.Rows.Add(a.Time, a.Title, a.Location, a.Duration, a.Type, a.Participants, a.Reminder);
            }
        }

        private void btYesterday_Click(object sender, EventArgs e)
        {
            currentdate = currentdate.AddDays(-1);
            LoadAppointments();
        }

        private void btToday_Click(object sender, EventArgs e)
        {
            currentdate = DateTime.Today;
            LoadAppointments();
        }

        private void btTomorrow_Click(object sender, EventArgs e)
        {
            currentdate = currentdate.AddDays(1);
            LoadAppointments();
        }

        private void btAdd_Click(object sender, EventArgs e)
        {
            // Mở form tạo cuộc hẹn (sẽ xây dựng sau nếu cần)
        }
    }
}
