using System;

namespace Models.ViewModels.Documents
{
    public class VwPersonDocument
    {
        public long DocumentId { get; set; }
        public string DocumentName { get; set; }
        public string DocumentType { get; set; }
        public string DocumentDescription { get; set; }
        public string DocumentPath { get; set; }
        public long PersonId { get; set; }
        public long ApplicationId { get; set; }
        public DateTime CreatedAt { get; set; }
        public DateTime CreatedBy { get; set; }
        public DateTime? ModifiedAt { get; set; }
        public DateTime? ModifiedBy { get; set; }
        //public byte[] File { get; set; }
    }
}
