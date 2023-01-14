using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Routing;
using PersonApı.Entities;
using PersonApı.Repository;

namespace PersonApı.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class TeacherController : ControllerBase
    {
        private readonly IPersonRepository _personRepository;               //Irepository

        public TeacherController(IPersonRepository personRepository)        // Ctor- working methods onto the repositories / repository connection
        {
            _personRepository = personRepository;
        }

        

        [HttpGet]
        public IActionResult GetAllTeacher()                        // go to IReporsitory's methods with using obj of Irepository
        {
            return Ok(_personRepository.GetAllTeachers());
        }

        

        [HttpGet("{branch}")]                                       // have to send branch (parameter)

        public IActionResult GetTeacherByBranch(string branch)
        {
            return Ok(_personRepository.GetTeachersByBranch(branch));       // go to IReporsitory's methods with using obj of Irepository and send param.
        }

        [HttpPut("{id}")]                                           // have to send id

        public IActionResult UpdateTeacherSalary(Teacher teacher,int id)
        {
            return Ok(_personRepository.UpdateTeacherSalary( teacher,id));
        }

        [HttpDelete("{id}")]                                
        public IActionResult DeleteTeacher(int id)
        {
            return Ok(_personRepository.DeleteTeacher(id));
        }

        public IActionResult AddTeacher(Teacher teacher)
        {
            return Ok(_personRepository.AddTeacher(teacher));
        }
    }
}
