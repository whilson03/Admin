using Admin.Data;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Admin.Pages.PolicySetup
{
    public class PolicysModel : PageModel
    {
        private readonly ApplicationDbContext _context;
        private readonly UserManager<IdentityUser> _userManager;


        public PolicysModel(ApplicationDbContext context, UserManager<IdentityUser> userManager)
        {
            _context = context;
            _userManager = userManager;
        }
        [BindProperty]
        public Policy Policy { get; set; }
        public async Task<IActionResult> OnGetAsync()
        {
            // require  id to retrieve
            
            Policy =  await _context.Policies.FirstOrDefaultAsync(m => m.ID == 1);

            return Page();
        }
        
        public async Task<IActionResult> OnPostAsync()
        {
           
            if (!_context.Policies.Any(e => e.ID == Policy.ID))
            {
                _context.Policies.Add(Policy);
                await _context.SaveChangesAsync();
            }
            else
            {
                var pos = await _context.Policies.FirstOrDefaultAsync(x => x.ID == Policy.ID); 
                pos.Every = Policy.Every;
                pos.Member_Circle = Policy.Member_Circle;
                pos.Allow_Circle = Policy.Allow_Circle;
                pos.Allowcheck = Policy.Allowcheck;
                pos.Chargecheck = Policy.Chargecheck;
                pos.Reusecheck = Policy.Reusecheck;
                pos.Disallowcheck = Policy.Disallowcheck;
                pos.Maximum_mem = Policy.Maximum_mem;
                pos.Pay_mem = Policy.Pay_mem;
                pos.Every = Policy.Every;
                pos.Member_num = Policy.Member_num;
                await _context.SaveChangesAsync();
            }
            

            ModelState.Clear();
            return Page();

        }
        private Task<IdentityUser> GetCurrentUserAsync() => _userManager.GetUserAsync(HttpContext.User);

    }
}