using System;
using System.Net;
using story_game_exercise.Context;
using story_game_exercise.Controllers.Commands;
using story_game_exercise.Helpers;
using story_game_exercise.Service.Interface;
using story_game_exercise.Translators;

namespace story_game_exercise.Service
{
    public class StoryService : IStoryService
    {
        private readonly DataContext context;

        private ITranslator<Story, VmStory> storyTranslator;

        public StoryService(DataContext context, ITranslator<Story, VmStory> storyTranslator)
        {
            this.context = context;
            this.storyTranslator = storyTranslator;
        }

        public VmStory Create(VmStoryCreateCommand command)
        {
            Story story = new Story();
            story.Content = command.Content;
            story.ChapterId = command.ChapterId;

            context.Stories.Add(story);
            context.SaveChanges();

            return storyTranslator.Translate(story);
        }

        public void Delete(Guid id)
        {
            Story story = Find(id);

            context.Stories.Remove(story);
            context.SaveChanges();
        }

        public VmStory Get(Guid id)
        {
            Story story = Find(id);

            return storyTranslator.Translate(story);
        }

        public VmStory[] GetAll()
        {
            Story[] stories = context.Stories.ToArray();

            VmStory[] vmStories = stories.Select(storyTranslator.Translate).ToArray();

            return vmStories;
        }

        public VmStory Update(VmStoryUpdateCommand command)
        {
            Story story = Find(command.Id);

            story.Id = command.Id;
            story.Content = command.Content;
            story.ChapterId = command.ChapterId;

            context.SaveChanges();

            return storyTranslator.Translate(story);

        }

        public Story Find(Guid id)
        {
            Story? story = context.Stories.Find(id);

            if (story == null) throw new HttpResponseException(HttpStatusCode.NotFound);

            return story;
        }
    }
}

