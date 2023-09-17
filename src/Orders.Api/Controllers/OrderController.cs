using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using Orders.Application.Dtos;
using Orders.Application.Services.Interfaces;

namespace basket_api.Controllers
{
    [ApiController]
    [Route("[controller]")]
    [Authorize(Policy = "RequireToken")]
    public class OrderController : ControllerBase
    {

      

    }
}
