using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Models.DatabaseModels.PermitIssuance.Core
{
    public class OrderDetail : BaseModel
    {
        [Key]
        public long OrderDetailId { get; set; }
        public long OrderId { get; set; }
        public long ProductId { get; set; } 
        
        //public DateTime TransactionDate { get; set; }
        public long Quantity { get; set; }
        public long ProductSize { get; set; }
        
        public long ProductPrice { get; set; }
        public long TotalPrice { get; set; }
    }
}
