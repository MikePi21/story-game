using System;
using story_game_exercise.Context;
using story_game_exercise.Controllers.Commands;

namespace story_game_exercise.Translators
{
    public class BookTranslator : ITranslator<Book, VmBook>
    {
        public VmBook Translate(Book data)
        {
            VmBook result = new VmBook();

            result.Id = data.Id;
            result.Title = data.Title;
            result.Description = data.Description;
            result.AuthorId = data.AuthorId;

            return result;
        }
    }
}

