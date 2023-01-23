using Models.DatabaseModels.Authentication;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Models.DatabaseModels.PermitIssuance.Setup
{
    public class EPRSUserRole : BaseModel
    {
        [Key]
        public long UserRoleId { get; set; }

        [ForeignKey("AssociatedUser")]
        public long UserId { get; set; }
        public virtual EPRSUser AssociatedUser { get; set; }

        [ForeignKey("Role")]
        public long RoleId { get; set; }
        public virtual EPRSRole Role { get; set; }

        //public bool IsTimeBased { get; set; }

        //public DateTime? ExpiryDateTime { get; set; }
    }
}
