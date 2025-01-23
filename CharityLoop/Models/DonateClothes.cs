using CharityLoop.Models;
using System.ComponentModel.DataAnnotations;

public class DonateClothes
{
	[Key]
	public int DonationId { get; set; }
	public int UserRegId { get; set; }
	public UserReg UserReg { get; set; }

	public int NGOId { get; set; }
	public NGO NGO { get; set; }

	public string Type { get; set; }
	public string Status { get; set; }

	public DateTime ScheduledDate { get; set; }
	public DateTime CreatedAt { get; set; }
	public bool isDisposal { get; set; }  // Flag for disposal
}
