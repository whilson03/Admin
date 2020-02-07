using Microsoft.AspNetCore.Identity;
using System;
using static Admin.Data.Enums;

namespace Admin.Data
{
    public class Member : IdentityUser
    {
        public Title Title { get; set; }

        public string Surname { get; set; }

        public string ImageUrl { get; set; }

        public string Firstname { get; set; }

        public string Middlename { get; set; }

        public string Address { get; set; }

        public string Country { get; set; }

        public string State { get; set; }

        public string City { get; set; }

        public string WhatsAppNumber { get; set; }

        public string SponsorName { get; set; }

        public string NameOfUpLine { get; set; }

        public DateTime DateOfBirth { get; set; }

        public DateTime RegistrationDate { get; set; }
        public int? BankDetailId { get; set; }

        public string BankName { get; set; }

        public string AccountNumber { get; set; }

        public string NextOfKinName { get; set; }

        public string NextOfKinAddress { get; set; }

        public string NextOfKinPhoneNumber { get; set; }

        public string NextOfKinRelationship { get; set; }


        public string PinCode { get; set; }

        public double AmountPaid { get; set; }

        public PaymentOption PaymentOption { get; set; }


        public DateTime PaymentDate { get; set; }

    }
}
