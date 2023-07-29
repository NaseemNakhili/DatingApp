

using System.Runtime.CompilerServices;
using API.Data;
using API.DTOs;
using API.Entities;
using API.Interfaces;
using AutoMapper;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

namespace API.Controllers
{
    [Authorize]


    public class UsersController : BaseApiController
    {

        public readonly IUserRepository _userRepository;
        public readonly IMapper _mapper;

        public UsersController(IUserRepository userRepository, IMapper mapper)
        {
            _mapper = mapper;
            _userRepository = userRepository;


        }
        [AllowAnonymous]
        [HttpGet]
        public async Task<ActionResult<IEnumerable<AppUser>>> GetUsers()
        {
            var users = await _userRepository.GetMembersAsync();

            return Ok(users);



        }

        [HttpGet("{username}")]
        public async Task<ActionResult<MemberDto>> GeUser(string userName)
        {
            return await _userRepository.GetMemberAsync(userName);



        }




    }
}