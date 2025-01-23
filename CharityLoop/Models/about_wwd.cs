using System.ComponentModel.DataAnnotations;

namespace CharityLoop.Models
{
	public class about_wwd
	{

		[Key]
		public int wwdID { get; set; }
		public string desc { get; set; }
		public string img { get; set; }
	}
}
