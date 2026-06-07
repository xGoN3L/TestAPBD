using Microsoft.AspNetCore.Mvc;
using TestAPBD.DTOs;
using TestAPBD.Exceptions;
using TestAPBD.Services;

namespace TestAPBD.Controllers
{
    [Route("api/nurseries")]
    [ApiController]
    public class NurseriesController : ControllerBase
    {
        private readonly IDbService _dbService;
        public NurseriesController(IDbService dbService)
        {
            _dbService = dbService;
        }
        [Route("{id}/batches")]
        [HttpGet]
        public async Task<IActionResult> GetBatches(int id)
        {
            try
            {
                var batches = await _dbService.GetBatches(id);
                return Ok(batches);
            }
            catch (NotFoundException ex)
            {
                return NotFound(ex.Message);
            }
        }
        [HttpPost]
        public async Task<IActionResult> AddNursery([FromBody] AddNurseryDto nurseryDto)
        {
            var addedNursey = await _dbService.AddNursery(nurseryDto);
            return Created(addedNursey.Nursery.ToString(), addedNursey);
        }
    }
}
