using System;
using System.Net;
using story_game_exercise.Context;
using story_game_exercise.Controllers.Commands;
using story_game_exercise.Helpers;
using story_game_exercise.Service.Interface;
using story_game_exercise.Translators;

namespace story_game_exercise.Service
{
    public class BookService : IBookService
    {
        private readonly DataContext context;

        private ITranslator<Book, VmBook> bookTranslator;

        public BookService(DataContext context, ITranslator<Book, VmBook> bookTranslator)
        {
            this.context = context;
            this.bookTranslator = bookTranslator;
        }

        public VmBook Create(VmBookCreateCommand command)
        {
            Book book = new Book();
            book.Title = command.Title;
            book.Description = command.Description;
            book.AuthorId = command.AuthorId;

            context.Books.Add(book);
            context.SaveChanges();

            return bookTranslator.Translate(book);
        }

        public void Delete(Guid id)
        {
            Book book = Find(id);

            context.Books.Remove(book);

            context.SaveChanges();

        }

        public VmBook Get(Guid id)
        {
            Book book = Find(id);

            return bookTranslator.Translate(book);
        }

        public VmBook[] GetAll()
        {
            Book[] books = context.Books.ToArray();

            VmBook[] vmBooks = books.Select(bookTranslator.Translate).ToArray();

            return vmBooks;
        }

        public VmBook Update(VmBookUpdateCommand comand)
        {
            Book book = Find(comand.Id);

            book.Title = comand.Title;
            book.Description = comand.Description;

            context.SaveChanges();

            return bookTranslator.Translate(book);

        }

        public Book Find(Guid id)
        {
            Book? book = context.Books.Find(id);

            if(book == null) throw new HttpResponseException(HttpStatusCode.NotFound);

            return book;
        }
    }
}

