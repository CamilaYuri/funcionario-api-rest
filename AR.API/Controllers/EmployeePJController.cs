using AR.Domain.DTO;
using AR.Domain.Interfaces.Services;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace AR.API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class EmployeePJController : ControllerBase
    {
        private readonly IEmployeePJService _service;

        public EmployeePJController(IEmployeePJService service)
        {
            _service = service;
        }

        [HttpGet]
        public async Task<IActionResult> Get()
        {
            var data = await _service.GetAll();
            if (data == null)
                return NotFound();

            return Ok(data);
        }

        [HttpGet("{id}")]
        public async Task<IActionResult> GetById(int id)
        {
            var data = await _service.GetById(id);
            if (data == null)
                return NotFound();

            return Ok(data);
        }

        [HttpPost]
        public async Task<IActionResult> Add(EmployeePjDTO employee)
        {
            try
            {
                await _service.Add(employee);
                return StatusCode(201);
            }
            catch (Exception ex)
            {
                return StatusCode(500, ex.Message);
            }
        }

        [HttpPut]
        public async Task<IActionResult> Update(EmployeePjDTO employee)
        {
            try
            {
                if (employee == null)
                    return BadRequest();

                var data = await _service.Update(employee);

                if (data == 0)
                    return NotFound();

                return Ok(data);
            }
            catch (Exception ex)
            {
                return StatusCode(500, ex.Message);
            }
        }

        [HttpDelete("{id}")]
        public async Task<IActionResult> Delete(int id)
        {
            try
            {
                var data = await _service.Delete(id);
                if (data == 0)
                    return NotFound();

                return Ok(data);
            }
            catch (Exception ex)
            {
                return StatusCode(500, ex.Message);
            }
        }
    }
}
