using System;
namespace story_game_exercise.Controllers.Commands
{
    public class VmChapterCreateCommand
    {

        public string Title { get; set; }

        public string Description { get; set; }

        public Guid BookId { get; set; }
    }
}

