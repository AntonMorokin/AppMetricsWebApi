using AppMetricsWebApi.Model;
using Microsoft.AspNetCore.Mvc;

namespace AppMetricsWebApi.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public sealed class ClientsController : ControllerBase
    {
        [HttpGet("{clientId}")]
        public async Task<IActionResult> Get(int clientId)
        {
            await Task.Delay(new Random().Next(100) + 100);

            return Ok("OK");
        }

        [HttpPost]
        public Task<IActionResult> Create(Client newClient)
        {
            return Task.FromResult<IActionResult>(new CreatedResult($"api/clients/{newClient.Id}", "CREATED"));
        }

        [HttpPatch("modify")]
        public async Task<IActionResult> Patch(Client changedClient)
        {
            await Task.Delay((new Random().Next(10) + 1) * 1000);

            return Accepted($"api/cleints/{changedClient.Id}", "MODIFIED");
        }

        [HttpDelete("remove/{clientId}")]
        public Task<IActionResult> Delete(int clientId)
        {
            throw new InvalidOperationException();
        }
    }
}
