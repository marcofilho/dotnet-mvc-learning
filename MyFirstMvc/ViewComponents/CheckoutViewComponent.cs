
using Microsoft.AspNetCore.Mvc;

namespace MyFirstMvc.ViewComponents
{
    [ViewComponent(Name = "Checkout")]
    public class CheckoutViewComponent : ViewComponent
    {
        public int CheckoutItens { get; set; }

        public CheckoutViewComponent()
        {
            CheckoutItens = 3;
        }

        public async Task<IViewComponentResult> InvokeAsync()
        {
            return View(CheckoutItens);
        }
    }
}