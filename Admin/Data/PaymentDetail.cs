using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using static Admin.Data.Enums;

namespace Admin.Data
{
    public class PaymentDetail
    {
        public string PinCode { get; set; }

        public double AmountPaid { get; set; }


        public PaymentOption PaymentOption { get; set; }

        public DateTime PaymentDate { get; set; }

        public int Id { get; set; }

        public Member Member { get; set; }

        public int MemberId{ get; set;}

    }
}
