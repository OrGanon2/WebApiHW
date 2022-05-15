using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace WebApiHW.Controllers
{
    [Route("api/[Action]")]
    [ApiController]
    public class FlowerController : ControllerBase
    {
        public string Rose()
        {
            return "Rose";
        }
        public string Lotus()
        {
            return "Lotus";
        }
        public string Jasmine()
        {
            return "Jasmine";
        }
        public string Sunflower()
        {
            return "SunFlower";
        }
    }

}
