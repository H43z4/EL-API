using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Models.ViewModels.Stock
{
    public class VwInventory
    {
        public long StockInApplicationId { get; set; }
        public long OrganisationId { get; set; } // Stock Request Initiated by Organisation to Add Products in his Stock.
        [Required]
        public long ExcisePassNo { get; set; }
        [Required]
        public DateTime RequestDate { get; set; }
        [Required]
        public string TransportExportNo { get; set; }
        public string DriverName { get; set; }
        [Required]
        public long ConsignmentFromId { get; set; }
        [Required]
        public long PermitNo { get; set; }
        [Required]
        public DateTime PassValidity { get; set; }
        [Required]
        public string VehicleRegistrationNo { get; set; }
        [Required]
        public string SignedByCollector { get; set; }
        [Required]
        public string RateOfDauty { get; set; }
        [Required]
        public string AmountOfDautyLevied { get; set; }
        [Required]
        public string ChNoDate { get; set; }
        [Required]
        public string Remarks { get; set; }
        [Required]
        public List<VwInventoryItems> items { get; set; }
    }
}
