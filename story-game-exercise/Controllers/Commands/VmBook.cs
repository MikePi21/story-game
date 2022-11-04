using System;
namespace story_game_exercise.Controllers.Commands
{
    public class VmBook
    {
        public Guid Id { get; set; }

        public string Title { get; set; }

        public string Description { get; set; }

        public Guid AuthorId { get; set; }
    }
}

