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

    public partial class CourseInstructorForm : Form
    {
        readonly DataManager dataManager = new DataManager();
        ValidationManager validationManager = new ValidationManager();
        public CourseInstructorForm()
        {
            InitializeComponent();
            LoadInstructors();
            LoadCourses();
            SetupDateTimePicker();
        }
        public void LoadInstructors()
        {
            List<InstructorDisplay> instructors = dataManager.GetInstructorDisplays();
            InstructorComboBox.DataSource = instructors;
            InstructorComboBox.DisplayMember = "FullName";
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
        public void LoadCourseInstructors()
        {
            dataGridView1.DataSource = dataManager.GetCourseInstructors();
        }

        private void CourseInstructorForm_Load(object sender, EventArgs e)
        {
            LoadCourseInstructors();
        }


        private void DeleteCourseInstructorButton_Click_1(object sender, EventArgs e)
        {
            if (dataGridView1.SelectedRows.Count > 0)
            {
                var selectedRow = dataGridView1.SelectedRows[0];
                int idValue = int.Parse(selectedRow.Cells[0].Value.ToString());
                dataManager.DeleteCourseInstructor(idValue);
                LoadCourseInstructors();
            }
        }

        private void UpdateCourseInstructorButton_Click_1(object sender, EventArgs e)
        {
            if (InstructorComboBox.SelectedIndex != -1 && CourseComboBox.SelectedIndex != -1 && comboBox1.SelectedIndex != -1)
            {

                if (dataGridView1.SelectedRows.Count > 0)
                {
                    var selectedRow = dataGridView1.SelectedRows[0];
                    int id = int.Parse(selectedRow.Cells[0].Value.ToString());
                    string selectedInstructor = ((InstructorDisplay)InstructorComboBox.SelectedItem).FullName;
                    string selectedCourse = ((Course)CourseComboBox.SelectedItem).Name;
                    string selectedSemester = comboBox1.SelectedItem.ToString() + dateTimePicker1.Value.ToString("yyyy");
                    dataManager.UpdateCourseInstructor(selectedInstructor, selectedCourse, selectedSemester, id);
                    LoadCourseInstructors();
                }
            }
        }

        private void AddCourseInstructorButton_Click_1(object sender, EventArgs e)
        {
            if (InstructorComboBox.SelectedIndex != -1 && CourseComboBox.SelectedIndex != -1 && comboBox1.SelectedIndex != -1)
            {
                string selectedInstrucor = ((InstructorDisplay)InstructorComboBox.SelectedItem).FullName;
                string selectedCourse = ((Course)CourseComboBox.SelectedItem).Name;
                string selectedSemester = comboBox1.SelectedItem.ToString() + dateTimePicker1.Value.ToString("yyyy");
                dataManager.AddCourseInstructor(selectedInstrucor, selectedCourse, selectedSemester);
                LoadCourseInstructors();
            }
        }
    }
}
/*
 *



       
    }
}
*/