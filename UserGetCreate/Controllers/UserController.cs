using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using System.ComponentModel.DataAnnotations;
using UserGetCreate.Models;

namespace UserGetCreate.Controllers
{
    [ApiController]
    [Route("api/users")]
    public class PersonasController : ControllerBase
    {
        private readonly ApplicationDbContext context;

        public PersonasController(ApplicationDbContext context)
        {
            this.context = context;
        }

        [HttpGet]
        public async Task<ActionResult<List<Users>>> Get()
        {
            return await context.Users.ToListAsync();
        }

        [HttpPost]
        public async Task<ActionResult<int>> Post(Users users)
        {
            context.Add(users);
            await context.SaveChangesAsync();
            return users.Id;
        }
    }
}
