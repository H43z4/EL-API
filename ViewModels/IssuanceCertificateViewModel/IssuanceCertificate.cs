namespace Issuance.ViewModels.IssuanceCertificateViewModel
{
    public class IssuanceCertificate
    {
        public long OwnerId { get; set; }
        public long OwnerTypeId { get; set; }
        public long OwnerTaxGroupId { get; set; }
        public string OwnerType { get; set; }
        public string OwnerTaxGroup { get; set; }
        public bool? IsHPA { get; set; }
    }
}
