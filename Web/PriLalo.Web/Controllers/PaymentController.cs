namespace PriLalo.Web.Controllers
{
    using System.Collections.Generic;
    using System.Linq;
    using System.Security.Claims;
    using System.Threading.Tasks;
    using Microsoft.AspNetCore.Identity;
    using Microsoft.AspNetCore.Mvc;
    using PriLalo.Common;
    using PriLalo.Data.Models;
    using PriLalo.Services.Data.Cart;
    using PriLalo.Services.Data.Payment;
    using PriLalo.Web.ViewModels.Cart;
    using PriLalo.Web.ViewModels.Orders;

    public class PaymentController : BaseController
    {
        private readonly ICartService cartService;
        private readonly IPaymentService paymentService;
        private readonly UserManager<ApplicationUser> userManager;

        public PaymentController(ICartService cartService, IPaymentService paymentService, UserManager<ApplicationUser> userManager)
        {
            this.cartService = cartService;
            this.paymentService = paymentService;
            this.userManager = userManager;
        }

        public async Task<IActionResult> Index()
        {
            var cartIsNotEmpty = this.HttpContext.Session.TryGetValue("cart", out byte[] cartContentAsByteArray);

            var cart = new List<CartItemViewModel>();
            var order = new OrderPaymentViewModel();

            if (cartIsNotEmpty && cartContentAsByteArray.Count() > 2)
            {
                cart = this.cartService.DeserializeCartContent(cartContentAsByteArray);
            }
            else
            {
                order.Items = new List<CartItemViewModel>();
                return this.View(order);
            }

            order.Items = cart;
            order.MealsPrice = this.paymentService.GetAllMealsCurrentPrice(cart);
            order.DeliveryPrice = this.paymentService.GetDeliveryPrice(order.MealsPrice);
            order.TotalPrice = this.paymentService.GetTotalPriceWithDelivery(order.DeliveryPrice, order.MealsPrice);
            order.HasItemsInCart = true;

            if (this.User.Identity.IsAuthenticated)
            {
                var user = await this.userManager.GetUserAsync(this.HttpContext.User);

                order.FirstName = user.FirstName;
                order.FamilyName = user.LastName;
                order.PhoneNumber = user.PhoneNumber;
                order.Address = user.Address;
                order.Email = user.Email;
            }

            return this.View(order);
        }

        [HttpPost]
        public async Task<IActionResult> Index(OrderPaymentViewModel model)
        {
            if (model.UserOrOtherAddress.Equals(OrderConstants.DeliveryToOurRestaurant))
            {
                model.Address = "N/A";
                model.AddressComment = "Без доставка. Поръчката ще се вземе от ресторанта!";
                this.ModelState.ClearValidationState(nameof(model.Address));
            }

            var cartIsNotEmpty = this.HttpContext.Session.TryGetValue("cart", out byte[] cartContentAsByteArray);

            var cart = new List<CartItemViewModel>();

            if (cartIsNotEmpty && cartContentAsByteArray.Count() > 2)
            {
                cart = this.cartService.DeserializeCartContent(cartContentAsByteArray);
            }
            else
            {
                model.Items = new List<CartItemViewModel>();
                return this.View(model);
            }

            model.Items = cart;
            model.Status = GlobalConstants.Accepted;
            model.MealsPrice = this.paymentService.GetAllMealsCurrentPrice(cart);
            model.DeliveryPrice = this.paymentService.GetDeliveryPrice(model.MealsPrice);
            model.TotalPrice = this.paymentService.GetTotalPriceWithDelivery(model.DeliveryPrice, model.MealsPrice);
            model.HasItemsInCart = true;

            var isValid = this.TryValidateModel(model);

            if (!isValid)
            {
                return this.View(model);
            }

            var user = await this.userManager.GetUserAsync(this.User);

            if (user != null)
            {
                model.CliendId = user.Id;
            }

            await this.paymentService.AddOrder(model);

            return this.RedirectToAction(nameof(this.Success));
        }

        public IActionResult Success()
        {
            var cart = new List<CartItemViewModel>();

            this.HttpContext.Session.Set("cart", this.cartService.SerializeCartContent(cart));

            return this.View();
        }
    }
}
