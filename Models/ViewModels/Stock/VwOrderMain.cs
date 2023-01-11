using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Models.ViewModels.Stock
{
    public class VwOrderMain
    {
        public long OrderId { get; set; }
        public long PersonId { get; set; }
        public long OrganisationId { get; set; } //VendShop ID
        [Required]
        public DateTime TransactionDate { get; set; }
        [Required]
        public long TotalAmount { get; set; }
        [Required]
        public long PermitNo { get; set; }
        [Required]
        public long TotalQuantity { get; set; }
        [Required]
        public Decimal Tax { get; set; }
        [Required]
        public long Discount { get; set; }
        [Required]
        public long GrandTotal { get; set; }
        public List<VwOrderDetail> OrderDetail { get; set; }
    }
}
