using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace UniversityManager.Forms
{
    public partial class MainForm : Form
    {
        public MainForm()
        {
            InitializeComponent();
        }
        bool signedin = false;
        private void StudentFormButton_Click(object sender, EventArgs e)
        {
            if (signedin)
            {
                StudentForm studentForm = new StudentForm();
                studentForm.Show();
            }
            else
            {
                MessageBox.Show("please sign in");
            }
        }

        private void InstructorFormButton_Click(object sender, EventArgs e)
        {
            if (signedin)
            {
                InstructorForm instructorForm = new InstructorForm();
                instructorForm.Show();
            }
            else
            {
                MessageBox.Show("please sign in");
            }
        }

        private void CourseFormButton_Click(object sender, EventArgs e)
        {
            if (signedin)
            {
                CourseForm courseForm = new CourseForm();
                courseForm.Show();
            }
            else
            {
                MessageBox.Show("please sign in");
            }
        }

        private void EnrollmentButton_Click(object sender, EventArgs e)
        {
            if (signedin)
            {
                EnrollmentForm enrollmentForm = new EnrollmentForm();
                enrollmentForm.Show();
            }
            else
            {
                MessageBox.Show("please sign in");
            }
        }

        private void CourseInstructorButton_Click(object sender, EventArgs e)
        {
            if (signedin)
            {
                CourseInstructorForm courseInstructorForm = new CourseInstructorForm();
                courseInstructorForm.Show();
            }
            else
            {
                MessageBox.Show("please sign in");
            }
        }

        private void SignInButton_Click(object sender, EventArgs e)
        {
            if (!signedin)
            {
                SignInForm signInForm = new SignInForm();
                signInForm.SignInSuccessful += SignInForm_SignInSuccessful;
                signInForm.Show();
            }
            else
            {
                MessageBox.Show("you are already signed in");
            }
        }
        private void SignInForm_SignInSuccessful(object sender, EventArgs e)
        {
            signedin = true;
        }
    }
}
