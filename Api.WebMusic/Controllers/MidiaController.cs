using Api.WebMusic.Domain.Dtos.Midias;
using Api.WebMusic.Domain.Interfaces.Services;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Net;
using System.Threading.Tasks;

namespace Api.WebMusic.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class MidiaController : ControllerBase
    {
        private readonly IMidiaServices _midiaService;

        public MidiaController(IMidiaServices midiaService)
        {
            _midiaService = midiaService;
        }

        [HttpGet("GetMidia/")]
        public async Task<IActionResult> GetMidia()
        {
            try
            {
                var listMidia = await _midiaService.GetAllMidiaDto();
                return Ok(listMidia);
            }
            catch (ArgumentException e)
            {
                return StatusCode((int)HttpStatusCode.InternalServerError, e.Message);
            }
        }

        [HttpGet("GetAllMidiaCompleto/")]
        public async Task<IActionResult> GetAllMidiaCompleto()
        {
            try
            {
                var listMidia = await _midiaService.GetAllMidiaCompleto();
                return Ok(listMidia);
            }
            catch (ArgumentException e)
            {
                return StatusCode((int)HttpStatusCode.InternalServerError, e.Message);
            }
        }

        [HttpGet("{id}", Name = "GetMidiaById")]
        public async Task<IActionResult> GetMidiaId(int id)
        {
            try
            {
                var entityMidia = await _midiaService.Get(id);

                if (entityMidia == null) return NotFound();

                return Ok(entityMidia);
            }
            catch (ArgumentException e)
            {
                return StatusCode((int)HttpStatusCode.InternalServerError, e.Message);
            }
        }

        [HttpGet("GetMidiaByIdCompleta/{id}")]
        public async Task<IActionResult> GetMidiaByIdCompleta(int id)
        {
            try
            {
                var entityMidia = await _midiaService.GetMidiaByIdCompleto(id);

                if (entityMidia == null) return NotFound();

                return Ok(entityMidia);
            }
            catch (ArgumentException e)
            {
                return StatusCode((int)HttpStatusCode.InternalServerError, e.Message);
            }
        }

        [HttpPost]
        public async Task<IActionResult> Post([FromBody] MidiaDtoCreate midiaDtoCreate)
        {
            if (!ModelState.IsValid) return BadRequest();
            try
            {
                var entityMidia = await _midiaService.Post(midiaDtoCreate);

                return Created(new Uri(Url.Link("GetMidiaById", new { id = entityMidia.Id })), entityMidia);
            }
            catch (ArgumentException e)
            {
                return StatusCode((int)HttpStatusCode.InternalServerError, e.Message);
            }
        }

        [HttpPut]
        public async Task<IActionResult> Put([FromBody] MidiaDtoUpdate midiaDtoUpdate)
        {
            if (!ModelState.IsValid) return BadRequest();
            try
            {
                var entityMidia = await _midiaService.Put(midiaDtoUpdate);

                return Created(new Uri(Url.Link("GetMidiaById", new { id = entityMidia.Id })), entityMidia);
            }
            catch (ArgumentException e)
            {
                return StatusCode((int)HttpStatusCode.InternalServerError, e.Message);
            }
        }

        [HttpDelete("{id}")]
        public async Task<IActionResult> Delete(int id)
        {
            try
            {
                var result = await _midiaService.Delete(id);
                return Ok(result);
            }
            catch (ArgumentException e)
            {
                return StatusCode((int)HttpStatusCode.InternalServerError, e.Message);
            }
        }
    }
}
