using System;
using story_game_exercise.Controllers.Commands;
using story_game_exercise.Service.Interface;

namespace story_game_exercise.Service
{
    public class ChapterService : IChapterService
    {
        public VmChapter[] GetChaptersByBookId(Guid bookId)
        {
            throw new NotImplementedException();
        }
    }
}

