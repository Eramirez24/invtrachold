using System.ComponentModel.DataAnnotations;

namespace InvoiceTracker.Models;

public class Invoice
{
    public int Id { get; set; }

    [Required(ErrorMessage = "Please Enter Customer Name")]
    [StringLength(100)]
    public string? CustomerName { get; set; }

    [Required(ErrorMessage = "Please Enter A Phone Number")]
    [RegularExpression(@"^[0-9]+$",ErrorMessage = "Please Enter A Valid Phone Number")]
    [StringLength(10)]
    public string? CustomerPhoneNumber { get; set; }

    [Required(ErrorMessage = "Please Enter A Email Address")]
    [RegularExpression(@"^[A-Za-z0-9_.+-]+@[A-Za-z]+\.[a-zA-Z][a-zA-Z][a-zA-Z]$",ErrorMessage ="Please Enter A Valid Email Address")]
    public string? Email { get; set; } 

    [Required(ErrorMessage = "Please Enter A Parts Description")]
    [StringLength(500)]
    public string? PartDesc { get; set; } 

    public DateTime Created { get; set; }

    public DateTime? Completed { get; set; }
}

