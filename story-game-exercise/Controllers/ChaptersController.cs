using System;
using Microsoft.AspNetCore.Mvc;
using story_game_exercise.Controllers.Commands;
using story_game_exercise.Service.Interface;

namespace story_game_exercise.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class ChaptersController : ControllerBase
    {
        private IChapterService chapterService;

        public ChaptersController(IChapterService chapterService)
        {
            this.chapterService = chapterService;
        }

        [HttpGet("GetAllByBookId/{id:Guid}")]
        [ProducesResponseType(StatusCodes.Status200OK, Type = typeof(VmChapter[]))]
        [ProducesResponseType(StatusCodes.Status404NotFound)]
        public VmChapter[] GetChaptersByBookId(Guid id)
        {
            return chapterService.GetChaptersByBookId(id);
        }

        [HttpPost]
        [ProducesResponseType(StatusCodes.Status200OK, Type = typeof(VmChapterCreateCommand))]
        public VmChapter Create(VmChapterCreateCommand command)
        {
            return chapterService.Create(command);
        }

        [HttpDelete("{id:Guid}")]
        [ProducesResponseType(StatusCodes.Status200OK)]
        [ProducesResponseType(StatusCodes.Status404NotFound)]
        public void Delete(Guid id)
        {
            chapterService.Delete(id);
        }

        [HttpGet("{id:Guid}")]
        [ProducesResponseType(StatusCodes.Status200OK, Type = typeof(VmChapter))]
        [ProducesResponseType(StatusCodes.Status404NotFound)]
        public VmChapter Get(Guid id)
        {
            return chapterService.Get(id);
        }

        [HttpGet]
        [ProducesResponseType(StatusCodes.Status200OK, Type = typeof(VmChapter[]))]
        public VmChapter[] GetAll()
        {
            return chapterService.GetAll();
        }

        [HttpPatch]
        [ProducesResponseType(StatusCodes.Status200OK, Type = typeof(VmChapter))]
        [ProducesResponseType(StatusCodes.Status404NotFound)]
        public VmChapter Update(VmChapterUpdateCommand command)
        {
            return chapterService.Update(command);
        }
    }
}

