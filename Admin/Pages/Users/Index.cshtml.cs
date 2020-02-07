using Admin.Data;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.EntityFrameworkCore;
using System.Linq;
using System.Threading.Tasks;

namespace Admin
{
    public class IndexModel : PageModel
    {
        private readonly ApplicationDbContext _context;
        private readonly UserManager<IdentityUser> _userManager;

        [BindProperty]
        public Member Member { get; set; }

        public IndexModel(ApplicationDbContext context, UserManager<IdentityUser> userManager)
        {
            _context = context;
            _userManager = userManager;
        }
        public async Task OnGet()
        {
            var user = (await GetCurrentUserAsync()).Id;

            Member = await _context.Members.FirstOrDefaultAsync(x => x.Id == user);
        }


        public async Task<IActionResult> OnPostAsync()
        {
            if (!ModelState.IsValid)
            {
                return Page();
            }

            var member = await _context.Members.FirstOrDefaultAsync(x => x.Id == Member.Id);


            member.Firstname = Member.Firstname;
            member.Surname = Member.Surname;
            member.Middlename = Member.Middlename;
            member.PhoneNumber = Member.PhoneNumber;
            member.WhatsAppNumber = Member.WhatsAppNumber;
            member.SponsorName = Member.SponsorName;
            member.DateOfBirth = Member.DateOfBirth;
            member.NameOfUpLine = Member.NameOfUpLine;
            member.Country = Member.Country;
            member.State = Member.State;
            member.Title = Member.Title;
            member.Address = Member.Address;
            member.City = Member.City;
            member.RegistrationDate = Member.RegistrationDate;


           
            
            
            await _context.SaveChangesAsync();

            return Page();
       
        }


    private Task<IdentityUser> GetCurrentUserAsync() => _userManager.GetUserAsync(HttpContext.User);
    }
}
