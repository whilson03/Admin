using Admin.Data;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.EntityFrameworkCore;
using System.Linq;
using System.Threading.Tasks;

namespace Admin
{
    public class BankDetailPageModel : PageModel
    {
        private readonly ApplicationDbContext _context;
        private readonly UserManager<IdentityUser> _userManager;


        public BankDetailPageModel(ApplicationDbContext context, UserManager<IdentityUser> userManager)
        {
            _context = context;
            _userManager = userManager;
        }

        [BindProperty]
        public BankDetail BankDetail { get; set; }

        public async Task OnGet()
        {
            var user = ( await GetCurrentUserAsync()).Id;

            BankDetail = await _context.BankDetails.FirstOrDefaultAsync(x => x.MemberId == user);
        }


        public async Task<IActionResult> OnPostAsync()
        {
            if (!ModelState.IsValid)
            {
                return Page();
            }

            var userId = (await GetCurrentUserAsync()).Id;

            if (!BankDetailExists(userId))
            {
                BankDetail.MemberId = userId;
                _context.BankDetails.Add(BankDetail);
                await _context.SaveChangesAsync();

            }
            else
            {
                var bankDetail = await _context.BankDetails.FirstOrDefaultAsync(x => x.Id == BankDetail.Id);
                bankDetail.NextOfKinAddress = BankDetail.NextOfKinAddress;
                bankDetail.NextOfKinName = BankDetail.NextOfKinName;
                bankDetail.NextOfKinRelationship = BankDetail.NextOfKinRelationship;
                bankDetail.AccountNumber = BankDetail.AccountNumber;
                bankDetail.BankName = BankDetail.BankName;
                bankDetail.NextOfKinPhoneNumber = BankDetail.NextOfKinPhoneNumber;
                await _context.SaveChangesAsync();
            }

 
            return Page();
        }

        private Task<IdentityUser> GetCurrentUserAsync() => _userManager.GetUserAsync(HttpContext.User);


        private bool BankDetailExists(string id)
        {
            return _context.BankDetails.Any(e => e.MemberId == id);
        }
    }


}