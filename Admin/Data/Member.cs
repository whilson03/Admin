using Microsoft.AspNetCore.Identity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
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

        public int? PaymentDetailId { get; set; }
        public int? BankDetailId { get; set; }


        // navigation property
        public BankDetail BankDetail { get; set; }

        public PaymentDetail PaymentDetail { get; set; }


    }
}
