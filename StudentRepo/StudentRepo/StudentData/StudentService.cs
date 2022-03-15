using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace StudentRepo.StudentData
{
    public class StudentService
    {
        IStudent _stdrepo;
        public StudentService(IStudent stdrepo)
        {
            _stdrepo = stdrepo;
        }
        public List<Student> GetStudents()
        {
           var student =_stdrepo.GetStudents();
            return student;
        }
        public Student GetStudent(int id)
        {
            return _stdrepo.GetStudent(id);
        }
        public void Insert(Student student)
        {
            _stdrepo.Insert(student);
        }
        public void Update(Student student)
        {
            _stdrepo.Update(student);
        }
        public void Delete(Student student)
        {
            _stdrepo.Delete(student);
        }
    }
}
