using Models.DatabaseModels.PermitIssuance.Core;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Models.ViewModels.Stock
{
    public class VwInventoryItems
    {
        public long ApplicationDetailId { get; set; }
        public long StockInApplicationId { get; set; }
        public virtual StockInApplication StockInApplication { get; set; }
        [Required]
        public long ProductId { get; set; }
        [Required]
        public long BottleSizeId { get; set; }
        [Required]
        public long Quantity { get; set; }
        [Required]
        public long BulkGallons { get; set; }
        [Required]
        public long StrenghtPercentage { get; set; }
        [Required]
        public long ProofGallons { get; set; }

        public long ProductDautyRate { get; set; }
    }
}
