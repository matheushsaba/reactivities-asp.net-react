using Microsoft.AspNetCore.Mvc;

namespace API.Controllers
{
    public class BaseApiController : Controller
    {
        [ApiController]
        [Route("api/[controller]")]
        public class BaseAPiController : ControllerBase
        {

        }
    }
}
