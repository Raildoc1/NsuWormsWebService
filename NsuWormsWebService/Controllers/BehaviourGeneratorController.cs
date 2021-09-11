using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using NsuWormsWebService.Data;
using NsuWormsWebService.Models;

namespace NsuWormsWebService.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class BehaviourGeneratorController : ControllerBase
    {
        private readonly ILogger<BehaviourGeneratorController> _logger;

        public BehaviourGeneratorController(ILogger<BehaviourGeneratorController> logger)
        {
            _logger = logger;
        }

        //Test Data
        //{"Worms":[{"Name":"John","LifeStrength":20,"Position":{"X":1,"Y":1}}],"Food":[{"ExpiresIn":10,"Position":{"X":2,"Y":-1}}]}

        [HttpPost("{name}/getAction")]
        public BehaviourData Post(string name, WorldData world)
        {
            var behaviour = new BehaviourData()
            {
                Direciton = "Up",
                Split = false
            };

            return behaviour;
        }
    }
}
