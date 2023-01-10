using Models.DatabaseModels.Authentication;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Models.ViewModels.PermitIssuance.Setup
{
    public class VwEPRSUser
    {
        public long? UserId { get; set; }

        //public long? UserDistrictId { get; set; }

        //public long? PersonId { get; set; }
        public long? RoleId { get; set; }

        public string RoleName { get; set; }
        //public string UserType { get; set; }
        public long? UserStatusId { get; set; }
        public string UserStatus { get; set; }

        public long? OrganizationId { get; set; }

        public string OrganizationName { get; set; }
        public List<Role> UserRoles { get; set; }

        //public string IP { get; set; }

        public string UserName { get; set; }

        public string Password { get; set; }

        public string FullName { get; set; }
    }
}
