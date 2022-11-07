using System;
using Microsoft.AspNetCore.Mvc;
using story_game_exercise.Controllers.Commands;
using story_game_exercise.Service;
using story_game_exercise.Service.Interface;

namespace story_game_exercise.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class BooksController : ControllerBase
    {
        IBookService bookService;

        public BooksController()
        {
            bookService = new BookService();
        }

        [HttpPost]
        [ProducesResponseType(StatusCodes.Status200OK, Type = typeof(VmBookCreateCommand))]
        public VmBook Create(VmBookCreateCommand command)
        {
            return bookService.Create(command);
        }

        [HttpDelete("{id:int}")]
        [ProducesResponseType(StatusCodes.Status200OK)]
        public void Delete(int id)
        {
            bookService.Delete(id);
        }

        [HttpGet("{id:int}")]
        [ProducesResponseType(StatusCodes.Status200OK, Type = typeof(VmBook))]
        [ProducesResponseType(StatusCodes.Status404NotFound)]
        public VmBook Get(Guid guid)
        {
            return bookService.Get(guid);
        }

        [HttpGet]
        [ProducesResponseType(StatusCodes.Status200OK, Type = typeof(VmBook))]
        public VmBook[] GetAll()
        {
            return bookService.GetAll();
        }

        [HttpPatch]
        [ProducesResponseType(StatusCodes.Status200OK, Type = typeof(VmBook))]
        [ProducesResponseType(StatusCodes.Status404NotFound)]
        public VmBook Update(VmBookUpdateCommand book)
        {
            return bookService.Update(book);
        }
    }

}

