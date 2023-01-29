using System.Collections;
using ApiCollection.Data;
using ApiCollection.Entities;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

namespace ApiCollection.Controllers
{
    [ApiController]
    //[Route("api/[Controller]")]
    [Route("api/[Controller]")]
    public class UesrsController : ControllerBase
    {

        private readonly DataContext _context;

        public UesrsController(DataContext context)
        {
            _context = context;
        }

        [HttpGet]

        public async Task<ActionResult<IEnumerable<Users>>> GetUsers()
        {
            var users = await _context.Users.ToListAsync();
            return users;
        }
        [HttpGet("{id}")]
        public async Task<ActionResult<Users>> GetUserByid(int id)
        {
            var user = await _context.Users.FindAsync(id);
            return user;
        }
    }
}