using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using PlanetExplorer.Data;
using PlanetExplorer.Models;
using System.Diagnostics;

namespace PlanetExplorer.Controllers
{
    public class BookController : Controller
    {
        private readonly ApplicationDBContext _db;

        public BookController(ApplicationDBContext db)
        {
            _db = db;
        }

        public IActionResult Book()
        {
            IEnumerable<string> planetList = _db.Planets.Select(p => p.planet_name).ToList();
            return View(planetList);
        }

        [HttpPost]
        public IActionResult setSession()
        {
            string dest = Request.Form["destination"].ToString();
            string date1 = Request.Form["dateInput1"].ToString();
            string date2 = Request.Form["dateInput2"].ToString();
            string travelers = Request.Form["travelers"].ToString();

            if (validateStrings(dest, date1, date2, travelers))
            {
                HttpContext.Session.SetString("dest", dest);

                HttpContext.Session.SetString("date1", date1);

                HttpContext.Session.SetString("date2", date2);

                HttpContext.Session.SetString("travelers", travelers);

                return Redirect("Trip");
            }

            else
            {
                return Redirect("Book");
            }
        }

        private bool validateStrings(string dest, string date1, string date2, string travelers)
        {
            if (!dest.All(char.IsLetterOrDigit))
            { return false; }

            if (!travelers.All(char.IsDigit))
            { return false; }

            if (date1.Length == 10 && date2.Length == 10)
            {
                if (date1[4] != '-' || date1[7] != '-' || date2[4] != '-' || date2[7] != '-')
                {  return false; }
            }

            else
            { return false; }

            return true;
        }

        [Authorize]
        public IActionResult Trip()
        {
            Planet planet = _db.Planets.FirstOrDefault(p => p.planet_name == HttpContext.Session.GetString("dest"));
            IEnumerable<Destinations> destinations = _db.Destinations.Where(d => d.planet_id == planet.planet_id).ToList();

            if (planet == null)
            {
                return NotFound("Planet not available");
            }

            var viewModel = new CombinedViewModel
            {
                Planet = planet,
                Destinations = destinations
            };

            //Grab entries from the package SQL table using the planet_id
            //Console.WriteLine((string)planet.planet_id);

            return View(viewModel);
        }
    }
}
