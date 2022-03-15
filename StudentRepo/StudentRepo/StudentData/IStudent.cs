using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace StudentRepo.StudentData
{
   public interface IStudent
    {
        public List<Student> GetStudents();
        public Student GetStudent(int id);
        public void Insert(Student student);
        public void Update(Student student);
        public void Delete(Student student);
        
    }
}
