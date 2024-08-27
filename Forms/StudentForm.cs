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

namespace UniversityManager
{
    public partial class StudentForm : Form
    {
        private readonly ValidationManager validationManager = new ValidationManager();
        private readonly DataManager dataManager = new DataManager();
        public StudentForm()
        {
            InitializeComponent();
            
        }
        private void LoadStudentData()
        {
            using (var context = new UniversityDataContextDataContext(DataManager.connection))
            {
                var students = from s in context.Students
                               select s;

                dataGridView1.DataSource = students.ToList();
            }
        }

        private void StudentForm_Load(object sender, EventArgs e)
        {
            LoadStudentData();
        }

        private void AddStudentButton_Click(object sender, EventArgs e)
        {
            Student student = new Student
            {
                FirstName = FirstNameValue.Text,
                LastName = LastNameValue.Text,
                Email = EmailValue.Text
            };
            if (validationManager.ValidateAddStudentData(student))
            {
                dataManager.AddStudent(student);
                LoadStudentData();
                FirstNameValue.Text = LastNameValue.Text = EmailValue.Text = "";
            }
        }

        private void DeleteStudentButton_Click(object sender, EventArgs e)
        { 
            if (dataGridView1.SelectedRows.Count > 0)  
            {
                var selectedRow = dataGridView1.SelectedRows[0]; 
                int idValue = int.Parse(selectedRow.Cells[0].Value.ToString());
                dataManager.DeleteStudent(idValue);
                LoadStudentData();
            }         
        }

        private void UpdateStudentButton_Click(object sender, EventArgs e)
        {
            if (dataGridView1.SelectedRows.Count > 0)
            {
                var selectedRow=dataGridView1.SelectedRows[0];
                int id = int.Parse(selectedRow.Cells[0].Value.ToString());
                Student student = new Student
                {
                    FirstName = FirstNameValue.Text,
                    LastName = LastNameValue.Text,
                    Email = EmailValue.Text
                };
                if (validationManager.ValidateUpdateStudentData(student))
                {
                    dataManager.UpdateStudent(student, id);
                    LoadStudentData();
                }
                FirstNameValue.Text = LastNameValue.Text = EmailValue.Text = "";
            }
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
