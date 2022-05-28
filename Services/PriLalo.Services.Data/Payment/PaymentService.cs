namespace PriLalo.Services.Data.Payment
{
    using System.Collections.Generic;
    using System.Threading.Tasks;

    using PriLalo.Data.Models;
    using PriLalo.Web.ViewModels.Cart;
    using PriLalo.Web.ViewModels.Orders;
    using PriLalo.Data.Common.Repositories;

    public class PaymentService : IPaymentService
    {
        private readonly IDeletableEntityRepository<Order> orderRepository;
        private readonly IDeletableEntityRepository<SiteSetting> siteSettingRepository;

        public PaymentService(IDeletableEntityRepository<Order> orderRepository, IDeletableEntityRepository<SiteSetting> siteSettingRepository)
        {
            this.orderRepository = orderRepository;
            this.siteSettingRepository = siteSettingRepository;
        }

        public async Task AddOrder(OrderPaymentViewModel model)
        {
            var cartItems = new List<CartItem>();

            foreach (var item in model.Items)
            {
                var cartItem = new CartItem();
                cartItem.MealId = item.Id;
                cartItem.Quantity = item.Quantity;

                cartItems.Add(cartItem);
            }

            var order = new Order();

            if (model.UserOrOtherAddress.Equals(OrderConstants.DeliveryToCustomerAddress))
            {
                order.Address = model.Address;
                order.AddressComment = model.AddressComment;
                order.IsUserAddress = true;
            }

            order.PhoneNumber = model.PhoneNumber;
            order.City = model.Town;
            order.Email = model.Email;

            order.FirstName = model.FirstName;
            order.FamilyName = model.FamilyName;
            order.ClientId = model.CliendId;

            order.IsAgreedTermsAndConditions = model.IsAgreedTermsAndConditions;
            order.IsBankCard = false;

            order.Items = cartItems;
            order.MealsPrice = model.MealsPrice;
            order.DeliveryPrice = model.DeliveryPrice;
            order.TotalPrice = model.TotalPrice;

            order.Status = model.Status;

            await this.orderRepository.AddAsync(order);
            await this.orderRepository.SaveChangesAsync();
        }

        public decimal GetTotalPriceWithDelivery(decimal deliveryPrice, decimal currentPrice)
        {
            var totalPrice = deliveryPrice + currentPrice;

            return totalPrice;
        }

        public decimal GetDeliveryPrice(decimal currentPrice)
        {
            //siteSettingRepository.

            var deliveryPrice = 0m;

            if (currentPrice < 10)
            {
                deliveryPrice = 5.00m;
            }

            return deliveryPrice;
        }

        public decimal GetAllMealsCurrentPrice(IList<CartItemViewModel> cart)
        {
            var mealsCurrentPrice = 0m;

            foreach (var item in cart)
            {
                mealsCurrentPrice += this.GetMealTotalPrice(item.Price, item.Quantity);
            }

            return mealsCurrentPrice;
        }

        public decimal GetMealTotalPrice(decimal mealPrice, decimal quantity)
        {
            var totalPrice = mealPrice * quantity;

            return totalPrice;
        }
    }
}
