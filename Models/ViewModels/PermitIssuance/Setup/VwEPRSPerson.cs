using Models.DatabaseModels.Authentication;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Models.ViewModels.PermitIssuance.Setup
{
    public class VwEPRSPerson
    {
        public long PersonId { get; set; }
        public string PersonName { get; set; }
        public string CNIC_PASSPORT { get; set; }
        public string CellNo { get; set; }
        public string Address { get; set; }
        public string City { get; set; }
        public DateTime DateofBirth { get; set; }
        public DateTime VisaExpiryDate { get; set; }
        public decimal Age { get; set; }
    }
}
