using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Remoting.Contexts;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Serialization;
namespace UniversityManager.DataFolder
{
    public class DataManager
    {
        private readonly ValidationManager validationManager = new ValidationManager();
        private readonly UniversityDataContextDataContext _dataContext;
        public static string connection = "Data Source=DESKTOP-FOT4SJ9;Initial Catalog=ProgrammingTutorialDB;Integrated Security=True;Encrypt=True;TrustServerCertificate=True";
        public DataManager()
        {
            _dataContext = new UniversityDataContextDataContext(connection);
        }
        public void AddStudent(Student student)
        {
            _dataContext.Students.InsertOnSubmit(student);
            _dataContext.SubmitChanges();
        }
        public void AddInstructor(Instructor instructor)
        {
            _dataContext.Instructors.InsertOnSubmit(instructor);
            _dataContext.SubmitChanges();
        }
        public void AddCourse(Course course)
        {
            _dataContext.Courses.InsertOnSubmit(course);
            _dataContext.SubmitChanges();
        }
        public void AddEnrollment(string studentname, string coursename, string semester)
        {
            string[] name = studentname.Split(' ');
            string firstname = name[0];
            string lastname = name[1];
            var student = _dataContext.Students.FirstOrDefault(s => s.FirstName == firstname && s.LastName == lastname);

            var course = _dataContext.Courses.FirstOrDefault(c => c.Name == coursename);
            Enrollment enrollment = new Enrollment
            {
                StudentsId = student.Id,
                CourseId = course.Id,
                EnrollmentSemester = semester,
            };
            if (validationManager.ValidateEnrollment(enrollment))
            {
                _dataContext.Enrollments.InsertOnSubmit(enrollment);
                _dataContext.SubmitChanges();
            }
        }
        public void AddCourseInstructor(string instructorname, string coursename, string semester)
        {
            string[] name = instructorname.Split(' ');
            string firstname = name[0];
            string lastname = name[1];
            var instructor = _dataContext.Instructors.FirstOrDefault(s => s.FirstName == firstname && s.LastName == lastname);

            var course = _dataContext.Courses.FirstOrDefault(c => c.Name == coursename);
            CourseInstructor courseInstructor = new CourseInstructor
            {
                InstructorId = instructor.Id,
                CourseId = course.Id,
                Semester = semester,
            };
            if (validationManager.ValidateCourseInstructor(courseInstructor))
            {
                _dataContext.CourseInstructors.InsertOnSubmit(courseInstructor);
                _dataContext.SubmitChanges();
            }
        }
        public void DeleteStudent(int studentId)
        {
            Student student = _dataContext.Students.FirstOrDefault(x => x.Id == studentId);
            if (student != null)
            {
                _dataContext.Students.DeleteOnSubmit(student);
                _dataContext.SubmitChanges();
            }
        }
        public void DeleteInstructor(int instructorId)
        {
            Instructor instructor = _dataContext.Instructors.FirstOrDefault(x => x.Id == instructorId);
            if (instructor != null)
            {
                _dataContext.Instructors.DeleteOnSubmit(instructor);
                _dataContext.SubmitChanges();
            }
        }
        public void DeleteCourse(int courseId)
        {
            Course course = _dataContext.Courses.FirstOrDefault(x => x.Id == courseId);
            if (course != null)
            {
                _dataContext.Courses.DeleteOnSubmit(course);
                _dataContext.SubmitChanges();
            }
        }
        public void DeleteEnrollment(int enrollmentId)
        {
            Enrollment enrollment = _dataContext.Enrollments.FirstOrDefault(x => x.Id == enrollmentId);
            if (enrollment != null)
            {
                _dataContext.Enrollments.DeleteOnSubmit(enrollment);
                _dataContext.SubmitChanges();
            }
        }
        public void DeleteCourseInstructor(int CourseInstructorId)
        {
            CourseInstructor courseInstructor = _dataContext.CourseInstructors.FirstOrDefault(x => x.Id == CourseInstructorId);
            if (courseInstructor != null)
            {
                _dataContext.CourseInstructors.DeleteOnSubmit(courseInstructor);
                _dataContext.SubmitChanges();
            }
        }
        public void UpdateStudent(Student student, int id)
        {
            Student u = _dataContext.Students.FirstOrDefault(x => x.Id == id);
            if (student.FirstName != "") u.FirstName = student.FirstName;
            if (student.LastName != "") u.LastName = student.LastName;
            if (student.Email != "") u.Email = student.Email;
            _dataContext.SubmitChanges();
        }
        public void UpdateInstructor(Instructor instructor, int id)
        {
            Instructor u = _dataContext.Instructors.FirstOrDefault(x => x.Id == id);
            if (instructor.FirstName != "") u.FirstName = instructor.FirstName;
            if (instructor.LastName != "") u.LastName = instructor.LastName;
            if (instructor.Email != "") u.Email = instructor.Email;
            _dataContext.SubmitChanges();
        }
        public void UpdateCourse(Course course, int id)
        {
            Course u = _dataContext.Courses.FirstOrDefault(x => x.Id == id);
            if (course.Name != "") u.Name = course.Name;
            if (course.Code != "") u.Code = course.Code;
            if (course.Credits != 0) u.Credits = course.Credits;
            _dataContext.SubmitChanges();
        }
        public void UpdateEnrollment(string studentname, string coursename, string semester, int id)
        {
            string[] name = studentname.Split(' ');
            string firstname = name[0];
            string lastname = name[1];
            var student = _dataContext.Students.FirstOrDefault(s => s.FirstName == firstname && s.LastName == lastname);

            var course = _dataContext.Courses.FirstOrDefault(c => c.Name == coursename);
            Enrollment enrollment = new Enrollment
            {
                StudentsId = student.Id,
                CourseId = course.Id,
                EnrollmentSemester = semester,
            };
            Enrollment u = _dataContext.Enrollments.FirstOrDefault(x => x.Id == id);
            if (enrollment.StudentsId != 0) u.StudentsId = enrollment.StudentsId;
            if (enrollment.CourseId != 0) u.CourseId = enrollment.CourseId;
            if (enrollment.EnrollmentSemester != "") u.EnrollmentSemester = enrollment.EnrollmentSemester;
            _dataContext.SubmitChanges();
        }
        public void UpdateCourseInstructor(string instructorname, string coursename, string semester, int id)
        {
            string[] name = instructorname.Split(' ');
            string firstname = name[0];
            string lastname = name[1];
            var instructor = _dataContext.Instructors.FirstOrDefault(s => s.FirstName == firstname && s.LastName == lastname);

            var course = _dataContext.Courses.FirstOrDefault(c => c.Name == coursename);
            CourseInstructor courseInstructor = new CourseInstructor
            {
                InstructorId = instructor.Id,
                CourseId = course.Id,
                Semester = semester,
            };
            CourseInstructor u = _dataContext.CourseInstructors.FirstOrDefault(x => x.Id == id);
            if (courseInstructor.InstructorId != 0) u.InstructorId = courseInstructor.InstructorId;
            if (courseInstructor.CourseId != 0) u.CourseId = courseInstructor.CourseId;
            if (courseInstructor.Semester != "") u.Semester = courseInstructor.Semester;
            _dataContext.SubmitChanges();
        }
        public List<StudentDisplay> GetStudentDisplays()
        {
            var students = from s in _dataContext.Students
                           select new StudentDisplay
                           {
                               Id = s.Id,
                               FullName = s.FirstName + " " + s.LastName
                           };

            return students.ToList();
        }
        public List<InstructorDisplay> GetInstructorDisplays()
        {
            var instructors = from i in _dataContext.Instructors
                              select new InstructorDisplay
                              {
                                  Id = i.Id,
                                  FullName = i.FirstName + " " + i.LastName
                              };

            return instructors.ToList();
        }
        public List<Course> GetCourseDisplays()
        {
            var courses = from s in _dataContext.Courses
                          select s;

            return courses.ToList();
        }
        public List<EnrollmentDisplay> GetEnrollments()
        {
            var enrollments = from e in _dataContext.Enrollments
                              join s in _dataContext.Students on e.StudentsId equals s.Id
                              join c in _dataContext.Courses on e.CourseId equals c.Id
                              select new EnrollmentDisplay
                              {
                                  Id = e.Id,
                                  StudentName = s.FirstName + " " + s.LastName,
                                  CourseName = c.Name,
                                  Semester = e.EnrollmentSemester,
                              };
            return enrollments.ToList();
        }
        public List<CourseInstructorDisplay> GetCourseInstructors()
        {
            var CourseInstructors = from e in _dataContext.CourseInstructors
                                    join s in _dataContext.Instructors on e.InstructorId equals s.Id
                                    join c in _dataContext.Courses on e.CourseId equals c.Id
                                    join en in _dataContext.Enrollments on new { CourseId = c.Id, e.Semester }
                              equals new { en.CourseId, Semester = en.EnrollmentSemester } into count
                                    select new CourseInstructorDisplay
                                    {
                                        Id = e.Id,
                                        InstructorName = s.FirstName + " " + s.LastName,
                                        CourseName = c.Name,
                                        Semester = e.Semester,
                                        StudentCount = count.Count()
                                    };
            return CourseInstructors.ToList();
        }
        public List<EnrollmentDisplay> GetFilteredEnrollments(string semester, string studentName = null, string courseName = null)
        {
            var query = from e in _dataContext.Enrollments
                        join s in _dataContext.Students on e.StudentsId equals s.Id
                        join c in _dataContext.Courses on e.CourseId equals c.Id
                        select new EnrollmentDisplay
                        {
                            Id = e.Id,
                            StudentName = s.FirstName + " " + s.LastName,
                            CourseName = c.Name,
                            Semester = e.EnrollmentSemester
                        };

            // Apply filters if they are provided
            if (!string.IsNullOrEmpty(studentName))
            {
                query = query.Where(ed => ed.StudentName.Contains(studentName));
            }

            if (!string.IsNullOrEmpty(courseName))
            {
                query = query.Where(ed => ed.CourseName.Contains(courseName));
            }
            query = query.Where(ed => ed.Semester.Contains(semester));
            return query.ToList();
        }
        public bool Check(Account account)
        {
            var search = from a in _dataContext.Accounts
                         where a.Username == account.Username && a.Password == account.Password 
                         select a ;
            if (search.Count() != 0) return true;
            return false;
        }
    }
}
