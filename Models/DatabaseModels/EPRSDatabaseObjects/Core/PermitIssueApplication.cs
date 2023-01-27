using Models.DatabaseModels.PermitIssuance.Setup;
//using Models.DatabaseModels.VehicleRegistration.Setup;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Models.DatabaseModels.EPRSDatabaseObjects.Setup;

namespace Models.DatabaseModels.PermitIssuance.Core
{
    public class PermitIssueApplication : BaseModel
    {
        [Key]
        public long ApplicationId { get; set; }
        [ForeignKey("EPRSPerson")]
        public long PersonId { get; set; }
        public virtual EPRSPerson EPRSPerson { get; set; }
        public DateTime ReceivedAt { get; set; }
        public long PermitNo { get; set; } // Combination of CNIC & ApplicationID
        public long? OldPermitNo { get; set; }
        [ForeignKey("District")]
        public long? DistrictId { get; set; }
        public virtual District District { get; set; }
        [ForeignKey("City")]
        public long? CityId { get; set; }
        public virtual City City { get; set; }
        [ForeignKey("Profession")]
        public long? ProfessionId { get; set; }
        public virtual Profession Profession { get; set; }
        public string ProfessionName { get; set; }
        [ForeignKey("EPRSPermitTypes")]
        public long PermitTypeId { get; set; }
        public virtual EPRSPermitTypes EPRSPermitTypes { get; set; }
        public long? BioStatus { get; set; }

        public long? PermitStatus { get; set; }
        //[ForeignKey("ApplicationStatus")]
        public long? ApplicationStatusId { get; set; }
        //public virtual ApplicationStatus ApplicationStatus { get; set; }
        public long? SponsorTypeID { get; set; }
        public string SponsorCompanyName { get; set; }
        public string SponsorCompanyNTN { get; set; }
        public string SponsorPersonName { get; set; }
        public string SponsorPersonCNIC { get; set; }
    }
}
