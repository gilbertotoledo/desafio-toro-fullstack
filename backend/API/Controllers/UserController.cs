using Domain.DTO.User;
using Domain.Entities;
using Domain.Services.Interfaces;
using Microsoft.AspNetCore.Mvc;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace API.Controllers
{
    [Route("[controller]")]
    [ApiController]
    public class UserController : ControllerBase
    {
        private readonly IUserService _userService;

        public UserController(IUserService userService)
        {
            _userService = userService;
        }

        // GET: api/<UserController>
        [HttpGet]
        public async Task<IActionResult> Get()
        {
            return Ok(await _userService.GetAllAsync());
        }

        // GET api/<UserController>/5
        [HttpGet("{id}")]
        public async Task<IActionResult> Get(Guid id)
        {
            return Ok(await _userService.GetByIdAsync(id));
        }

        // POST api/<UserController>
        [HttpPost]
        public async Task<IActionResult> Post([FromBody] User user)
        {
            if(await _userService.CreateAsync(user))
            {
                return Ok();
            }

            return BadRequest();
        }

        // POST api/<UserController>/login
        [HttpPost("login")]
        public async Task<IActionResult> Login([FromBody] UserLogin userlogin)
        {
            var user = await _userService.GetByLoginAsync(userlogin.Username, userlogin.Password);
            if (user is not null)
            {
                return Ok(user);
            }

            return Unauthorized();
        }

        // POST api/<UserController>
        [HttpPost("mockData")]
        public async Task MockData()
        {
            await _userService.MockUserData();
        }
    }
}
