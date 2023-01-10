using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Models.DatabaseModels.PermitIssuance.Setup
{
    public class Manufacturer : BaseModel
    {
        [Key]
        public long ManufacturerId { get; set; }

        [StringLength(200)]
        public string ManufacturerName { get; set; }
        
        [StringLength(100)]
        public string ManufacturerProvince { get; set; }
        [StringLength(200)]
        public string ManufacturerAddress { get; set; }
        [StringLength(50)]
        public string ManufacturerContactNo { get; set; }
        [StringLength(200)]
        public string ManufacturerEmail { get; set; }

    }
}
