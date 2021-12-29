using AppMetricsWepApi.Model;
using Microsoft.AspNetCore.Mvc;

namespace AppMetricsWepApi.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public sealed class ClientsController : ControllerBase
    {
        [HttpGet("{clientId}")]
        public async Task<IActionResult> Get(int clientId)
        {
            await Task.Delay(new Random().Next(100) + 100);

            return new OkResult();
        }

        [HttpPost]
        public Task<IActionResult> Create()
        {
            return Task.FromResult<IActionResult>(new CreatedResult("api/cleints/create", null));
        }

        [HttpPatch("modify")]
        public async Task<IActionResult> Patch(Client changedClient)
        {
            await Task.Delay((new Random().Next(10) + 1) * 1000);

            return new OkResult();
        }

        [HttpDelete("remove/{clientId}")]
        public Task<IActionResult> Delete(int clientId)
        {
            throw new InvalidOperationException();
        }
    }
}
