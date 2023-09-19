using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;

namespace Orders.Api.Controllers
{
    [ApiController]
    [Route("[controller]")]
    [Authorize(Policy = "RequireToken")]
    public class OrderController : ControllerBase
    {



    }
}
