using System.ComponentModel.DataAnnotations;

namespace CharityLoop.Models
{
	public class ourPrograms
	{

		[Key]
		public int opID { get; set; }
		public string opHeading { get; set; }
		public string opDesc { get; set; }

		public string img { get; set; }
	}
}
