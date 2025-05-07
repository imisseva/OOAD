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
        private readonly UserController userController = new UserController();
        private readonly UserViewModel _currentUser;
        private readonly UserViewModel userViewModel = new UserViewModel();


        public MainView()
        {
            
            InitializeComponent();
            InitializeGrid();
            LoadAppointments();
        }

        private void InitializeGrid()
        {
            dgv1.Columns.Clear();
            dgv1.Columns.Add(new DataGridViewTextBoxColumn
            {
                Name = "Time",
                HeaderText = "Time",
                ValueType = typeof(DateTime)
            });

            dgv1.Columns.Add(new DataGridViewTextBoxColumn
            {
                Name = "Title",
                HeaderText = "Title",
                ValueType = typeof(string)
            });

            dgv1.Columns.Add(new DataGridViewTextBoxColumn
            {
                Name = "Location",
                HeaderText = "Location",
                ValueType = typeof(string)
            });

            dgv1.Columns.Add(new DataGridViewTextBoxColumn
            {
                Name = "Duration",
                HeaderText = "Duration",
                ValueType = typeof(TimeSpan)
            });

            dgv1.Columns.Add(new DataGridViewTextBoxColumn
            {
                Name = "Type",
                HeaderText = "Type",
                ValueType = typeof(string)
            });

            dgv1.Columns.Add(new DataGridViewTextBoxColumn
            {
                Name = "Participants",
                HeaderText = "Participants",
                ValueType = typeof(string)
            });

            dgv1.Columns.Add(new DataGridViewTextBoxColumn
            {
                Name = "Reminder",
                HeaderText = "Reminder",
                ValueType = typeof(string)
            });
            dgv1.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
        }

        private void LoadAppointments()
        {
            
                try
                {
                    lbDate.Text = currentdate.ToString("dd/MM/yyyy");
                    dgv1.Rows.Clear();

                    List<AppointmentViewModel> appointments = controller.GetAppointmentsForDate(currentdate);

                    // Debug: Kiểm tra dữ liệu trả về
                    Console.WriteLine($"Số lượng appointment: {appointments?.Count}");
                    if (appointments != null)
                    {
                        foreach (var a in appointments)
                        {
                            Console.WriteLine($"Appointment: {a.Title} - {a.Time}");
                        }
                    }

                    if (appointments == null || appointments.Count == 0)
                    {
                        MessageBox.Show("Không có dữ liệu cuộc hẹn nào được tìm thấy");
                        return;
                    }

                    foreach (var a in appointments)
                    {
                        // Format dữ liệu trước khi hiển thị
                        //string timeString = a.Time.ToString("HH:mm");
                        //string durationString = a.Duration.ToString(@"hh\:mm");

                        dgv1.Rows.Add(
                            //timeString,
                            a.Title,
                            a.Location,
                            //durationString,
                            a.Type,
                            a.Participants,
                            a.Reminder
                        );
                    }

                }
                catch (Exception ex)
                {
                    MessageBox.Show($"Lỗi khi tải dữ liệu: {ex.Message}");
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
