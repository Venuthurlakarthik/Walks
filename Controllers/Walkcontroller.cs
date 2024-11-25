using Microsoft.AspNetCore.Mvc;
using Walks.Controllers.DomainModels;
using System.Collections.Generic;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;


namespace Walks.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class Walkcontroller : ControllerBase
    {
//        private readonly Walkscontext _context;

//        public Walkcontroller(Walkscontext context)
//        {
//            _context = context;
//        }

//        [HttpGet]
//        [Route("teachers")]
//        public async Task<IActionResult> GetTeachers()
//        {
//            var teachers = await _context.teachers.ToListAsync();
//            return Ok(teachers); 
//        }
    }
}
