﻿namespace Admin.Data
{
    public class BankDetail
    {
        public int Id { get; set; }

        public string BankName { get; set; }

        public string AccountNumber { get; set; }

        public string NextOfKinName { get; set; }

        public string NextOfKinAddress { get; set; }

        public string NextOfKinPhoneNumber { get; set; }

        public string NextOfKinRelationship { get; set; }

        public string MemberId { get; set; }

        public Member Member { get; set; }

        public string key { get; set; }
    }
}