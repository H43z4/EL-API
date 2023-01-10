using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Models.DatabaseModels.PermitIssuance.Setup
{
    public class ProductSize : BaseModel
    {
        [Key]
        public long ProductSizeId { get; set; }

        [StringLength(100)]
        public string ProductSizeName { get; set; }

        [ForeignKey("ProductType")]
        public long? ProductTypeId { get; set; }
        public virtual ProductType ProductType { get; set; }

        public decimal? QuantityInML { get; set; }

        public long ProductQtyforOneUnit { get; set; }
    }
}
