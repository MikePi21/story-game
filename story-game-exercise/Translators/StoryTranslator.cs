using System;
using story_game_exercise.Context;
using story_game_exercise.Controllers.Commands;

namespace story_game_exercise.Translators
{
    public class StoryTranslator : ITranslator<Story, VmStory>
    {
        public VmStory Translate(Story data)
        {
            VmStory result = new VmStory();

            result.Id = data.Id;
            result.Content = data.Content;
            result.ChapterId = data.ChapterId;

            return result;
        }
    }
}

