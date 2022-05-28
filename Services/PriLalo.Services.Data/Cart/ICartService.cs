namespace PriLalo.Services.Data.Cart
{
    using System.Collections.Generic;

    using PriLalo.Web.ViewModels.Cart;
    using PriLalo.Web.ViewModels.Meals;

    public interface ICartService
    {
        List<CartItemViewModel> DeserializeCartContent(byte[] cartContentAsByteArray);

        byte[] SerializeCartContent(List<CartItemViewModel> cart);

        List<CartItemViewModel> AddItemToCart(MealViewModel meal, List<CartItemViewModel> cart);

        List<CartItemViewModel> RemoveItemFromCart(int id, List<CartItemViewModel> cart);
    }
}
