namespace ContractMonthlyClaimSystem.Models
{
    public class Document
    {
        public int Id { get; set; }
        public int ClaimId { get; set; }
        public string FileName { get; set; }
        public string FilePath { get; set; }
        public DateTime UploadedDate { get; set; }
    }
}
