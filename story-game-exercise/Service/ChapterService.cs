using System;
using System.Net;
using story_game_exercise.Context;
using story_game_exercise.Controllers.Commands;
using story_game_exercise.Helpers;
using story_game_exercise.Service.Interface;
using story_game_exercise.Translators;

namespace story_game_exercise.Service
{
    public class ChapterService : IChapterService
    {
        private readonly DataContext context;

        private ITranslator<Chapter, VmChapter> chapterTranslator;

        public ChapterService(DataContext context, ITranslator<Chapter, VmChapter> chapterTranslator)
        {
            this.context = context;
            this.chapterTranslator = chapterTranslator;
        }

        public VmChapter Create(VmChapterCreateCommand command)
        {
            Chapter chapter = new Chapter();
            chapter.Title = command.Title;
            chapter.Description = command.Description;
            chapter.BookId = command.BookId;

            context.Chapters.Add(chapter);
            context.SaveChanges();

            return chapterTranslator.Translate(chapter);
        }

        public void Delete(Guid id)
        {
            Chapter chapter = Find(id);

            context.Chapters.Remove(chapter);
            context.SaveChanges();
        }

        public VmChapter Get(Guid id)
        {
            Chapter chapter = Find(id);

            return chapterTranslator.Translate(chapter);
        }

        public VmChapter[] GetAll()
        {
            Chapter[] chapters = context.Chapters.ToArray();

            VmChapter[] vmChapters = chapters.Select(chapterTranslator.Translate).ToArray();

            return vmChapters;
        }

        public VmChapter[] GetChaptersByBookId(Guid bookId)
        {
            Chapter[] chapters = context.Chapters.Where(chapter => chapter.BookId == bookId).ToArray();

            VmChapter[] vmChapters = chapters.Select(chapterTranslator.Translate).ToArray();

            return vmChapters;
        }

        public VmChapter Update(VmChapterUpdateCommand command)
        {
            Chapter chapter = Find(command.Id);

            chapter.Id = command.Id;
            chapter.Title = command.Title;
            chapter.Description = command.Description;
            chapter.BookId = command.BookId;

            context.SaveChanges();

            return chapterTranslator.Translate(chapter);

        }

        public Chapter Find(Guid id)
        {
            Chapter? chapter = context.Chapters.Find(id);

            if (chapter == null) throw new HttpResponseException(HttpStatusCode.NotFound);

            return chapter;
        }
    }
}

