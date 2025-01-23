using System.ComponentModel.DataAnnotations;

namespace CharityLoop.Models
{
	public class listofNGO
	{
		[Key]
		public int id { get; set; }
		public string nameofNGO { get; set; }
		public string desc { get; set; }
		public string logo_img { get; set; }
	}
}
