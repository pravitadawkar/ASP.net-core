using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace WebApplication3.Model
{
    public class DemoTestRepository : IStudentRepository
    {
        public List<Student> DataSource()
        {

            return new List<Student>()
            {
                new Student()
                {
                    StudentId=01,
                    StudentName="Pravita",
                    Course="Comp sci"

                },
            new Student()
            {
                StudentId = 02,
                StudentName = "Shruti",
                Course = "Engineering"

            },
            new Student()
            {
                StudentId = 03,
                StudentName = "rutuja",
                Course = "Mcom"

            },
        };

        }
        public Student GetStuById(int StudentId)
        {
            return DataSource().FirstOrDefault(st => st.StudentId == StudentId);
            //return DataSource().First(st => st.StudentId == StudentId);
            //return DataSource().Single(st => st.StudentId == StudentId);
            //return DataSource().SingleOrDefault(st => st.StudentId == StudentId);

        }
        public List<Student> GetAllStudents()
        {
            return DataSource();
        }
    }
}
