using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Threading.Tasks;

namespace Admin.Data
{
    public class StaffUserReg
    {
        public int Id { get; set; }
       // public int? StaffId { get; set; }
        public DateTime? DateSuspended { get; set; } = DateTime.Now;               
        public string Title { get; set; }
        public string Suspended { get; set; }
        public string Surname { get; set; }
        public string OtherNames {get; set;}      
        public string Department { get; set; }
       

    }
}