using Microsoft.AspNetCore.Mvc;
using SchoolManagement.Domain;
using SchoolManagement.Service.StudentService;
using System.Security.Cryptography;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace SchoolManagement.API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class StudentController : ControllerBase
    {
        private readonly IStudentService _StudentServices;

        public StudentController(IStudentService StudentServices)
        {
            _StudentServices = StudentServices;
        }

        // GET: api/<StudentController>
        [HttpGet]
        public IActionResult Get()
        {
            try
            {
                return Ok(_StudentServices.GetAllStudents());
            }
            catch (Exception ex)
            {
                return BadRequest(ex.Message);
            }
        }

        // POST api/<StudentController>
        [HttpPost]
        public IActionResult Post([FromBody] Student mdl)
        {
            try
            {
                var id = _StudentServices.AddStudent(mdl);
                return Ok(id);
            }
            catch (Exception ex)
            {
                return BadRequest(ex.Message);
            }
        }

    }
}
