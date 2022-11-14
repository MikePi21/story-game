using System;
using story_game_exercise.Controllers.Commands;

namespace story_game_exercise.Service.Interface
{
    public interface IUserService
    {
        void Delete(Guid id);

        VmUser[] GetAll();

        VmUser Get(Guid id);

        VmUser Create(VmUserCreateCommand command);

        VmUser Update(VmUserUpdateCommand command);
    }
}

