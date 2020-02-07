using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Admin.Data;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.EntityFrameworkCore;

namespace Admin.Pages.Users
{

    public class PaymentDetailPageModel : PageModel
    {
        private readonly ApplicationDbContext _context;
        private readonly UserManager<IdentityUser> _userManager;


        public PaymentDetailPageModel(ApplicationDbContext context, UserManager<IdentityUser> userManager)
        {
            _context = context;
            _userManager = userManager;
        }

        [BindProperty]
        public PaymentDetail PaymentDetail { get; set; }

        public async Task OnGet()
        {
            var user = (await GetCurrentUserAsync()).Id;

            PaymentDetail = await _context.PaymentDetails.FirstOrDefaultAsync(x => x.MemberId == user);
        }


        public async Task<IActionResult> OnPostAsync()
        {
            //if (!ModelState.IsValid)
            //{
            //    return Page();
            //}

            var userId = (await GetCurrentUserAsync()).Id;

            if (!PaymentDetailExists(userId))
            {
                PaymentDetail.MemberId = userId;
                _context.PaymentDetails.Add(PaymentDetail);
                await _context.SaveChangesAsync();

            }
            else
            {
                var paymentDetail = await _context.PaymentDetails.FirstOrDefaultAsync(x => x.Id == PaymentDetail.Id);
                paymentDetail.PinCode = PaymentDetail.PinCode;
                paymentDetail.AmountPaid = PaymentDetail.AmountPaid;
                paymentDetail.PaymentOption = PaymentDetail.PaymentOption;
                paymentDetail.PaymentDate = PaymentDetail.PaymentDate;
                await _context.SaveChangesAsync();
            }


            return Page();
        }

        private Task<IdentityUser> GetCurrentUserAsync() => _userManager.GetUserAsync(HttpContext.User);


        private bool PaymentDetailExists(string id)
        {
            return _context.PaymentDetails.Any(e => e.MemberId == id);
        }
    }
}