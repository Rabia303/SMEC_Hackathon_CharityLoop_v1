namespace CharityLoop.Models
{
    public class Disposal
    {
        public int DisposalId { get; set; } // Primary Key
        public int UserId { get; set; } // Foreign Key
        public UserReg User { get; set; } // Navigation Property

        public string Type { get; set; } // E.g., "Recycling", "Upcycling"
        public string Status { get; set; } // "Pending", "Picked Up", "Completed"
        public DateTime ScheduledDate { get; set; }
        public DateTime CreatedAt { get; set; }
    }

}
