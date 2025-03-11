using DEVSECOPS.API.HttpClients;
using DEVSECOPS.API.Models;
using DEVSECOPS.API.Services;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace DEVSECOPS.API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class BeansController : ControllerBase
    {
        private readonly IBeanService  _beanService;

        public BeansController(IBeanService  beanService)
        {
            _beanService = beanService;
        }


        [HttpGet("{BeanId}")]
        public async Task<IActionResult> GetUserByUserID(int BeanId)
        {
            if (BeanId == null)
            {
                return BadRequest("Invalid BeanId");
            }

            BeanModel? response = await _beanService.GetBeanById(BeanId);

            if (response == null)
            {
                return NotFound(response);
            }

            return Ok(response);
        }
    }
}
