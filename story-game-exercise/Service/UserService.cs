using System;
using story_game_exercise.Context;
using story_game_exercise.Controllers.Commands;
using story_game_exercise.Helpers;
using story_game_exercise.Service.Interface;

namespace story_game_exercise.Service
{
    public class UserService : IUserService
    {
        public DataContext context;

        public UserService(DataContext context)
        {
            this.context = context;
        }

        public VmUser Create(VmUserCreateCommand command)
        {
            User user = new User();
            user.Nickname = command.Nickname;
            user.Password = command.Password;

            context.Users.Add(user);
            context.SaveChanges();


            VmUser vmUser = new VmUser();
            vmUser.Id = user.Id;
            vmUser.Nickname = user.Nickname;

            return vmUser;
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

