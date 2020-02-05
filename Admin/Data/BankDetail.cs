using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Admin.Data
{
    public class BankDetail
    {
        public int Id { get; set; }

        public int MemberId { get; set; }

        public Member Member { get; set; }

        public string BankName { get; set;}

        public string AccountNumber { get; set; }

        public string NextOfKinName { get; set; }

        public String NextOfKinAddress { get; set; }

        public String NextOfKinPhoneNumber { get; set; }

        public String NextOfKinRelationship { get; set; }
    }
}
