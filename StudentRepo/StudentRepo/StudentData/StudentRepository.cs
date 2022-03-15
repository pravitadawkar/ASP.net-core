using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using StudentRepo.DataBase;

namespace StudentRepo.StudentData
{
    public class StudentRepository :IStudent
    {
        DatabaseContext _context;
        public StudentRepository(DatabaseContext context)
        {
            _context = context;
        }
        public List<Student> GetStudents()
        {
            return _context.Students.ToList();
        }
        public Student GetStudent(int id)
        {
            return _context.Students.FirstOrDefault(x => x.Id == id);

        }
        public void Insert(Student student)
        {
            _context.Add(student);
            _context.SaveChanges();
        }
        public void Update(Student student)
        {
            _context.Update(student);
            _context.SaveChanges();

        }
        public void Delete(Student student)
        {
            _context.Remove(student);
            _context.SaveChanges();

        }
    }
}
