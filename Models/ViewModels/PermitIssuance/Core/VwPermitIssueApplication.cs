using Models.ViewModels.VehicleRegistration.Core;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Models.ViewModels.PermitIssuance.Core
{
    public class VwPermitIssueApplication
    {
        
        public long ApplicationId { get; set; }

        public long? CountryId { get; set; } // for PR-II

        public DateTime CreatedAt { get; set; }
        public string? City { get; set; }
        public long? CityId { get; set; }
        public long? DistrictId { get; set; }
        public string? ProfessionName { get; set; }
        public long? ProfessionId { get; set; }

        [Required]
        [StringLength(100)]
        public string PersonName { get; set; }

        [StringLength(100)]
        public string FatherHusbandName { get; set; }

        [StringLength(200)]
        public string Address { get; set; }
        public DateTime DateofBirth { get; set; }
        public string CellNo { get; set; }
        public string? CNIC { get; set; }
        public string? PassportNo { get; set; } // for PR-II

        public string? Nationality { get; set; } // for PR-II
        public DateTime? VisaExpiryDate { get; set; } // for PR-II

        public long? OldPermitNo { get; set; }

        public long PermitTypeId { get; set; }
        public string SponsorCompanyNTN { get; set; }
        public string SponsorCompanyName { get; set; }
        public string SponsorPersonCNIC { get; set; }
        public string SponsorPersonName { get; set; }
        public long? SponsorTypeID { get; set; }
    }
}
