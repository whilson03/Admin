using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Admin.Data;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.EntityFrameworkCore;

namespace Admin
{
    public class StaffUseRegistrationModel : PageModel
    {
        private readonly Admin.Data.ApplicationDbContext _context;
       

        public StaffUseRegistrationModel(Admin.Data.ApplicationDbContext context)
        {
            _context = context;
        }
        

        
        public  void OnGetAsync()
        {
           

        }


        public void search()
        {
            var id = StaffUserReg.Id;
            StaffUserReg = _context.StaffUserRegs.FirstOrDefault(m => m.Id == id);

        }



        [BindProperty]
        public StaffUserReg StaffUserReg { get; set; }
        public async Task<IActionResult> OnPostAsync()
        {

            if (!_context.StaffUserRegs.Any(u => u.Id == StaffUserReg.Id))
            {
                _context.StaffUserRegs.Add(StaffUserReg);
                await _context.SaveChangesAsync();
            }

            else
            {
               
            }
          
          
            return Page();


        }
     
        public async Task<IActionResult> OnPostSearch()
        {
            var id = StaffUserReg.Id;

            //find the user

            return null;
        }
    }
}