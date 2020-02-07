using System;
using static Admin.Data.Enums;

namespace Admin.Data
{
    public class PaymentDetail
    {
        public int Id { get; set; }
        public int PaymentDetailId { get; set; }


        public string PinCode { get; set; }

        public double AmountPaid { get; set; }

        public PaymentOption PaymentOption { get; set; }
        public string MemberId { get; set; }

        public DateTime PaymentDate { get; set; }

        public Member Member { get; set; }
        public string key { get; set; }
    }
}
