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

        public UsersController(IUserService userService)
        {
            this.userService = userService;
        }

        [HttpPost]
        [ProducesResponseType(StatusCodes.Status200OK, Type = typeof(VmUser))]
        public VmUser Create(VmUserCreateCommand command)
        {
            return userService.Create(command);
        }

        [HttpDelete("{id:int}")]
        [ProducesResponseType(StatusCodes.Status200OK)]
        public void Delete(Guid id)
        {
            userService.Delete(id);
        }

        [HttpGet("{id:int}")]
        [ProducesResponseType(StatusCodes.Status200OK, Type = typeof(VmUser))]
        [ProducesResponseType(StatusCodes.Status404NotFound)]
        public VmUser Get(Guid id)
        {
            return userService.Get(id);
        }

        [HttpGet]
        [ProducesResponseType(StatusCodes.Status200OK, Type = typeof(VmUser))]
        public VmUser[] GetAll()
        {
            return userService.GetAll();
        }

        [HttpPatch]
        [ProducesResponseType(StatusCodes.Status200OK, Type = typeof(VmUser))]
        public VmUser Update(VmUserUpdateCommand command )
        {
            return userService.Update(command);
        }
    }

}

