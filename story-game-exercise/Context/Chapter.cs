using System;
namespace story_game_exercise.Context
{
    public class Chapter
    {
        public Guid Id { get; set; }

        public string Title { get; set; }

        public string Description { get; set; }

        public Guid BookId { get; set; }
    }
}

