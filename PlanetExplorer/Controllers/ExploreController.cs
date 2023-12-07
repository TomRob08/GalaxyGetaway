using Microsoft.AspNetCore.Mvc;
using PlanetExplorer.Data;
using PlanetExplorer.Models;

namespace PlanetExplorer.Controllers
{
    public class ExploreController : Controller
    {
        private readonly ApplicationDBContext _db;

        public ExploreController(ApplicationDBContext db)
        {
            _db = db;
        }

        public IActionResult Explore()
        {
            IEnumerable<Planet> objPlanetList = _db.Planets;
            return View(objPlanetList);
        }

		public IActionResult Planet(int? id)
		{
			if (id == null)
			{
				return BadRequest("Invalid planet ID");
			}

			Planet planet = _db.Planets.FirstOrDefault(p => p.planet_id == id);

            if (planet == null)
			{
				return NotFound("Planet not found");
			}

			return View(planet);
		}
	}
}
