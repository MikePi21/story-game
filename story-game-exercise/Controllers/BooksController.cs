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

        public BooksController(IBookService bookService)
        {
            this.bookService = bookService;
        }

        [HttpPost]
        [ProducesResponseType(StatusCodes.Status200OK, Type = typeof(VmBookCreateCommand))]
        public VmBook Create(VmBookCreateCommand command)
        {
            return bookService.Create(command);
        }

        [HttpDelete("{id:Guid}")]
        [ProducesResponseType(StatusCodes.Status200OK)]
        [ProducesResponseType(StatusCodes.Status404NotFound)]
        public void Delete(Guid id)
        {
            bookService.Delete(id);
        }

        [HttpGet("{id:Guid}")]
        [ProducesResponseType(StatusCodes.Status200OK, Type = typeof(VmBook))]
        [ProducesResponseType(StatusCodes.Status404NotFound)]
        public VmBook Get(Guid id)
        {
            return bookService.Get(id);
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

