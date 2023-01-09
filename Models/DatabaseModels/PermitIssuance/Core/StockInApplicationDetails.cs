using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Models.DatabaseModels.PermitIssuance.Core
{
    public class StockInApplicationDetails : BaseModel
    {
        [Key]
        public long ApplicationDetailId { get; set; }

        [ForeignKey("StockInApplication")]
        public long StockInApplicationId { get; set; }
        public virtual StockInApplication StockInApplication { get; set; }
        public long ProductId { get; set; } 
        public long BottleSizeId { get; set; }
        public long Quantity { get; set; }
        public long BulkGallons { get; set; }

        public long StrenghtPercentage { get; set; }
        public long ProofGallons { get; set; }
        
    }
}
