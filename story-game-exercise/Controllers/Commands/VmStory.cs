using System;
namespace story_game_exercise.Controllers.Commands
{
    public class VmStory
    {
        public Guid Id { get; set; }

        public string Content { get; set; }

        public Guid ChapterId { get; set; }
    }
}

