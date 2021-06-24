using Api.WebMusic.Domain.Dtos.Faixas;
using Api.WebMusic.Domain.Interfaces.Services;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Net;
using System.Threading.Tasks;

namespace Api.WebMusic.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class FaixaController : ControllerBase
    {
        private readonly IFaixaService _faixaService;

        public FaixaController(IFaixaService faixaService)
        {
            _faixaService = faixaService;
        }

        [HttpGet]
        [Route("GetFaixasCompletas/")]
        public async Task<IActionResult> GetFaixasCompetasAsync()
        {
            try
            {
                var listFaixas = await _faixaService.GetAllFaixaCompleto();
                return Ok(listFaixas);
            }
            catch (ArgumentException e)
            {
                return StatusCode((int)HttpStatusCode.InternalServerError, e.Message);
            }
        }

        [HttpGet]
        public async Task<IActionResult> GetFaixas()
        {
            try
            {
                var listFaixas = await _faixaService.GetAllFaixaDto();
                return Ok(listFaixas);
            }
            catch (ArgumentException e)
            {

                return StatusCode((int)HttpStatusCode.InternalServerError, e.Message);
            }
        }

        [HttpGet("{id}")]
        public async Task<IActionResult> Get(int id)
        {
            try
            {
                var entity = await _faixaService.Get(id);

                if (entity == null) return NotFound();

                return Ok(entity);
            }
            catch (ArgumentException e)
            {

                return StatusCode((int)HttpStatusCode.InternalServerError, e.Message);
            }
        }

        [HttpGet("GetFaixaFullById/{id}",Name = "GetFaixaFullById")]
        public async Task<IActionResult> GetByIdCompleto(int id)
        {
            try
            {
                var entity = await _faixaService.GetFaixaByIdCompleto(id);

                if (entity == null) return NotFound();

                return Ok(entity);
            }
            catch (ArgumentException e)
            {

                return StatusCode((int)HttpStatusCode.InternalServerError, e.Message);
            }
        }

        [HttpPost]
        public async Task<IActionResult> Post([FromBody] FaixaDtoCreate faixaDtoCreate)
        {
            if (!ModelState.IsValid) return BadRequest();

            try
            {
                var entity = await _faixaService.Post(faixaDtoCreate);
                return Created(new Uri(Url.Link("GetFaixaFullById", new { id = entity.Id })), entity);
            }
            catch (ArgumentException e)
            {
                return StatusCode((int)HttpStatusCode.InternalServerError, e.Message);
            }
        }

        [HttpPut]
        public async Task<IActionResult> Put([FromBody]FaixaDtoUpdate faixaDtoUpdate)
        {
            if (!ModelState.IsValid) return BadRequest();

            try
            {
                var entityUpdate = await _faixaService.Put(faixaDtoUpdate);
                return Created(new Uri(Url.Link("GetFaixaFullById", new { id = entityUpdate.Id })), entityUpdate);
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
                var result = await _faixaService.Delete(id);
                return Ok(result);
            }
            catch (ArgumentException e)
            {
                return StatusCode((int)HttpStatusCode.InternalServerError, e.Message);
            }
        }

    }
}
