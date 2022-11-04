using System;
using Microsoft.AspNetCore.Mvc;
using story_game_exercise.Controllers.Commands;
using story_game_exercise.Service;
using story_game_exercise.Service.Interface;

namespace story_game_exercise.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class UsersController : ControllerBase
    {
        IUserService userService;

        public UsersController()
        {
            userService = new UserService();
        }

        [HttpPost]
        [ProducesResponseType(StatusCodes.Status200OK, Type = typeof(VmUser))]
        public VmUser Create(VmUser command)
        {
            return userService.Create(command);
        }

        [HttpDelete("{id:int}")]
        [ProducesResponseType(StatusCodes.Status200OK)]
        public void Delete(int id)
        {
            userService.Delete(id);
        }

        [HttpGet("{id:int}")]
        [ProducesResponseType(StatusCodes.Status200OK, Type = typeof(VmUser))]
        [ProducesResponseType(StatusCodes.Status404NotFound)]
        public VmUser Get(Guid id)
        {
            return new VmUser();
        }

        [HttpGet]
        [ProducesResponseType(StatusCodes.Status200OK, Type = typeof(VmUser))]
        public VmUser[] GetAll()
        {
            return userService.GetAll();
        }

        [HttpPatch]
        [ProducesResponseType(StatusCodes.Status200OK, Type = typeof(VmUser))]
        public VmUser Update(VmUser command )
        {
            return userService.Update(command);
        }
    }

}

