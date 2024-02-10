using Microsoft.AspNetCore.Mvc;
using AutoMapper;
using Microsoft.AspNetCore.Http;
using BookServiceWEBAPI.Entities;
using BookServiceWEBAPI.Service;
using BookServiceWEBAPI.Models;
using BookServiceWEBAPI.DTO;
using Microsoft.AspNetCore.Authorization;
using Microsoft.IdentityModel.Tokens;
using System.IdentityModel.Tokens.Jwt;
using System.Security.Claims;
using System.Text;
using log4net;
using System.Runtime.ConstrainedExecution;

namespace BookServiceWEBAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class UserController
    {
        private readonly IUserService userService;
        private readonly IMapper _mapper;
        private readonly IConfiguration configuration;
        private ILogger<UserController> logger;

        public UserController(IUserService userService, IMapper mapper, IConfiguration configuration, ILogger<UserController> logger)
        {
            this.userService = userService;
            _mapper = mapper;
            this.configuration = configuration;
            this.logger = logger;
        }
        [HttpGet, Route("GetAllUsers")]
        [Authorize(Roles = "Admin")]
        public IActionResult GetAllUsers()
        {
            try
            {
                List<User> users = userService.GetAllUsers();
                List<UserDTO> usersDTO = _mapper.Map<List<UserDTO>>(users);
                return Ok(users);

            }
            catch (Exception ex)
            {
                logger.LogError(ex.Message);

                return StatusCode(500,ex.Message);
            }
        }

        private IActionResult StatusCode(int v, string message)
        {
            throw new NotImplementedException();
        }

        private IActionResult Ok(List<User> users)
        {
            throw new NotImplementedException();
        }

        [HttpPost, Route("Register")]
        [AllowAnonymous] //access the endpoint any any user with out login
        public IActionResult AddUser(User user)
        {
            try
            {
                User _user = _mapper.Map<User>(user);
                userService.CreateUser(_user);
                return Statuscode(200, _user);


            }
            catch (Exception ex)
            {
                logger.LogError(ex.Message);
                return StatusCode(500, ex.Message);
            }
        }

        private IActionResult Statuscode(int v, User user)
        {
            throw new NotImplementedException();
        }
    }
}
