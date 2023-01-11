using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Models.ViewModels.Stock
{
    public class VwOrderDetail
    {
        public long OrderDetailId { get; set; }
        [Required]
        public long OrderId { get; set; }
        [Required]
        public long ProductId { get; set; }
        [Required]
        public long Quantity { get; set; }
        [Required]
        public long ProductSize { get; set; }

        [Required]
        public long ProductPrice { get; set; }
        [Required]
        public long TotalPrice { get; set; }
    }
}
