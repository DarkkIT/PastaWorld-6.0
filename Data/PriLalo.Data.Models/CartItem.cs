﻿namespace PriLalo.Data.Models
{
    using PriLalo.Data.Common.Models;

    public class CartItem : BaseDeletableModel<int>
    {
        public int Quantity { get; set; }

        public int MealId { get; set; }

        public Meal Meal { get; set; }

        public int OrderId { get; set; }

        public Order Order { get; set; }
    }
}
