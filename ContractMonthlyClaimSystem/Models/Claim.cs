using System.Reflection.Metadata;

namespace ContractMonthlyClaimSystem.Models
{
    public class Claim
    {
        public int Id { get; set; }
        public string LecturerId { get; set; }
        public string LecturerName { get; set; }
        public DateTime Month { get; set; }
        public decimal TotalHours { get; set; }
        public decimal TotalAmount { get; set; }
        public string Status { get; set; } // Submitted, ApprovedByCoordinator, ApprovedByManager, Rejected, Paid
        public DateTime SubmittedDate { get; set; }
        public DateTime? ApprovedDate { get; set; }
        public List<ClaimItem> ClaimItems { get; set; }
        public List<Document> Documents { get; set; }
    }
}
