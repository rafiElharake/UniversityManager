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
    public partial class InstructorForm : Form
    {
        ValidationManager validationManager = new ValidationManager();
        DataManager dataManager = new DataManager();
        public InstructorForm()
        {
            InitializeComponent();
        }
        private void LoadInstructorData()
        {
            using (var context = new UniversityDataContextDataContext(DataManager.connection))
            {
                var instructors = from I in context.Instructors
                                  select I;

                dataGridView1.DataSource = instructors.ToList();
            }
        }
        private void InstructorForm_Load(object sender, EventArgs e)
        {
            LoadInstructorData();
        }
        private void AddInstructorButton_Click(object sender, EventArgs e)
        {
            Instructor instructor = new Instructor
            {
                FirstName = FirstNameValue.Text,
                LastName = LastNameValue.Text,
                Email = EmailValue.Text
            };
            if (validationManager.ValidateAddInstructorData(instructor))
            {
                dataManager.AddInstructor(instructor);
                LoadInstructorData();
                FirstNameValue.Text = LastNameValue.Text = EmailValue.Text = "";
            }
        }

        private void DeleteInstructorButton_Click(object sender, EventArgs e)
        {
            if (dataGridView1.SelectedRows.Count > 0)
            {
                var selectedRow = dataGridView1.SelectedRows[0];
                int idValue = int.Parse(selectedRow.Cells[0].Value.ToString());
                dataManager.DeleteInstructor(idValue);
                LoadInstructorData();
            }
        }

        private void UpdateInstructorButton_Click(object sender, EventArgs e)
        {
            if (dataGridView1.SelectedRows.Count > 0)
            {
                var selectedRow = dataGridView1.SelectedRows[0];
                int id = int.Parse(selectedRow.Cells[0].Value.ToString());
                Instructor instructor = new Instructor
                {
                    FirstName = FirstNameValue.Text,
                    LastName = LastNameValue.Text,
                    Email = EmailValue.Text
                };
                if (validationManager.ValidateUpdateInstructorData(instructor))
                {
                    dataManager.UpdateInstructor(instructor, id);
                    LoadInstructorData();
                }
                FirstNameValue.Text = LastNameValue.Text = EmailValue.Text = "";


            }
        }
    }
}