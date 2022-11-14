using System;
using story_game_exercise.Controllers.Commands;

namespace story_game_exercise.Service.Interface
{
    public interface IChapterService
    {
        VmChapter[] GetChaptersByBookId(Guid bookId);
    }
}

