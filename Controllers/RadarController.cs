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
        // Check the space in front of the radar for enemies and return the list of enemies as coordinates
        [HttpGet]
        public IEnumerable<EnemyCoordinates> Get()
        {
            List<EnemyCoordinates> foundEnemies = new List<EnemyCoordinates>();
            Random random = new Random();
            int numOfEnemies = random.Next(0,5);

            for(int i=0; i< numOfEnemies; i++)
            {
                foundEnemies.Add(new EnemyCoordinates()
                { 
                    X = GetRandomCoordinate(random, -1,1), 
                    Y = GetRandomCoordinate(random, -1,1)
                });
            }

            return foundEnemies;
        }

        public double GetRandomCoordinate(Random random, double minimum, double maximum)
        { 
            return random.NextDouble() * (maximum - minimum) + minimum;
        }
    }
}
