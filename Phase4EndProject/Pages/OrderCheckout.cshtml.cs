using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace Phase4EndProject.Pages
{
    [BindProperties(SupportsGet = true)]
    public class OrderCheckoutModel : PageModel
    {
        public string? PizzaName { get; set; }
        public int Quantity { get; set; }
        public decimal TotalPrice => Quantity * 10;
        public void OnGet()
        {

        }

        public IActionResult OnPost()
        {
            return RedirectToPage("/OrderConfirmation", new OrderConfirmationModel { PizzaName = PizzaName, Quantity = Quantity, TotalAmount = TotalPrice });
        }
    }
}
