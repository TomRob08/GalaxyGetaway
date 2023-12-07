namespace PlanetExplorer.Models
{
    public class CombinedViewModel
    {
        public Planet Planet { get; set; }
        public IEnumerable<Destinations> Destinations { get; set; }
    }
}
