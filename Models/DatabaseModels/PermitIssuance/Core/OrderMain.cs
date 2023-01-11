using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Models.DatabaseModels.PermitIssuance.Core
{
    public class OrderMain : BaseModel
    {
        [Key]
        public long OrderId { get; set; }
        public long PersonId { get; set; } 
        public long OrganisationId { get; set; } //VendShop ID
        public DateTime TransactionDate { get; set; }
        public long TotalAmount { get; set; }
        public long PermitNo { get; set; }
        public long TotalQuantity { get; set; }
        public Decimal Tax { get; set; }
        public long Discount { get; set; }
        public long GrandTotal { get; set; }

    }
}
