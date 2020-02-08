using Business.Interfaces;
using Microsoft.AspNetCore.Mvc;

namespace API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ManagementController : Controller
    {
        private readonly IManagementService _managementService;

        public ManagementController(IManagementService managementService)
        {
            _managementService = managementService;
        }


        [HttpGet]
        public IActionResult GetData(int idData)
        {
            var temp = _managementService.GetTable(idData);
            return Ok(temp);
        }
    }
}
