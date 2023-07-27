using InvoiceTracker.Data;
using InvoiceTracker.Models;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.EntityFrameworkCore;

namespace InvoiceTracker.Pages
{
    public class IndexModel : PageModel
    {
        private readonly InvoicesDbContext _Context;
        public List<Invoice> Invoices { get; set; } = new List<Invoice>();


        public IndexModel(InvoicesDbContext Context) => _Context = Context;


        //Handler Method- Get method is the method that request information from a source
        public async void OnGet() 
        {

            Invoices = await _Context.Invoices.FromSql($"SELECT * FROM Invoice")
                .ToListAsync();
        }

     
    }
    
}