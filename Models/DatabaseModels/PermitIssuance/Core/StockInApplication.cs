using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Models.DatabaseModels.PermitIssuance.Core
{
    public class StockInApplication : BaseModel
    {
        [Key]
        public long StockInApplicationId { get; set; }
        public long OrganisationId { get; set; } // Stock Request Initiated by Organisation to Add Products in his Stock.
        public long ExcisePassNo { get; set; }
        public DateTime RequestDate { get; set; }
        public string TransportExportNo { get; set; }

        public long ConsignmentFromId { get; set; }
        public long PermitNo { get; set; }
        public DateTime PassValidity { get; set; }

        public string VehicleRegistrationNo { get; set; }

        public string SignedByCollector { get; set; }

        public string RateOfDauty { get; set; }
        public string AmountOfDautyLevied { get; set; }
        public string ChNoDate { get; set; }
        public string Remarks { get; set; }

        public string DriverName { get; set; }

    }
}
