using AutoMapper;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using MobilityRentApp_Backend.Controllers.Base;
using MobilityRentApp_Backend.Data.Repositories;
using MobilityRentApp_Backend.Model.Dtos.User;
using MobilityRentApp_Backend.Model.Entities;

namespace MobilityRentApp_Backend.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class UserController : CustomControllerBase<User>
    {
       private const string getUserRouteName = "getUser";
        public UserController(IUserRepository repository, IMapper mapper) : base(repository, mapper)
        {
        }

        [HttpGet]
        public async Task<ActionResult<List<UserDto>>> Get()
        {
            return await Get<UserDto>();
        }

        [HttpGet("{id:int}", Name = getUserRouteName)]
        public async Task<ActionResult<UserDto>> Get(int id)
        {
            return await Get<UserDto>(id);
        }

        [HttpPost]
        public async Task<ActionResult<UserDto>> Post([FromBody] CreateUserDto createUserDto)
        {
            return await Post<CreateUserDto, UserDto>(createUserDto, getUserRouteName);
        }

        [HttpPut]
        public async Task<ActionResult> Put([FromBody] UpdateUserDto updateUserDto)
        {
            return await Put<UpdateUserDto>(updateUserDto);
        }

        [HttpDelete("{id:int}")]
        public async Task<ActionResult> Delete(int id)
        {
            return await base.Delete(id);
        }
    }
}