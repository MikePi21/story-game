using System;
using story_game_exercise.Controllers.Commands;
using story_game_exercise.Service.Interface;

namespace story_game_exercise.Service
{
    public class UserService : IUserService
    {
        public UserService()
        {

        }

        public VmUser Create(VmUser command)
        {
            throw new NotImplementedException();
        }

        public void Delete(int id)
        {
            throw new NotImplementedException();
        }

        public VmUser Get(int id)
        {
            throw new NotImplementedException();
        }

        public VmUser[] GetAll()
        {
            throw new NotImplementedException();
        }

        public VmUser Update(VmUser command)
        {
            throw new NotImplementedException();
        }
    }
}

