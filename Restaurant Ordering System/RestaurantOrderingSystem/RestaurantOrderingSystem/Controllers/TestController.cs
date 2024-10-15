using Microsoft.AspNetCore.Mvc;
using RestaurantOrderingSystem.Services;

namespace RestaurantOrderingSystem.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class TestController : ControllerBase
    {
        private readonly DatabaseConnectionService _dbConnectionService;

        public TestController(DatabaseConnectionService dbConnectionService)
        {
            _dbConnectionService = dbConnectionService;
        }

        [HttpGet("test-connection")]
        public async Task<IActionResult> TestConnection()
        {
            var result = await _dbConnectionService.TestDatabaseConnection();
            return result ? Ok("Connection successful!") : BadRequest("Connection failed.");
        }
    }
}
