using System;

namespace Devon4Net.WebAPI.Implementation.Business.InhabitantsManagement.Dto
{
    public class UserTaxesDto
    {
        public string TaxName { get; set; }
        public int TaxYear { get; set; }
        public double AmountToPay { get; set; }
        public string Reference { get; set; }
        public DateTime PaymentDeadLine { get; set; }
        public bool Paid { get; set; }
        public bool Surcharge { get; set; }
    }
}