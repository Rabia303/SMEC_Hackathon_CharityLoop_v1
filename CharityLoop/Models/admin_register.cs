using System.ComponentModel.DataAnnotations;

namespace CharityLoop.Models
{
	public class admin_register
	{

		[Key]
		public int Admin_Id { get; set; }
		public string UserName { get; set; }
		public string UserEmail { get; set; }

		public string UserPass { get; set; }
	}
}
