using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using UniversityManager.DataFolder;

namespace UniversityManager.Forms
{
    public partial class EnrollmentForm : Form
    {
        readonly DataManager dataManager = new DataManager();
        ValidationManager validationManager = new ValidationManager();
        public EnrollmentForm()
        {
            InitializeComponent();
            LoadStudents();
            LoadCourses();
            SetupDateTimePicker();
        }
        public void LoadStudents()
        {
            List<StudentDisplay> students = dataManager.GetStudentDisplays();
            StudentComboBox.DataSource = students;
            StudentComboBox.DisplayMember = "FullName";
        }
        public void LoadCourses()
        {
            List<Course> courses = dataManager.GetCourseDisplays();
            CourseComboBox.DataSource = courses;
            CourseComboBox.DisplayMember = "Name";
        }
        private void SetupDateTimePicker()
        {
            dateTimePicker1.Format = DateTimePickerFormat.Custom;
            dateTimePicker1.CustomFormat = "yyyy"; // Display only the year
            dateTimePicker1.ShowUpDown = true; // Use up/down buttons for year selection
            dateTimePicker1.Value = DateTime.Now; // Set default value to current year
        }
        public void LoadEnrollment()
        {
            dataGridView1.DataSource = dataManager.GetEnrollments();
        }
        private void EnrollmentForm_Load(object sender, EventArgs e)
        {
            LoadEnrollment();
        }

        private void AddEnrollmentButton_Click(object sender, EventArgs e)
        {
            if (StudentComboBox.SelectedIndex != -1 && CourseComboBox.SelectedIndex != -1 && comboBox1.SelectedIndex != -1)
            {
                string selectedStudent = ((StudentDisplay)StudentComboBox.SelectedItem).FullName;
                string selectedCourse = ((Course)CourseComboBox.SelectedItem).Name;
                string selectedSemester = comboBox1.SelectedItem.ToString() + dateTimePicker1.Value.ToString("yyyy");
                dataManager.AddEnrollment(selectedStudent, selectedCourse, selectedSemester);
                LoadEnrollment();
            }
        }

        private void DeleteEnrollmentButton_Click(object sender, EventArgs e)
        {
            if (dataGridView1.SelectedRows.Count > 0)
            {
                var selectedRow = dataGridView1.SelectedRows[0];
                int idValue = int.Parse(selectedRow.Cells[0].Value.ToString());
                dataManager.DeleteEnrollment(idValue);
                LoadEnrollment();
            }
        }

        private void UpdateEnrollmentButton_Click(object sender, EventArgs e)
        {
            if (StudentComboBox.SelectedIndex != -1 && CourseComboBox.SelectedIndex != -1 && comboBox1.SelectedIndex != -1)
            {

                if (dataGridView1.SelectedRows.Count > 0)
                {
                    var selectedRow = dataGridView1.SelectedRows[0];
                    int id = int.Parse(selectedRow.Cells[0].Value.ToString());
                    string selectedStudent = ((StudentDisplay)StudentComboBox.SelectedItem).FullName;
                    string selectedCourse = ((Course)CourseComboBox.SelectedItem).Name;
                    string selectedSemester = comboBox1.SelectedItem.ToString() + dateTimePicker1.Value.ToString("yyyy");
                    dataManager.UpdateEnrollment(selectedStudent, selectedCourse, selectedSemester, id);
                    LoadEnrollment();
                }
            }
        }

        private void SearchButton_Click(object sender, EventArgs e)
        {

            string selectedStudent = StudentComboBox.SelectedItem != null
                ? ((StudentDisplay)StudentComboBox.SelectedItem).FullName
                : null;

            string selectedCourse = CourseComboBox.SelectedItem != null
                ? ((Course)CourseComboBox.SelectedItem).Name
                : null;

            string selectedSemester = comboBox1.SelectedItem != null
                ? comboBox1.SelectedItem.ToString() + dateTimePicker1.Value.ToString("yyyy")
                : dateTimePicker1.Value.ToString("yyyy");
            dataGridView1.DataSource = dataManager.GetFilteredEnrollments(selectedSemester, selectedStudent, selectedCourse);

        }
    }
}
