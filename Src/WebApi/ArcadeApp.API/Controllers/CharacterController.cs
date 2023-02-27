using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using ArcadeApp.Application.Features.Commands.Characters;
using ArcadeApp.Application.Features.Queries.Characters;
using MediatR;
using Microsoft.AspNetCore.Mvc;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace ArcadeApp.API.Controllers
{
    [Route("api/[controller]")]
    public class CharacterController : Controller
    {

        IMediator _mediatr;

        public CharacterController(IMediator mediatr)
        {
            _mediatr = mediatr;
        }

        // GET: api/values
        [HttpGet]
        public async Task<IActionResult> Get()
        {
            var query = new GetAllCharactersQuery();
            return Ok(await _mediatr.Send(query));
        }

        // GET api/values/5
        [HttpGet("{id}")]
        public string Get(int id)
        {
            return "value";
        }

        // POST api/values
        [HttpPost]
        public async Task<IActionResult> Post([FromBody] AddCharacterCommand command)
        {
            var newCharacter =  await _mediatr.Send(command);

            return Ok(newCharacter);
        }

      
    }
}

