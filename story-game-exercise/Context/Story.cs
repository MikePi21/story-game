using System;
namespace story_game_exercise.Context
{
    public class Story
    {
        public Guid Id { get; set; }

        public string Content { get; set; }

        public Guid ChapterId { get; set; }

    }
}

