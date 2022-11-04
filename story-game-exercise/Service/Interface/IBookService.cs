using System;
using story_game_exercise.Controllers.Commands;

namespace story_game_exercise.Service.Interface
{
    public interface IBookService
    {
        void Delete(int id);

        VmBook[] GetAll();

        VmBook Get(int id);

        VmBook Create(VmBook comand);

        VmBook Update(VmBook comand);

    }
}