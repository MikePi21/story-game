using System;
using System.Net;
using story_game_exercise.Context;
using story_game_exercise.Controllers.Commands;
using story_game_exercise.Helpers;
using story_game_exercise.Service.Interface;
using story_game_exercise.Translators;

namespace story_game_exercise.Service
{
    public class UserService : IUserService
    {
        public DataContext context;

        private ITranslator<User, VmUser> userTranslator;

        public UserService(DataContext context, ITranslator<User, VmUser> userTranslator)
        {
            this.context = context;
            this.userTranslator = userTranslator;
        }

        public VmUser Create(VmUserCreateCommand command)
        {
            User user = new User();
            user.Nickname = command.Nickname;
            user.Password = command.Password;

            context.Users.Add(user);
            context.SaveChanges();

            return userTranslator.Translate(user);
        }

        public void Delete(Guid id)
        {
            User user = Find(id);

            context.Users.Remove(user);
            context.SaveChanges();
        }

        public VmUser Get(Guid id)
        {
            User user = Find(id);

            return userTranslator.Translate(user);
        }

        public VmUser[] GetAll()
        {
            User[] users = context.Users.ToArray();

            VmUser[] vmUser = users.Select(userTranslator.Translate).ToArray();

            return vmUser;
        }

        public VmUser Update(VmUserUpdateCommand command)
        {
            User user = Find(command.Id);
            user.Id = command.Id;
            user.Nickname = command.Nickname;

            context.SaveChanges();

            return userTranslator.Translate(user);
        }

        public User Find(Guid id)
        {
            User? user = context.Users.Find(id);

            if (user == null) throw new HttpResponseException(HttpStatusCode.NotFound);

            return user;
        }
    }
}

