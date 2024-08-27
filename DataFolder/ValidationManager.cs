using System;
using System.Collections.Generic;
using System.Data.Linq;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace UniversityManager.DataFolder
{
    public class ValidationManager
    {
        private static readonly string EmailPattern = @"^[^@\s]+@[^@\s]+\.[^@\s]+$";
        private readonly UniversityDataContextDataContext dataContext;
        public static string connection = "Data Source=DESKTOP-FOT4SJ9;Initial Catalog=ProgrammingTutorialDB;Integrated Security=True;Encrypt=True;TrustServerCertificate=True";
        public ValidationManager()
        {
            dataContext = new UniversityDataContextDataContext(connection);
        }
        public static bool IsValidEmail(string email)
        { 
            return Regex.IsMatch(email, EmailPattern);
        }

        public bool ValidateAddStudentData(Student student)
        {
            bool result = true;
            if (student.LastName == "" || student.FirstName == "" || student.Email == "") result = false;
            if(!IsValidEmail(student.Email)) result = false;
            return result; 
        }
        public bool ValidateUpdateStudentData(Student student)
        {
            bool result = true;
            if (student.Email != "")
            {
                if (!IsValidEmail(student.Email)) result = false;
            } 
            return result;
        }
        public bool ValidateAddInstructorData(Instructor instructor)
        {
            bool result = true;
            if (instructor.LastName == "" || instructor.FirstName == "" || instructor.Email == "") result = false;
            if (!IsValidEmail(instructor.Email)) result = false;
            return result;
        }
        public bool ValidateUpdateInstructorData(Instructor instructor)
        {
            bool result = true;
            if (instructor.Email != "")
            {
                if (!IsValidEmail(instructor.Email)) result = false;
            }
            return result;
        }
        public bool ValidateAddCourseData(Course course)
        {
            bool result = true;
            if (course.Name == "" || course.Code == "" || course.Credits.ToString() == "") result = false;
            if (!IsValidCredits(course.Credits.ToString())) result = false;
            return result;
        }
        public bool IsValidCredits(string creditsText)
        {
            return int.TryParse(creditsText, out _);
        }
        public bool ValidateEnrollment(Enrollment enrollment)
        {
            var duplicate = from e in dataContext.Enrollments
                            where enrollment.StudentsId == e.StudentsId && enrollment.CourseId == e.CourseId && enrollment.EnrollmentSemester==e.EnrollmentSemester
                            select e;
            if (duplicate.Count() > 0) return false;
            else return true;
        }
        public bool ValidateCourseInstructor(CourseInstructor courseinstructor)
        {
            var duplicate = from e in dataContext.CourseInstructors
                            where courseinstructor.InstructorId == e.InstructorId && courseinstructor.CourseId == e.CourseId && courseinstructor.Semester == e.Semester
                            select e;
            if (duplicate.Count() > 0) return false;
            else return true;
        }
    }
}
