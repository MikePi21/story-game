using System;
namespace story_game_exercise.Controllers.Commands
{
    public class VmBookCreateCommand
    {
        public string Title { get; set; }

        public string Description { get; set; }

        public Guid AuthorId { get; set; }
    }
}

