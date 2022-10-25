using System;
namespace story_game_exercise.Context
{
    public class User
    {
        public Guid Id { get; set; }

        public string Nickname { get; set; }

        public string Password { get; set; }
    }
}

