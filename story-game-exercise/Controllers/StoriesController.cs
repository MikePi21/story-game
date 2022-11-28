using System;
using Microsoft.AspNetCore.Mvc;
using story_game_exercise.Controllers.Commands;
using story_game_exercise.Service.Interface;

namespace story_game_exercise.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class StoriesController : ControllerBase
    {
        private IStoryService storyService;

        public StoriesController(IStoryService storyService)
        {
            this.storyService = storyService;
        }

        [HttpPost]
        [ProducesResponseType(StatusCodes.Status200OK, Type = typeof(VmStoryCreateCommand))]
        public VmStory Create(VmStoryCreateCommand command)
        {
            return storyService.Create(command);
        }

        [HttpDelete("{id:Guid}")]
        [ProducesResponseType(StatusCodes.Status200OK)]
        [ProducesResponseType(StatusCodes.Status404NotFound)]
        public void Delete(Guid id)
        {
            storyService.Delete(id);
        }

        [HttpGet("{id:Guid}")]
        [ProducesResponseType(StatusCodes.Status200OK, Type = typeof(VmStory))]
        [ProducesResponseType(StatusCodes.Status404NotFound)]
        public VmStory Get(Guid id)
        {
            return storyService.Get(id);
        }

        [HttpGet]
        [ProducesResponseType(StatusCodes.Status200OK, Type = typeof(VmStory[]))]
        public VmStory[] GetAll()
        {
            return storyService.GetAll();
        }

        [HttpPatch]
        [ProducesResponseType(StatusCodes.Status200OK, Type = typeof(VmStory))]
        [ProducesResponseType(StatusCodes.Status404NotFound)]
        public VmStory Update(VmStoryUpdateCommand command)
        {
            return storyService.Update(command);
        }

        [HttpGet("GetAllByChapterId/{chapterId:Guid}")]
        [ProducesResponseType(StatusCodes.Status200OK, Type = typeof(VmStory[]))]
        public VmStory[] GetAllByChapterId(Guid chapterId)
        {
            return storyService.GetAllByChapterId(chapterId);
        }
    }
}

