namespace PriLalo.Web.Controllers
{
    using System.Threading.Tasks;

    using Microsoft.AspNetCore.Mvc;
    using PriLalo.Services.Data.Cart;
    using PriLalo.Services.Data.Meal;

    [Route("api/[controller]")]
    [ApiController]
    public class MealApiController : Controller
    {
        private readonly IMealService mealService;
        private readonly ICartService cartService;

        public MealApiController(IMealService mealService, ICartService cartService)
        {
            this.mealService = mealService;
            this.cartService = cartService;
        }

        [HttpPost]
        public async Task<ActionResult<string>> Add(Neshto input)
        {
            //var meal = this.mealService.GetById<MealViewModel>(id);

            //var cart = new List<CartItemViewModel>();

            //var cartExists = this.HttpContext.Session.TryGetValue("cart", out byte[] result);

            //if (cartExists)
            //{
            //    cart = this.cartService.DeserializeCartContent(result);
            //}

            //cart = this.cartService.AddItemToCart(meal, cart);

            //var serializedCart = this.cartService.SerializeCartContent(cart);
            //this.HttpContext.Session.Set("cart", serializedCart);
            return "wazaaaa";
        }
    }

    public class Neshto
    {
        public string Id { get; set; }
    }
}
