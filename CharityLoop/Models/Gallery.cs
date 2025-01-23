using System.ComponentModel.DataAnnotations;

namespace CharityLoop.Models
{
	public class Gallery
	{
		[Key]
		public int imgId { get; set; }
		public string category { get; set; }
		public string desc { get; set; }
		public string img { get; set; }
	}
}
