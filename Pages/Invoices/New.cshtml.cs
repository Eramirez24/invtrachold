using InvoiceTracker.Data;
using InvoiceTracker.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using SQLitePCL;

namespace InvoiceTracker.Pages.Invoices
{
    public class NewModel : PageModel
    {
        private readonly InvoicesDbContext _context;

        public NewModel(InvoicesDbContext context) => _context = context;

        public async Task<IActionResult> OnPostAsync()
        {

            if (!ModelState.IsValid)
            { 
                return Page();
            }
            
            Invoice.Created = DateTime.Now;
            await _context.Invoices.AddAsync(Invoice);
            await _context.SaveChangesAsync();

            return RedirectToPage("/Index");
        }

        [BindProperty]
        public  Invoice Invoice { get; set; }
    }

    
}
