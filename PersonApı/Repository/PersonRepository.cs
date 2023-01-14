using PersonApı.Entities;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;

namespace PersonApı.Repository                  //define same methods and apply
{
    public class PersonRepository : IPersonRepository       //ınheritance
    {
        private readonly AppDbContext _context;             //Context


        public PersonRepository(AppDbContext context)
        {
            _context = context;                             //context
        }

        public Student AddStudent(Student student)
        {
            var add = _context.Students.Add(student).ToString();
            _context.SaveChanges();
            return student;



        }

        public Teacher AddTeacher(Teacher teacher)
        {
            var add= _context.Teachers.Add(teacher).ToString();
            _context.SaveChanges();
            return teacher;
        }

        public int DeleteStudent(int id)
        {
            var deleted = _context.Students.FirstOrDefault(p => p.Id == id);
            _context.Students.Remove(deleted);
            return _context.SaveChanges();
        }

        public int DeleteTeacher(int id)
        {
            var deleted = _context.Teachers.FirstOrDefault(p => p.Id == id);
            _context.Teachers.Remove(deleted);
            return _context.SaveChanges();
        }

        public List<Student> GetAllStudents()
        {
            var list = _context.Students.ToList();
            return list;
        }

        public List<Teacher> GetAllTeachers()
        {
            return _context.Teachers.ToList();
        }

        public List<Student> GetStudentsByLevel(int level)
        {
            var student = _context.Students.Where(s => s.Level == level);
            return student.ToList();
        }

        public List<Teacher> GetTeachersByBranch(string branch)
        {
            var teacher = _context.Teachers.Where(t => t.Branche == branch);
            return teacher.ToList();
        }

        public int UpdateStudentGPA(Student student, int id)                    //updating  
        {
            var studentGpa = _context.Students.FirstOrDefault(s => s.Id==id);
            studentGpa.GPA = student.GPA;

            return _context.SaveChanges();
        }

        public int UpdateTeacherSalary(Teacher teacher, int id)
        {
            var teacherUpdated = _context.Teachers.FirstOrDefault(t => t.Id == id);
            teacherUpdated.Salary = teacher.Salary;
            return _context.SaveChanges();
        }

    }
}
