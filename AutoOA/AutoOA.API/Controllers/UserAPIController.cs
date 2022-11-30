using AutoOA.Core;
using AutoOA.Repository.Dto.UserDto;
using AutoOA.Repository.Repositories;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

namespace AutoOA.API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class UserAPIController : ControllerBase
    {
        private readonly ILogger<UserAPIController> _logger;
        private readonly UsersRepository Context;

        public UserAPIController(ILogger<UserAPIController> logger, UsersRepository context)
        {
            _logger = logger;
            Context = context;
        }

        [HttpGet]
        public UsersRepository GetUsersRepository()
        {
            return Context;
        }

        [HttpGet("GetHui")]
        public async Task<IEnumerable<UserReadDto>> GetListAsync()
        {
            return await Context.GetListAsync();
        }
        

    }
}
