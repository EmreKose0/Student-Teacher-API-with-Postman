using Microsoft.AspNetCore.Mvc.ModelBinding;
using PersonApı.Entities;
using System.Collections.Generic;

namespace PersonApı.Repository
{
    public interface IPersonRepository     //Defined The Methods with return Type
    {
        List<Teacher> GetAllTeachers();     //List Teachers
        List<Student> GetAllStudents();     //List Students

        List<Teacher> GetTeachersByBranch(string branch);   //Searching by Branch

        List<Student> GetStudentsByLevel(int level);        //Searching by Level

        int UpdateTeacherSalary(Teacher teacher, int id);   //Update Salary of Teacher (need teacher obj and id)

        int UpdateStudentGPA(Student student, int id);      //Update GPA of Student  (need student obj and id)

        int DeleteTeacher(int id);                          //Delete Teacher by id

        int DeleteStudent(int id);                         //Delete Student by id

        Student AddStudent(Student student);
        Teacher AddTeacher(Teacher teacher);


    }
}
