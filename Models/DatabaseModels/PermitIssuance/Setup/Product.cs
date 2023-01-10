using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Models.DatabaseModels.PermitIssuance.Setup
{
    public class Product : BaseModel
    {
        [Key]
        public long ProductId { get; set; }

        [StringLength(100)]
        public string ProductName { get; set; }

        [ForeignKey("ProductType")]
        public long? ProductTypeId { get; set; } 
        public virtual ProductType ProductType { get; set; }

        [ForeignKey("Manufacturer")]
        public long? ManufacturerId { get; set; }
        public virtual Manufacturer Manufacturer { get; set; }



    }
}
