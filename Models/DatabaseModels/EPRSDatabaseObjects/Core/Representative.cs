using Models.DatabaseModels.Biometric;
using Models.DatabaseModels.PermitIssuance.Core;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Models.DatabaseModels.EPRSDatabaseObjects.Core
{
    public class Representative:BaseModel
    {
        [Key]
        public long RepId { get; set; }
        [ForeignKey("Application")]
        public long ApplicationId { get; set; }
        public virtual PermitIssueApplication Application { get; set; }
        public string OldCNIC { get; set; }
        public string OldName { get; set; }
        public string newCNIC { get; set; }
        public string newName { get; set; }
        [ForeignKey("Person")]
        public long? PersonId { get; set; }
        public virtual EPRSPerson Person { get; set; }
        public bool? IsVerified { get; set; }
        public DateTime? VerificationReportedOn { get; set; }
    }
}
