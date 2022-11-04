using System;
namespace story_game_exercise.Controllers.Commands
{
    public class VmUser
    {
        public Guid Id { get; set; }

        public string Nickname { get; set; }

        public string Password { get; set; }
    }
}

