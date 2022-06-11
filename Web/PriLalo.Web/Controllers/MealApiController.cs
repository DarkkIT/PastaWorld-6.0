namespace PriLalo.Web.Controllers
{
    using System.Collections.Generic;
    using System.Linq;
    using System.Threading.Tasks;

    using Microsoft.AspNetCore.Mvc;
    using PriLalo.Services.Data.Cart;
    using PriLalo.Services.Data.Meal;
    using PriLalo.Web.ViewModels.Cart;
    using PriLalo.Web.ViewModels.Meals;

    [Route("[controller]")]
    [ApiController]
    public class MealApiController : ControllerBase
    {
        private readonly IMealService mealService;
        private readonly ICartService cartService;

        public MealApiController(IMealService mealService, ICartService cartService)
        {
            this.mealService = mealService;
            this.cartService = cartService;
        }

        [HttpPost]
        public async Task<ActionResult<int>> Add([FromBody] MealToAddViewModel input)
        {
            var meal = this.mealService.GetById<MealViewModel>(input.Id);

            var cart = new List<CartItemViewModel>();

            var cartExists = this.HttpContext.Session.TryGetValue("cart", out byte[] result);

            if (cartExists)
            {
                cart = this.cartService.DeserializeCartContent(result);
            }

            cart = this.cartService.AddItemToCart(meal, cart);

            var serializedCart = this.cartService.SerializeCartContent(cart);
            this.HttpContext.Session.Set("cart", serializedCart);

            return cart.Sum(x => x.Quantity);
        }
    }

}
