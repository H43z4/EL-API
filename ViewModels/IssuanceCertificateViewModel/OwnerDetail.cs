namespace Issuance.ViewModels.IssuanceCertificateViewModel
{
    public class OwnerDetail
    {
        public long OwnerId { get; set; }
        public DateTime CreatedAt { get; set; }
        public long PersonId { get; set; }
        public long CountryId { get; set; }
        public string PersonName { get; set; }
        public string FatherHusbandName { get; set; }
        public string CNIC { get; set; }
        public string Email { get; set; }
        public string OldCNIC { get; set; }
        public string NTN { get; set; }
        public string FTN { get; set; }
    }
}
