using System;
namespace story_game_exercise.Controllers.Commands
{
    public class VmStoryCreateCommand
    {
        public string Content { get; set; }

        public Guid ChapterId { get; set; }
    }
}

