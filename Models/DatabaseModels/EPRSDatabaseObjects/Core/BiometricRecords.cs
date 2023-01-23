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
    public class BiometricRecords:BaseModel
    {
        [Key]
        public long BiometricRecordId { get; set; }
        [ForeignKey("BiometricVerification")]
        public long BiometricVerificationId { get; set; }
        public virtual BiometricVerification Biometric { get; set; }

        [ForeignKey("Application")]
        public long ApplicationId { get; set; }
        public virtual PermitIssueApplication Application { get; set; }
        public string PersonCNIC { get; set; }

        [ForeignKey("Person")]
        public long? PersonId { get; set; }
        public virtual EPRSPerson Person { get; set; }

        public bool IsBuyer { get; set; }
        public bool IsRep { get; set; }

        [ForeignKey("NadraFranchise")]
        public long? NadraFranchiseId { get; set; }
        public virtual NadraFranchise NadraFranchise { get; set; }

        public long? NadraTransId { get; set; }
        public bool? IsVerified { get; set; }
        public DateTime? VerificationReportedOn { get; set; }
    }
}
