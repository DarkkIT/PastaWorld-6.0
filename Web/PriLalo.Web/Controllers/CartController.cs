namespace PriLalo.Web.Controllers
{
    using System.Collections.Generic;

    using Microsoft.AspNetCore.Mvc;

    using PriLalo.Services.Data.Cart;
    using PriLalo.Services.Data.Meal;
    using PriLalo.Web.ViewModels.Cart;
    using PriLalo.Web.ViewModels.Meals;

    public class CartController : BaseController
    {
        private readonly IMealService mealService;
        private readonly ICartService cartService;

        public CartController(IMealService mealService, ICartService cartService)
        {
            this.mealService = mealService;
            this.cartService = cartService;
        }

        public IActionResult Index()
        {
            var cartIsNotEmpty = this.HttpContext.Session.TryGetValue("cart", out byte[] cartContentAsByteArray);

            var cart = new List<CartItemViewModel>();

            if (cartIsNotEmpty)
            {
                cart = this.cartService.DeserializeCartContent(cartContentAsByteArray);
            }
            else
            {
                byte[] cartAsByteArray = this.cartService.SerializeCartContent(cart);
                this.HttpContext.Session.Set("cart", cartAsByteArray);
            }

            return this.View(cart);
        }

        public IActionResult Remove(int id)
        {
            var cartExists = this.HttpContext.Session.TryGetValue("cart", out byte[] cartContentAsByteArray);

            var cart = new List<CartItemViewModel>();

            cart = this.cartService.DeserializeCartContent(cartContentAsByteArray);
            cart = this.cartService.RemoveItemFromCart(id, cart);

            this.HttpContext.Session.Set("cart", this.cartService.SerializeCartContent(cart));

            return this.RedirectToAction("Index");
        }

        public IActionResult Add(int id)
        {
            var meal = this.mealService.GetById<MealViewModel>(id);

            var cart = new List<CartItemViewModel>();

            var cartExists = this.HttpContext.Session.TryGetValue("cart", out byte[] result);

            if (cartExists)
            {
                cart = this.cartService.DeserializeCartContent(result);
            }

            cart = this.cartService.AddItemToCart(meal, cart);

            var serializedCart = this.cartService.SerializeCartContent(cart);
            this.HttpContext.Session.Set("cart", serializedCart);

            var previousUrl = this.HttpContext.Request.Headers["Referer"].ToString();

            return this.Redirect(previousUrl);
        }
    }
}
