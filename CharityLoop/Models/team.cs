using System.ComponentModel.DataAnnotations;

namespace CharityLoop.Models
{
	public class team
	{
		[Key]
		public int id { get; set; }
		public string name { get; set; }
		public string role { get; set; }

		public string img { get; set; }
		public string desc { get; set; }
	}
}
