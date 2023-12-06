using System.ComponentModel.DataAnnotations;

namespace PlanetExplorer.Models
{
	public class Planet
	{
		[Key]
		public int planet_id { get; set; }

		[Required]
		public string planet_name { get; set; }

		[Required]
		public string planet_image { get; set; }

		public string? description { get; set; }

        public int? rotation_period { get; set; }

        public int? orbital_period { get; set; }

        public int? diameter { get; set; }

        public string? climate { get; set; }

        public string? terrain { get; set; }

        public long? population { get; set; }

        public string? affiliation { get; set; }

        public string? fun_facts { get; set; }
    }
}
