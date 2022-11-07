using story_game_exercise.Context;
using story_game_exercise.Controllers.Commands;

namespace story_game_exercise.Translators
{
    public class UserTranslator : ITranslator<User, VmUser>
    {
        public VmUser Translate(User data)
        {
            VmUser result = new VmUser();

            result.Id = data.Id;
            result.Nickname = data.Nickname;

            return result;
        }
    }
}

