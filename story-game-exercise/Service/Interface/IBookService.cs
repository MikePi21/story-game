using System;
using story_game_exercise.Controllers.Commands;

namespace story_game_exercise.Service.Interface
{
    public interface IBookService
    {
        void Delete(Guid id);

        VmBook[] GetAll();

        VmBook Get(Guid id);

        VmBook Create(VmBookCreateCommand command);

        VmBook Update(VmBookUpdateCommand command);
    }
}