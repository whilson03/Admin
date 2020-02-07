using Microsoft.AspNetCore.Mvc.Rendering;
using System;

namespace Admin.Pages.Users
{
    public static class ManageNavPages
    {
        public static string BioData => "BIODATA";

        public static string BankDetail => "BANK DETAIL";

        public static string PaymentDetail => "PAYMENT DETAIL";

        public static string BioDataNavClass(ViewContext viewContext) => PageNavClass(viewContext, BioData);

        public static string BankDetailNavClass(ViewContext viewContext) => PageNavClass(viewContext, BankDetail);

        public static string PaymentDetailNavClass(ViewContext viewContext) => PageNavClass(viewContext, PaymentDetail);

        private static string PageNavClass(ViewContext viewContext, string page)
        {
            var activePage = viewContext.ViewData["ActivePage"] as string
                ?? System.IO.Path.GetFileNameWithoutExtension(viewContext.ActionDescriptor.DisplayName);
            return string.Equals(activePage, page, StringComparison.OrdinalIgnoreCase) ? "active" : null;
        }
    }
}