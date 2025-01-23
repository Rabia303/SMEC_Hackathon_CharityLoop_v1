using System.ComponentModel.DataAnnotations;

namespace CharityLoop.Models
{
    public class ActivityLog
    {
        [Key]
        public int LogId { get; set; } // Primary Key
        public string Action { get; set; } // E.g., "Added NGO", "Updated Voucher"
        public string PerformedBy { get; set; } // User's Name or Admin ID
        public DateTime Timestamp { get; set; }
    }

}
