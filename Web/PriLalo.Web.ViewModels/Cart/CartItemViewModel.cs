﻿namespace PriLalo.Web.ViewModels.Cart
{
    public class CartItemViewModel
    {
        public int Id { get; set; }

        public string Name { get; set; }

        public decimal Price { get; set; }

        public string ImageName { get; set; }

        public string MainImagePath => "/images/meals/" + this.ImageName + ".jpg";

        public byte[] Image { get; set; }

        public int Quantity { get; set; }
    }
}
