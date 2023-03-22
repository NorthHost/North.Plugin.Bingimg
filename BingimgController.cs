using Microsoft.AspNetCore.Mvc;

namespace North.Plugin.Bingimg.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class BingimgController : ControllerBase
    {
        /// <summary>
        /// Bing 每日一图链接获取
        /// </summary>
        /// <returns></returns>
        [HttpGet]
        public string Get()
        {
            return "Hello, World";
        }
    }
}