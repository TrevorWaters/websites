using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text;

namespace TaxCertPortal.Shared
{
    [Table("TaxCertificates")]
    public class TaxCertificate
    {
        public TaxCertificate()
        {
            DateModified = DateTime.Now.ToString();
        }
        [Key]
        public int TaxCertID { get; set; }
        [Required, DisplayName("Parcel Number")]
        public string ParcelNumber { get; set; }
        [Required, DisplayName("Certificate ID")]
        public string CertID { get; set; }
        [Required, DisplayName("For Unpaid Year")]
        public string UnpaidYear { get; set; }
        [Required, DisplayName("Certificate Price")]
        public string CertCost { get; set; }
        [Required, DisplayName("Interest Cost")]
        public string CertInterestCost { get; set; }
        [Required, DisplayName("Purchase Fee")]
        public string PurchaseFee { get; set; }
        [Required, DisplayName("Bill #")]
        public string BillNumber { get; set; }
        [Required, DisplayName("Date Purchased/Paid")]
        public string DateBought { get; set;}
        [Required, DisplayName("Comments")]
        public string Comments { get; set; }
        [Required, DisplayName("Acreage")]
        public string Acreage { get; set; }
        [Required, DisplayName("DateCreated")]
        public string DateCreated { get; set; }
        [Required, DisplayName("DateModified")]
        public string DateModified { get; set; }

    }
}
