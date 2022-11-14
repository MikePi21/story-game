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

        [HttpGet("{id:Guid}/books")]
        [ProducesResponseType(StatusCodes.Status200OK, Type = typeof(VmChapter[]))]
        [ProducesResponseType(StatusCodes.Status404NotFound)]
        public VmChapter[] GetChaptersByBookId(Guid id)
        {
            return chapterService.GetChaptersByBookId(id);
        }
    }
}

