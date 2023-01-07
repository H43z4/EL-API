using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Models.ViewModels.SeriesNumberPool.Core
{
    public class VwAdvancePayment
    {
        public long AdvancePaymentId { get; set; }
        public long SeriesCategoryId { get; set; }
        public string SeriesCategory { get; set; }
        public long SeriesId { get; set; }
        public string SeriesName { get; set; }
        public long SeriesNumberId { get; set; }
        public string SeriesNumberName { get; set; }
        public long BasePrice { get; set; } 
        public long AdvancePaymentStatusId { get; set; }
        public string PaymentStatus { get; set; }
        public long PSId { get; set; }
        public string PaidOn { get; set; }
        public string BankCode { get; set; }
        public string ChasisNumber { get; set; }
        public string OwnerName { get; set; }
        public string CNICNTN { get; set; }
    }
}
