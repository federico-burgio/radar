using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;

namespace radar.Controllers
{
    [Route("api/[controller]")]
    public class RadarController : Controller
    {
        // GET api/values
        [HttpGet]
        public IEnumerable<EnemyCoordinates> Get()
        {
            return new EnemyCoordinates[] { new EnemyCoordinates{ X = 0.2424, Y = 0.32412 } };
        }
    }
}
