using Microsoft.AspNetCore.Mvc;

namespace EnergyAPI.Controllers {

    [Route("api")]
    [ApiController]
    public class HealthCheckController {

        [HttpGet]
        public JsonResult Get() {
            return new JsonResult(new { status = "EnergyAPI is working fine..." });
        }
    }
}
