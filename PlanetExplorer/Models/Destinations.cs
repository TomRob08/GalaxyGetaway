using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace PlanetExplorer.Models
{
	public class Destinations
	{
		[Key]
		public int dest_id { get; set; }

		[Required]
		public string dest_name { get; set; }

		[Required]
		[ForeignKey("planet_id")]
		public int planet_id { get; set; }

		public string? dest_description { get; set; }

		public string? dest_image { get; set; }

		public double? dest_price { get; set; }

		public double? dest_rating { get; set; }
	}
}
