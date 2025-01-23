using CharityLoop.Models;

public class Voucher
{
    public int VoucherId { get; set; }
    public int UserId { get; set; } 
    public UserReg UserReg { get; set; } 

    public string Type { get; set; } // E.g., "Discount", "Gift Card"
    public double Value { get; set; } // E.g., "$10", "20% Off"
    public string Status { get; set; } 
    public DateTime ExpiryDate { get; set; }
}
