using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace Admin.Data
{
    public class Policy
    {
        public int ID { get; set; }

        public int Member_Circle { get; set; }
        
        public int Allow_Circle { get; set; }
       
        public bool Allowcheck { get; set; }
        
        public bool Chargecheck { get; set; }
        
        public bool Reusecheck { get; set; }
        
        public bool Disallowcheck { get; set; }
        
        public int Maximum_mem { get; set; }
        
        public string Pay_mem { get; set; }
        
        public int Every { get; set; }
        
        public string Member_num { get; set; }

        

    }
}
