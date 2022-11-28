using System;
using story_game_exercise.Controllers.Commands;

namespace story_game_exercise.Service.Interface
{
    public interface IStoryService
    {
        void Delete(Guid id);

        VmStory[] GetAll();

        VmStory Get(Guid id);

        VmStory Create(VmStoryCreateCommand command);

        VmStory Update(VmStoryUpdateCommand command);

        VmStory[] GetAllByChapterId(Guid chapterId);
    }
}

