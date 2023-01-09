using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Models.DatabaseModels.PermitIssuance.Core
{
    public class PermitApplicationDetail : BaseModel
    {
        [Key]
        public long ApplicationDetailId { get; set; }

        [ForeignKey("PermitIssueApplication")]
        public long ApplicationId { get; set; }
        public virtual PermitIssueApplication PermitIssueApplication { get; set; }

        public long PMFLTypeId { get; set; }

        public long BottleSizeId { get; set; }

        public long Quantity { get; set; }

        public long totalAllocation { get; set; }




    }
}
