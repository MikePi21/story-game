using System;
using story_game_exercise.Context;
using story_game_exercise.Controllers.Commands;

namespace story_game_exercise.Translators
{
    public class ChapterTranslator : ITranslator<Chapter, VmChapter>
    {
        public VmChapter Translate(Chapter data)
        {
            VmChapter result = new VmChapter();

            result.Id = data.Id;
            result.Title = data.Title;
            result.Description = data.Description;
            result.BookId = data.BookId;

            return result;
        }
    }
}

