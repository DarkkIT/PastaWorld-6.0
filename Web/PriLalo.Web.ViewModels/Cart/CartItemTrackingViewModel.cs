namespace PriLalo.Web.ViewModels.Cart
{
    using System;
    using System.Collections.Generic;
    using System.Text;

    using PriLalo.Data.Models;
    using PriLalo.Web.ViewModels.Meals;
    using PriLalo.Services.Mapping;

    public class CartItemTrackingViewModel : IMapFrom<CartItem>
    {
        public int Quantity { get; set; }

        public int MealId { get; set; }

        public MealViewModel Meal { get; set; }

        public int OrderId { get; set; }
    }
}
