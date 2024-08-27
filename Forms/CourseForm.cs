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
    public partial class CourseForm : Form
    {
        ValidationManager validationManager = new ValidationManager();
        DataManager dataManager = new DataManager();
        public CourseForm()
        {
            InitializeComponent();
        }
        private void LoadCourseData()
        {
            using (var context = new UniversityDataContextDataContext(DataManager.connection))
            {
                var courses = from s in context.Courses
                              select s;

                dataGridView1.DataSource = courses.ToList();
            }
        }
        private void CourseForm_Load(object sender, EventArgs e)
        {
            LoadCourseData();
        }

        private void AddCourseButton_Click(object sender, EventArgs e)
        {
            if (validationManager.IsValidCredits(CreditsValue.Text))
            {
                Course course = new Course
                {
                    Name = CourseNameValue.Text,
                    Code = CourseCodeValue.Text,
                    Credits = int.Parse(CreditsValue.Text)
                };
                if (validationManager.ValidateAddCourseData(course))
                {
                    dataManager.AddCourse(course);
                    LoadCourseData();
                    CourseNameValue.Text = CourseCodeValue.Text = CreditsValue.Text = "";
                }
            }
        }

        private void DeleteCourseButton_Click(object sender, EventArgs e)
        {

            if (dataGridView1.SelectedRows.Count > 0)
            {
                var selectedRow = dataGridView1.SelectedRows[0];
                int idValue = int.Parse(selectedRow.Cells[0].Value.ToString());
                dataManager.DeleteCourse(idValue);
                LoadCourseData();
            }
        }

        private void UpdateCourseButton_Click_1(object sender, EventArgs e)
        {
            Course course = new Course();
            if (CreditsValue.Text.ToString() == "")
            {
                course = new Course
                {
                    Name = CourseNameValue.Text,
                    Code = CourseCodeValue.Text,
                };
            }
            else if (validationManager.IsValidCredits(CreditsValue.Text))
            {
                course = new Course
                {
                    Name = CourseNameValue.Text,
                    Code = CourseCodeValue.Text,
                    Credits = int.Parse(CreditsValue.Text)
                };
            }
            if (dataGridView1.SelectedRows.Count > 0)
            {
                var selectedRow = dataGridView1.SelectedRows[0];
                int id = int.Parse(selectedRow.Cells[0].Value.ToString());

                dataManager.UpdateCourse(course, id);
                LoadCourseData();
                CourseNameValue.Text = CourseCodeValue.Text = CreditsValue.Text = "";
            }
        }

    }
}