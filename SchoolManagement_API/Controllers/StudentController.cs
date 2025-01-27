﻿using Microsoft.AspNetCore.Mvc;
using SchoolManagement.Domain;
using SchoolManagement.Service.StudentService;
using System.Security.Cryptography;


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
        /// <summary>
        /// Api to retrive list of students
        /// </summary>
        /// <returns>List of students registered</returns>
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
