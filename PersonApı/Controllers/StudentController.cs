using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Caching.Memory;
using PersonApı.Entities;
using PersonApı.Repository;
using System.Net.Http.Headers;

namespace PersonApı.Controllers             //same with TeacherController
{
    [Route("api/[controller]")]
    [ApiController]
    public class StudentController : ControllerBase
    {
        private readonly IPersonRepository _personRepository;
        public StudentController(IPersonRepository personRepository)
        {
            _personRepository= personRepository;
        }

        [HttpGet]
        public IActionResult GetAllStudent()
        {
            return Ok(_personRepository.GetAllStudents());
        }

        [HttpGet("{level}")]
        public IActionResult GetStudentsByLevel(int level)
        {
            return Ok(_personRepository.GetStudentsByLevel(level));
        }

        [HttpPut("{id}")]
        public IActionResult UpdateStudentGPA(Student student,int id)
        {
            return Ok(_personRepository.UpdateStudentGPA(student, id));
        }

        [HttpDelete("{id}")]

        public IActionResult DeleteStudent(int id)
        {
            return Ok(_personRepository.DeleteStudent(id));
        }
    }
}
