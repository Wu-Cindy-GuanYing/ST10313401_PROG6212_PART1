namespace ContractMonthlyClaimSystem.Models
{
    public class ClaimItem
    {
        public int Id { get; set; }
        public int ClaimId { get; set; }
        public DateTime Date { get; set; }
        public decimal Hours { get; set; }
        public decimal Rate { get; set; }
        public string Description { get; set; }
    }
}
